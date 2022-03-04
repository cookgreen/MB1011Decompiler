using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBDecompiler
{
    public class MBTrooper
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PuralName { get; set; }
        public string Flags { get; set; }
        public string Scene { get; set; }
        public string Reserved { get; set; }
        public string Faction { get; set; }
        public string Equipments { get; set; }
        public string Attributes { get; set; }
        public string Skills { get; set; }
        public string WPEX { get; set; }
        public string FaceCode { get; set; }

        public MBTrooper()
        {
            Scene = "no_scene";
            Reserved = "reserved";
            FaceCode = "0";
        }
    }

    public class MBTrooperReader
    {
        private string trooperTextFile;
        private Dictionary<int, string> itemIDFiles;
        private Dictionary<int, string> factionIDFiles;
        private Dictionary<int, string> skillIDFiles;

        private List<string> skins = new List<string>
        {
            "male",
            "female",
            "undead"
        };

        public MBTrooperReader(
            string trooperTextFile,
            Dictionary<int, string> itemIDFiles,
            Dictionary<int, string> factionIDFiles,
            Dictionary<int, string> skillIDFiles)
        {
            this.trooperTextFile = trooperTextFile;
            this.itemIDFiles = itemIDFiles;
            this.factionIDFiles = factionIDFiles;
            this.skillIDFiles = skillIDFiles;
        }

        public MBTrooperReader(string trooperTextFile)
        {
            this.trooperTextFile = trooperTextFile;
        }

        private List<string[]> read()
        {
            List<string[]> trooperTextDataList = new List<string[]>();

            string[] trooperTextDataArr = new string[6];
            int index = 0;
            int lineNo = 1;

            using (StreamReader reader = new StreamReader(trooperTextFile))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine();

                    if (lineNo >= 3)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            trooperTextDataArr[index] = line.TrimStart().TrimEnd();
                            index++;
                        }
                        else
                        {
                            trooperTextDataList.Add(trooperTextDataArr);

                            trooperTextDataArr = new string[6];
                            index = 0;
                        }
                    }

                    lineNo++;
                }
            }
            return trooperTextDataList;
        }

        private List<MBTrooper> parse(List<string[]> trooperTextDataList)
        {
            List<MBTrooper> troopers = new List<MBTrooper>();

            foreach(var trooperTextDataArr in trooperTextDataList)
            {
                troopers.Add(parseSingleTrooper(trooperTextDataArr));
            }
            return troopers;
        }

        private MBTrooper parseSingleTrooper(string[] trooperTextData)
        {
            string[] trooperTuple = trooperTextData;
            MBTrooper trooper = new MBTrooper();

            string trooperLine = trooperTuple[0];
            string[] tokens = trooperLine.Split(' ');
            trooper.ID = tokens[0].Substring(4);
            trooper.Name = tokens[1].Replace("_", " ");
            trooper.PuralName = tokens[2].Replace("_", " ");
            uint trooperFlags = uint.Parse(tokens[3]);
            trooper.Flags = decompileFlags(trooperFlags);
            trooper.Scene = "no_scene";
            int factionIndex = int.Parse(tokens[6]);
            int up1 = int.Parse(tokens[7]);
            int up2 = int.Parse(tokens[8]);
            trooper.Faction = factionIDFiles[factionIndex];

            string equipmentLine = trooperTuple[1];
            if (!equipmentLine.StartsWith("-1"))
            {
                StringBuilder equipStrBuilder = new StringBuilder();
                equipmentLine = equipmentLine.Substring(0, equipmentLine.IndexOf("-1"));
                string[] equipTokens = equipmentLine.Split(' ').Where(o => !string.IsNullOrEmpty(o) && o != "0").ToArray();
                for (int i = 0; i < equipTokens.Length; i++)
                {
                    equipStrBuilder.Append(itemIDFiles[int.Parse(equipTokens[i])]);
                    if (i != equipTokens.Length - 1)
                    {
                        equipStrBuilder.Append(',');
                    }
                }
                trooper.Equipments = equipStrBuilder.ToString();
            }

            string attrLine = trooperTuple[2];
            tokens = attrLine.Split(' ');
            trooper.Attributes = string.Format("str_{0}|agi_{1}|int_{2}|cha_{3}|level({4})",
                tokens[0], tokens[1], tokens[2], tokens[3], tokens[4]);

            string wpLine = trooperTuple[3];
            tokens = wpLine.Split(' ');
            var iWP = new int[7];
            iWP[0] = int.Parse(tokens[0]);
            iWP[1] = int.Parse(tokens[1]);
            iWP[2] = int.Parse(tokens[2]);
            iWP[3] = int.Parse(tokens[3]);
            iWP[4] = int.Parse(tokens[4]);
            iWP[5] = int.Parse(tokens[5]);
            iWP[6] = int.Parse(tokens[6]);
            string strWP = string.Empty;
            if (iWP[0] == iWP[1] && iWP[1] == iWP[2] && iWP[2] == iWP[3] && iWP[3] == iWP[4] && iWP[4] == iWP[5])
            {
                strWP = string.Format("wp({0}){1}", iWP[0], iWP[6] == 0 ? "" : "|wp_firearm(" + iWP[6] + ")");
            }
            else if (iWP[0] == iWP[1] && iWP[1] == iWP[2])
            {
                strWP = string.Format("wpe({0},{1},{2},{3}){4}", iWP[0], iWP[3], iWP[4], iWP[5], iWP[6] == 0 ? "" : "|wp_firearm(" + iWP[6] + ")");
            }
            else
            {
                strWP = string.Format("wpex({0},{1},{2},{3},{4},{5}){6}", iWP[0], iWP[1], iWP[2], iWP[3], iWP[4], iWP[5], iWP[6] == 0 ? "" : "|wp_firearm(" + iWP[6] + ")");
            }
            trooper.WPEX = strWP;

            string knowsLine = trooperTuple[4];
            string[] knowsTokens = knowsLine.Split(' ');
            var sbKnow = new StringBuilder(512);
            for (int x = 0; x < 6; x++)
            {
                var dword = ulong.Parse(knowsTokens[x]);
                if (dword == 0)
                {
                    continue;
                }
                for (int q = 0; q < 8; q++)
                {
                    var dwKnow = 0xF & (dword >> (q << 2));
                    if (dwKnow != 0 && (x << 3) + q < skillIDFiles.Count) sbKnow.Append($"knows_{skillIDFiles[(x << 3) + q].Substring(4)}_{dwKnow}|");
                }
            }

            if (sbKnow.Length == 0)
            {
                sbKnow.Append('0');
            }
            else
            {
                sbKnow.Length--;
            }
            trooper.Skills = sbKnow.ToString();

            string faceLine = trooperTuple[5];
            string[] faceTokens = faceLine.Split(' ');
            string strFace = $"0x{ulong.Parse(faceTokens[0]):x16}{ulong.Parse(faceTokens[1]):x16}{ulong.Parse(faceTokens[2]):x16}{ulong.Parse(faceTokens[3]):x16},0x{ulong.Parse(faceTokens[4]):x16}{ulong.Parse(faceTokens[5]):x16}{ulong.Parse(faceTokens[6]):x16}{ulong.Parse(faceTokens[7]):x16}";
            trooper.FaceCode = strFace;
            return trooper;
        }

        public string decompileFlags(uint dwFlag)
        {
            var sbFlag = new StringBuilder(1024);

            uint dwSkin = dwFlag & 0xF;
            if (dwSkin > 0) sbFlag.Append(dwSkin < skins.Count ? "tf_" + skins[(int)dwSkin] + "|" : $"{dwSkin}|");

            if ((dwFlag & 0x7F00000) - 0x7F00000 == 0)
            {
                sbFlag.Append("tf_guarantee_all|");
                dwFlag ^= 0x7F00000;
            }
            else if ((dwFlag & 0x3F00000) - 0x3F00000 == 0)
            {
                sbFlag.Append("tf_guarantee_all_wo_ranged|");
                dwFlag ^= 0x3F00000;
            }
            string[] strFlags = { "tf_hero", "tf_inactive", "tf_unkillable", "tf_allways_fall_dead", "tf_no_capture_alive", "tf_mounted",
            "tf_is_merchant", "tf_randomize_face", "tf_guarantee_boots", "tf_guarantee_armor", "tf_guarantee_helmet", "tf_guarantee_gloves",
            "tf_guarantee_horse", "tf_guarantee_shield", "tf_guarantee_ranged", "tf_unmoveable_in_party_window" };
            uint[] dwFlags = { 0x00000010, 0x00000020, 0x00000040, 0x00000080, 0x00000100, 0x00000400, 0x00001000, 0x00008000, 0x00100000,
            0x00200000, 0x00400000, 0x00800000, 0x01000000, 0x02000000, 0x04000000, 0x10000000 };
            for (int i = 0; i < dwFlags.Length; i++)
            {
                if ((dwFlag & dwFlags[i]) == 0) continue;
                sbFlag.Append(strFlags[i]);
                sbFlag.Append('|');
                dwFlag ^= dwFlags[i];
            }

            if (sbFlag.Length == 0)
                sbFlag.Append('0');
            else
                sbFlag.Length--;

            return sbFlag.ToString();
        }

        public string ToMSPythonOutputFile(string outputPythonFile, bool isGenerateIDFile = false)
        {
            StringBuilder builder = new StringBuilder();
            var troopers = parse(read());
            using (StreamWriter writer = new StreamWriter(outputPythonFile))
            {
                foreach (var trooper in troopers)
                {
                    string pythonLine = string.Format("[\"{0}\", \"{1}\", \"{2}\",{3}, 0, 0, {4},[{5}],{6},{7},{8},{9}],",
                        trooper.ID, 
                        trooper.Name, 
                        trooper.PuralName, 
                        trooper.Flags, 
                        trooper.Faction, 
                        trooper.Equipments, 
                        trooper.Attributes, 
                        trooper.WPEX, 
                        trooper.Skills, 
                        trooper.FaceCode);
                    builder.Append(pythonLine);
                    writer.WriteLine(pythonLine);
                }
            }

            return builder.ToString();
        }

        public string GenerateIDFile(string outputFile)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                int index = 0;
                var dataList = read();
                foreach (var data in dataList)
                {
                    string line = string.Format("{0} = {1}", data[0].Split(' ')[0], index);
                    writer.WriteLine(line);
                    builder.AppendLine(line);
                    index++;
                }
            }
            return builder.ToString();
        }
    }
}
