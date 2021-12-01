using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBDecompiler
{
    public class MBItemConst
    {
        #region const variables
        public const uint itp_type_horse           = 0x00000001;
        public const uint itp_type_one_handed_wpn  = 0x00000002;
        public const uint itp_type_two_handed_wpn  = 0x00000003;
        public const uint itp_type_polearm         = 0x00000004;
        public const uint itp_type_arrows          = 0x00000005;
        public const uint itp_type_bolts           = 0x00000006;
        public const uint itp_type_shield          = 0x00000007;
        public const uint itp_type_bow             = 0x00000008;
        public const uint itp_type_crossbow        = 0x00000009;
        public const uint itp_type_thrown          = 0x0000000a;
        public const uint itp_type_goods           = 0x0000000b;
        public const uint itp_type_head_armor      = 0x0000000c;
        public const uint itp_type_body_armor      = 0x0000000d;
        public const uint itp_type_foot_armor      = 0x0000000e;
        public const uint itp_type_hand_armor      = 0x0000000f;
        public const uint itp_type_pistol          = 0x00000010;
        public const uint itp_type_musket          = 0x00000011;
        public const uint itp_type_bullets         = 0x00000012;
        public const uint itp_type_animal = 0x00000013;
        public const uint itp_type_book = 0x00000014;
        public const uint itp_attach_left_item     = 0x00000100;
        public const uint itp_attach_left_hand     = 0x00000200;
        public const uint itp_attach_forearm = 0x00000300;
        public const uint itp_attach_armature = 0x00000f00;
        public const uint itp_unique = 0x00001000;
        public const uint itp_always_loot = 0x00002000;

        public const uint itp_no_parry = 0x00004000;
        public const uint itp_spear = 0x00008000;
        public const uint itp_merchandise = 0x00010000;
        public const uint itp_wooden_attack = 0x00020000;
        public const uint itp_wooden_parry = 0x00040000;
        public const uint itp_food = 0x00080000;
        public const uint itp_cant_reload_on_horseback = 0x00100000;
        public const uint itp_two_handed = 0x00200000;
        public const uint itp_primary = 0x00400000;
        public const uint itp_secondary = 0x00800000;
        public const uint itp_covers_legs = 0x01000000;
        public const uint itp_doesnt_cover_hair = 0x01000000;
        public const uint itp_consumable               = 0x02000000;
        public const uint itp_bonus_against_shield     = 0x04000000;
        public const uint itp_penalty_with_shield      = 0x08000000;
        public const uint itp_cant_use_on_horseback    = 0x10000000;
        public const uint itp_civilian                 = 0x20000000;
        public const uint itp_fit_to_head = 0x40000000;
        public const uint itp_covers_head = 0x80000000;
        public const uint ek_item_0 = 0;
        public const uint ek_item_1 = 1;
        public const uint ek_item_2 = 2;
        public const uint ek_item_3 = 3;
        public const uint ek_head   = 4;
        public const uint ek_body   = 5;
        public const uint ek_foot   = 6;
        public const uint ek_gloves = 7;
        public const uint ek_horse  = 8;
        public const uint ek_food = 9;

        public const uint max_inventory_items = 64;
        public const uint num_equipment_kinds = ek_food + 1;
        public const uint num_weapon_proficiencies = 7;

        public const uint cut = 0;
        public const uint pierce = 1;
        public const uint blunt = 2;

        public const uint ibf_armor_mask = 0x00000000000000000000000ff;
        public const uint ibf_damage_mask = 0x00000000000000000000003ff;
        public const uint ibf_10bit_mask = 0x00000000000000000000003ff;
        public const uint ibf_head_armor_bits = 0;
        public const uint ibf_body_armor_bits = 8;
        public const uint ibf_leg_armor_bits = 16;
        public const uint ibf_weight_bits = 24;
        public const uint ibf_difficulty_bits = 32;

        public const uint ibf_hitpoints_mask = 0x0000ffff;
        public const uint ibf_hitpoints_bits = 40;

        public const uint iwf_swing_damage_bits       = 50;
        public const uint iwf_swing_damage_type_bits  = 58;
        public const uint iwf_thrust_damage_bits      = 60;
        public const uint iwf_thrust_damage_type_bits = 68;
        public const uint iwf_weapon_length_bits      = 70;
        public const uint iwf_speed_rating_bits       = 80;
        public const uint iwf_shoot_speed_bits = 90;
        
        public const uint iwf_max_ammo_bits = 100;
        public const uint iwf_abundance_bits = 110;
        public const uint iwf_accuracy_bits = 16;

        public const uint iwf_damage_type_bits = 8;

        public const ulong itcf_thrust_onehanded                                = 0x0000000000000001;
        public const ulong itcf_overswing_onehanded                             = 0x0000000000000002;
        public const ulong itcf_slashright_onehanded                            = 0x0000000000000004;
        public const ulong itcf_slashleft_onehanded                             = 0x0000000000000008;

        public const ulong itcf_thrust_twohanded                                = 0x0000000000000010;
        public const ulong itcf_overswing_twohanded                             = 0x0000000000000020;
        public const ulong itcf_slashright_twohanded                            = 0x0000000000000040;
        public const ulong itcf_slashleft_twohanded                             = 0x0000000000000080;

        public const ulong itcf_thrust_polearm                                  = 0x0000000000000100;
        public const ulong itcf_overswing_polearm                               = 0x0000000000000200;
        public const ulong itcf_slashright_polearm                              = 0x0000000000000400;
        public const ulong itcf_slashleft_polearm                               = 0x0000000000000800;

        public const ulong itcf_shoot_bow                                       = 0x0000000000001000;
        public const ulong itcf_shoot_javelin                                   = 0x0000000000002000;
        public const ulong itcf_shoot_crossbow                                  = 0x0000000000004000;

        public const ulong itcf_throw_stone                                     = 0x0000000000010000;
        public const ulong itcf_throw_knife                                     = 0x0000000000020000;
        public const ulong itcf_throw_axe                                       = 0x0000000000030000;
        public const ulong itcf_throw_javelin                                   = 0x0000000000040000;
        public const ulong itcf_shoot_pistol                                    = 0x0000000000070000;
        public const ulong itcf_shoot_musket                                    = 0x0000000000080000;
        public const ulong itcf_shoot_mask                                      = 0x00000000000ff000;

        public const ulong itcf_horseback_thrust_onehanded                      = 0x0000000000100000;
        public const ulong itcf_horseback_overswing_right_onehanded             = 0x0000000000200000;
        public const ulong itcf_horseback_overswing_left_onehanded              = 0x0000000000400000;
        public const ulong itcf_horseback_slashright_onehanded                  = 0x0000000000800000;
        public const ulong itcf_horseback_slashleft_onehanded                   = 0x0000000001000000;
        public const ulong itcf_thrust_onehanded_lance                          = 0x0000000004000000;
        public const ulong itcf_thrust_onehanded_lance_horseback                = 0x0000000008000000;

        public const ulong itcf_carry_mask                                      = 0x00000007f0000000;
        public const ulong itcf_carry_sword_left_hip                            = 0x0000000010000000;
        public const ulong itcf_carry_axe_left_hip                              = 0x0000000020000000;
        public const ulong itcf_carry_dagger_front_left                         = 0x0000000030000000;
        public const ulong itcf_carry_dagger_front_right                        = 0x0000000040000000;
        public const ulong itcf_carry_quiver_front_right                        = 0x0000000050000000;
        public const ulong itcf_carry_quiver_back_right                         = 0x0000000060000000;
        public const ulong itcf_carry_quiver_right_vertical                     = 0x0000000070000000;
        public const ulong itcf_carry_quiver_back                               = 0x0000000080000000;
        public const ulong itcf_carry_revolver_right                            = 0x0000000090000000;
        public const ulong itcf_carry_pistol_front_left                         = 0x00000000a0000000;
        public const ulong itcf_carry_bowcase_left                              = 0x00000000b0000000;
        public const ulong itcf_carry_mace_left_hip                             = 0x00000000c0000000;

        public const ulong itcf_carry_axe_back                                  = 0x0000000100000000;
        public const ulong itcf_carry_sword_back                                = 0x0000000110000000;
        public const ulong itcf_carry_kite_shield                               = 0x0000000120000000;
        public const ulong itcf_carry_round_shield                              = 0x0000000130000000;
        public const ulong itcf_carry_buckler_left                              = 0x0000000140000000;
        public const ulong itcf_carry_crossbow_back                             = 0x0000000150000000;
        public const ulong itcf_carry_bow_back                                  = 0x0000000160000000;
        public const ulong itcf_carry_spear                                     = 0x0000000170000000;
        public const ulong itcf_carry_board_shield                              = 0x0000000180000000;

        public const ulong itcf_carry_katana                                    = 0x0000000210000000;
        public const ulong itcf_carry_wakizashi                                 = 0x0000000220000000;

        public const ulong itcf_show_holster_when_drawn                         = 0x0000000800000000;

        public const ulong itcf_reload_pistol                                   = 0x0000007000000000;
        public const ulong itcf_reload_musket                                   = 0x0000008000000000;
        public const ulong itcf_reload_mask                                     = 0x000000f000000000;

        public const ulong itcf_parry_forward_onehanded                         = 0x0000010000000000;
        public const ulong itcf_parry_up_onehanded                              = 0x0000020000000000;
        public const ulong itcf_parry_right_onehanded                           = 0x0000040000000000;
        public const ulong itcf_parry_left_onehanded                            = 0x0000080000000000;

        public const ulong itcf_parry_forward_twohanded                         = 0x0000100000000000;
        public const ulong itcf_parry_up_twohanded                              = 0x0000200000000000;
        public const ulong itcf_parry_right_twohanded                           = 0x0000400000000000;
        public const ulong itcf_parry_left_twohanded                            = 0x0000800000000000;

        public const ulong itcf_parry_forward_polearm                           = 0x0001000000000000;
        public const ulong itcf_parry_up_polearm                                = 0x0002000000000000;
        public const ulong itcf_parry_right_polearm                             = 0x0004000000000000;
        public const ulong itcf_parry_left_polearm                              = 0x0008000000000000;

        public const ulong itcf_force_64_bits = 0x8000000000000000;

        public const ulong itc_cleaver = itcf_force_64_bits | (itcf_overswing_onehanded | itcf_slashright_onehanded | itcf_slashleft_onehanded |
                                    itcf_horseback_slashright_onehanded | itcf_horseback_slashleft_onehanded);
        public const ulong itc_dagger = itc_cleaver | itcf_thrust_onehanded;

        public const ulong itc_parry_onehanded = itcf_force_64_bits | itcf_parry_forward_onehanded | itcf_parry_up_onehanded | itcf_parry_right_onehanded | itcf_parry_left_onehanded;
        public const ulong itc_longsword = itc_dagger | itc_parry_onehanded;
        public const ulong itc_scimitar = itc_cleaver | itc_parry_onehanded;

        public const ulong itc_parry_two_handed = itcf_force_64_bits | itcf_parry_forward_twohanded | itcf_parry_up_twohanded | itcf_parry_right_twohanded | itcf_parry_left_twohanded;
        public const ulong itc_cut_two_handed = itcf_force_64_bits | (itcf_slashright_twohanded | itcf_slashleft_twohanded | itcf_overswing_twohanded |
                                           itcf_horseback_slashright_onehanded | itcf_horseback_slashleft_onehanded);
        public const ulong itc_greatsword = itc_cut_two_handed | itcf_thrust_twohanded | itc_parry_two_handed | itcf_thrust_onehanded_lance;
        public const ulong itc_nodachi = itc_cut_two_handed | itc_parry_two_handed;

        public const ulong itc_bastardsword = itc_cut_two_handed | itcf_thrust_twohanded | itc_parry_two_handed | itc_dagger;

        public const ulong itc_parry_polearm = itcf_parry_forward_polearm | itcf_parry_up_polearm | itcf_parry_right_polearm | itcf_parry_left_polearm;
        public const ulong itc_poleaxe = itc_parry_polearm | itcf_overswing_polearm | itcf_thrust_polearm | itcf_slashright_polearm | itcf_slashleft_polearm;
        public const ulong itc_staff = itc_parry_polearm | itcf_thrust_onehanded_lance | itcf_thrust_onehanded_lance_horseback | itcf_overswing_polearm | itcf_thrust_polearm | itcf_slashright_polearm | itcf_slashleft_polearm;
        public const ulong itc_spear = itc_parry_polearm | itcf_thrust_onehanded_lance | itcf_thrust_onehanded_lance_horseback | itcf_thrust_polearm;
        public const ulong itc_cutting_spear = itc_spear | itcf_overswing_polearm;
        public const ulong itc_pike = itcf_thrust_onehanded_lance | itcf_thrust_onehanded_lance_horseback | itcf_thrust_polearm;

        public const ulong itc_greatlance = itcf_thrust_onehanded_lance | itcf_thrust_onehanded_lance_horseback | itcf_thrust_polearm;


        public const ulong ixmesh_inventory = 0x1000000000000000;
        public const ulong ixmesh_flying_ammo = 0x2000000000000000;
        public const ulong ixmesh_carry = 0x3000000000000000;
        #endregion
    }

    public class MBItem
    {
        public string ID { get; set; }
        public string ItemName { get; set; }
        public string ItemPuralName { get; set; }
        public string ItemMesh { get; set; }
        public string ItemInvMesh { get; set; }
        public string ItemFlyingMesh { get; set; }
        public string ItemCarryMesh { get; set; }
        public string Flags { get; set; }
        public string Animations { get; set; }
        public int ItemPrice { get; set; }
        public string ItemData { get; set; }
        public string Modifiers { get; set; }
    }

    public class MBItemReader
    {
        private const byte HORSE_TYPE = 0x01;
        private const byte GOODS_TYPE = 0x0B;
        private const byte BOW_TYPE = 0x08;
        private const byte CROSSBOW_TYPE = 0x09;
        private const byte PISTOL_TYPE = 0x10;
        private const byte MUSKET_TYPE = 0x11;
        private const byte SHIELD_TYPE = 0x07;
        private const byte HEAD_ARMOR_TYPE = 0x0C;
        private const byte BODY_ARMOR_TYPE = 0x0D;
        private const byte FOOT_ARMOR_TYPE = 0x0E;
        private const byte HAND_ARMOR_TYPE = 0x0F;

        private string itemKindsTextFile;

        public MBItemReader(string itemKindsTextFile)
        {
            this.itemKindsTextFile = itemKindsTextFile;
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
                    string line = string.Format("{0} = {1}", data.Split(' ')[0], index);
                    writer.WriteLine(line);
                    builder.AppendLine(line);
                    index++;
                }
            }
            return builder.ToString();
        }

        public string ToMSPythonFile(string outputfile, bool isGenerateIdFiles = false)
        {
            List<string> idFiles = new List<string>();

            StringBuilder builder = new StringBuilder();
            var items = parse(read());
            using (StreamWriter writer = new StreamWriter(outputfile))
            {
                int itemIndex = 0;

                foreach (var item in items)
                {
                    string pythonLine = string.Format("[\"{0}\", \"{1}\",", item.ID, item.ItemName);
                    string itemMeshLine = string.Format("[(\"{0}\", 0)", item.ItemMesh);
                    if (!string.IsNullOrEmpty(item.ItemInvMesh))
                    {
                        itemMeshLine += string.Format(",(\"{0}\", ixmesh_inventory)", item.ItemInvMesh);
                    }
                    if (!string.IsNullOrEmpty(item.ItemFlyingMesh))
                    {
                        itemMeshLine += string.Format(",(\"{0}\", ixmesh_flying_ammo)", item.ItemFlyingMesh);
                    }
                    if (!string.IsNullOrEmpty(item.ItemCarryMesh))
                    {
                        itemMeshLine += string.Format(",(\"{0}\", ixmesh_carry)", item.ItemCarryMesh);
                    }
                    itemMeshLine += "]";
                    pythonLine += itemMeshLine + "," + item.Flags + "," + item.Animations + "," + item.ItemPrice + "," + item.ItemData + "," + item.Modifiers + "],";
                    builder.Append(pythonLine);
                    writer.WriteLine(pythonLine);

                    idFiles.Add("itm_" + item.ID);

                    itemIndex++;
                }
            }

            if (isGenerateIdFiles)
            {
                DirectoryInfo di = new DirectoryInfo(outputfile);
                string idfile = di.Parent + "\\ID_Items.py";
                using (StreamWriter writer = new StreamWriter(idfile))
                {
                    for (int i = 0; i < idFiles.Count; i++)
                    {
                        writer.WriteLine(idFiles[i] + " = " + i.ToString());
                    }
                }
            }

            return builder.ToString();
        }

        private List<string> read()
        {
            List<string> itemDataList = new List<string>();

            int lineNo = 1;
            using (StreamReader reader = new StreamReader(itemKindsTextFile))
            {
                StringBuilder builder = new StringBuilder();

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();

                    if (lineNo >= 3)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            builder.Append(" " + line);
                        }
                        else
                        {
                            string itemText = builder.ToString();
                            itemText = itemText.TrimStart().TrimEnd();
                            itemDataList.Add(itemText);

                            builder = new StringBuilder();
                        }
                    }

                    lineNo++;
                }
            }
            return itemDataList;
        }

        private List<MBItem> parse(List<string> itemTextDataList)
        {
            List<MBItem> items = new List<MBItem>();

            foreach(string itemTextData in itemTextDataList)
            {
                items.Add(parseSingleItem(itemTextData));
            }

            return items;
        }

        private MBItem parseSingleItem(string itemTextData)
        {
            string[] tokens = itemTextData.Split(' ').Where(o => !string.IsNullOrEmpty(o)).ToArray();

            MBItem item = new MBItem();
            item.ID = tokens[0].Substring(4);
            item.ItemName = tokens[1].Replace("_", " "); ;
            item.ItemPuralName = tokens[2].Replace("_", " "); ;

            int num = int.Parse(tokens[3]);
            item.ItemMesh = tokens[4];

            if (num == 2)
            {
                item.ItemMesh = tokens[4];

                if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[6];
                }
            }
            else if (num == 3)
            {
                item.ItemMesh = tokens[4];

                if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[6];
                }

                if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[8];
                }
                else if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[8];
                }
                else if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[8];
                }
            }
            else if (num == 4)
            {
                item.ItemMesh = tokens[4];

                if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[6];
                }
                else if (ulong.Parse(tokens[7]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[6];
                }

                if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[8];
                }
                else if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[8];
                }
                else if (ulong.Parse(tokens[9]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[8];
                }

                if (ulong.Parse(tokens[11]) == MBItemConst.ixmesh_inventory)
                {
                    item.ItemInvMesh = tokens[10];
                }
                else if (ulong.Parse(tokens[11]) == MBItemConst.ixmesh_flying_ammo)
                {
                    item.ItemFlyingMesh = tokens[10];
                }
                else if (ulong.Parse(tokens[11]) == MBItemConst.ixmesh_carry)
                {
                    item.ItemCarryMesh = tokens[10];
                }
            }

            byte bType;

            int nextIndex = 4 + num * 2;
            ulong flags = ulong.Parse(tokens[nextIndex]);
            item.Flags = decompileFlags(flags, out bType);

            ulong animations = ulong.Parse(tokens[nextIndex + 1]);
            item.Animations = decompileCapabilities(animations);

            item.ItemPrice = int.Parse(tokens[nextIndex + 2]);

            ulong imboits = ulong.Parse(tokens[nextIndex + 3]);

            var sbItemStats = new StringBuilder("weight(" + tokens[nextIndex + 4] + ")", 1024);
            string[] strStats = { "abundance", "head_armor", "body_armor", "leg_armor", "difficulty", "hit_points",
                "spd_rtng", "shoot_speed", "weapon_length", "max_ammo", "thrust_damage", "swing_damage" };

            int idx = nextIndex + 5;

            for (int v = 0; v < 12; v++)
            {
                int iValue = int.Parse(tokens[idx]);

                string strState = strStats[v];

                if (bType == HORSE_TYPE && strState == "shoot_speed")
                    strState = "horse_speed";
                else if (bType == HORSE_TYPE && strState == "spd_rtng")
                    strState = "horse_maneuver";
                else if (bType == GOODS_TYPE && strState == "head_armor")
                    strState = "food_quality";
                else if ((bType == BOW_TYPE || bType == CROSSBOW_TYPE || bType == MUSKET_TYPE || bType == PISTOL_TYPE) && strState == "leg_armor")
                    strState = "accuracy";
                else if (bType == SHIELD_TYPE && strState == "weapon_length")
                    strState = "shield_width";
                else if (bType == SHIELD_TYPE && strState == "shoot_speed")
                    strState = "shield_height";

                if (iValue != 0)
                {
                    if (v >= 10)
                    {
                        int iDamage = iValue & 0xFF;
                        int iDamageType = (iValue - iDamage) >> 8;
                        string strDamageType = "";
                        switch (iDamageType)
                        {
                            case 0:
                                strDamageType = "cut";
                                break;
                            case 1:
                                strDamageType = "pierce";
                                break;
                            case 2:
                                strDamageType = "blunt";
                                break;
                        }
                        if (bType == HORSE_TYPE && strState == "thrust_damage" && iDamageType == 0)
                            sbItemStats.Append($"|horse_charge({iDamage})");
                        else
                            sbItemStats.Append($"|{strState}({iDamage}, {strDamageType})");
                    }
                    else
                        sbItemStats.Append($"|{strState}({iValue})");
                }

                idx++;
            }
            item.ItemData = sbItemStats.ToString();
            item.Modifiers = decompileModifiers(imboits);
            return item;
        }

        private string decompileFlags(ulong dwFlag, out byte bType)
        {
            var sbFlag = new StringBuilder(256);
            ulong dwType = dwFlag & 0xFF;

            bType = (byte)dwType;

            string[] strItemTypes = { "itp_type_zero", "itp_type_horse", "itp_type_one_handed_wpn", "itp_type_two_handed_wpn", "itp_type_polearm",
            "itp_type_arrows", "itp_type_bolts", "itp_type_shield", "itp_type_bow", "itp_type_crossbow", "itp_type_thrown", "itp_type_goods",
            "itp_type_head_armor", "itp_type_body_armor", "itp_type_foot_armor", "itp_type_hand_armor", "itp_type_pistol", "itp_type_musket",
            "itp_type_bullets", "itp_type_animal", "itp_type_book" };

            string[] strItemTypeFlags = { "itp_unique", "itp_always_loot", "itp_no_parry", "itp_spear", "itp_merchandise", "itp_wooden_attack",
            "itp_wooden_parry", "itp_food", "itp_cant_reload_on_horseback", "itp_two_handed", "itp_primary", "itp_secondary", "itp_covers_legs",
            "itp_doesnt_cover_hair", "itp_consumable", "itp_bonus_against_shield", "itp_penalty_with_shield", "itp_cant_use_on_horseback",
            "itp_civilian", "itp_fit_to_head", "itp_covers_head" };
            ulong[] dwItemFlags = { 0x00001000, 0x00002000, 0x00004000, 0x00008000, 0x00010000, 0x00020000, 0x00040000, 0x00080000, 0x00100000,
            0x00200000, 0x00400000, 0x00800000, 0x01000000, 0x01000000, 0x02000000, 0x04000000, 0x08000000, 0x10000000, 0x20000000, 0x40000000, 0x80000000 };

            //uint dwItemType = uItemFlags & 0xFF;
            if (dwType > 0 && dwType < 0x15)
            {
                sbFlag.Append(strItemTypes[dwType]);
                sbFlag.Append('|');
            }

            var wAttach = (uint)(dwFlag & 0xF00);

            switch (wAttach)
            {
                case 0x0100:
                    sbFlag.Append("itp_force_attach_left_hand|");
                    break;
                case 0x0200:
                    sbFlag.Append("itp_force_attach_right_hand|");
                    break;
                case 0x0300:
                    sbFlag.Append("itp_force_attach_left_forearm|");
                    break;
                case 0x0F00:
                    sbFlag.Append("itp_attach_armature|");
                    break;
            }

            for (int i = 0; i < dwItemFlags.Length; i++)
            {
                if ((dwFlag & dwItemFlags[i]) == 0) continue;
                sbFlag.Append(strItemTypeFlags[i]);
                sbFlag.Append('|');
            }

            if (sbFlag.Length == 0)
                sbFlag.Append('0');
            else
                sbFlag.Length--;

            return sbFlag.ToString();
        }

        public string decompileCapabilities(ulong dwCapacity)
        {
            var sbCapacity = new StringBuilder(2048);

            /*string[] strItemCapsFlags = { "itcf_thrust_onehanded", "itcf_overswing_onehanded", "itcf_slashright_onehanded", "itcf_slashleft_onehanded", 
            "itcf_thrust_twohanded", "itcf_overswing_twohanded", "itcf_slashright_twohanded", "itcf_slashleft_twohanded", "itcf_thrust_polearm", 
            "itcf_overswing_polearm", "itcf_slashright_polearm", "itcf_slashleft_polearm", "itcf_shoot_bow", "itcf_shoot_javelin", "itcf_shoot_crossbow", 
            "itcf_throw_stone", "itcf_throw_knife", "itcf_throw_axe", "itcf_throw_javelin", "itcf_shoot_pistol", "itcf_shoot_musket", "itcf_horseback_thrust_onehanded", 
            "itcf_horseback_overswing_right_onehanded", "itcf_horseback_overswing_left_onehanded", "itcf_horseback_slashright_onehanded", "itcf_horseback_slashleft_onehanded", 
            "itcf_thrust_onehanded_lance", "itcf_thrust_onehanded_lance_horseback", "itcf_carry_sword_left_hip", "itcf_carry_axe_left_hip", "itcf_carry_dagger_front_left",
            "itcf_carry_dagger_front_right", "itcf_carry_quiver_front_right", "itcf_carry_quiver_back_right", "itcf_carry_quiver_right_vertical", "itcf_carry_quiver_back", 
            "itcf_carry_revolver_right", "itcf_carry_pistol_front_left", "itcf_carry_bowcase_left", "itcf_carry_mace_left_hip", "itcf_carry_axe_back", 
            "itcf_carry_sword_back", "itcf_carry_kite_shield", "itcf_carry_round_shield", "itcf_carry_buckler_left", "itcf_carry_crossbow_back", 
            "itcf_carry_bow_back", "itcf_carry_spear", "itcf_carry_board_shield", "itcf_carry_katana", "itcf_carry_wakizashi", "itcf_show_holster_when_drawn", 
            "itcf_reload_pistol", "itcf_reload_musket", "itcf_parry_forward_onehanded", "itcf_parry_up_onehanded", "itcf_parry_right_onehanded", 
            "itcf_parry_left_onehanded", "itcf_parry_forward_twohanded", "itcf_parry_up_twohanded", "itcf_parry_right_twohanded", "itcf_parry_left_twohanded", 
            "itcf_parry_forward_polearm", "itcf_parry_up_polearm", "itcf_parry_right_polearm", "itcf_parry_left_polearm", "itcf_horseback_slash_polearm", 
            "itcf_overswing_spear", "itcf_overswing_musket", "itcf_thrust_musket", "itcf_force_64_bits" };
            DWORD64[] dwItemCapsFlags = { 0x0000000000000001, 0x0000000000000002, 0x0000000000000004, 0x0000000000000008, 0x0000000000000010, 
            0x0000000000000020, 0x0000000000000040, 0x0000000000000080, 0x0000000000000100, 0x0000000000000200, 0x0000000000000400, 0x0000000000000800, 
            0x0000000000001000, 0x0000000000002000, 0x0000000000004000, 0x0000000000010000, 0x0000000000020000, 0x0000000000030000, 0x0000000000040000, 
            0x0000000000070000, 0x0000000000080000, 0x0000000000100000, 0x0000000000200000, 0x0000000000400000, 0x0000000000800000, 0x0000000001000000, 
            0x0000000004000000, 0x0000000008000000, 0x0000000010000000, 0x0000000020000000, 0x0000000030000000, 0x0000000040000000, 0x0000000050000000, 
            0x0000000060000000, 0x0000000070000000, 0x0000000080000000, 0x0000000090000000, 0x00000000a0000000, 0x00000000b0000000, 0x00000000c0000000, 
            0x0000000100000000, 0x0000000110000000, 0x0000000120000000, 0x0000000130000000, 0x0000000140000000, 0x0000000150000000, 0x0000000160000000, 
            0x0000000170000000, 0x0000000180000000, 0x0000000210000000, 0x0000000220000000, 0x0000000800000000, 0x0000007000000000, 0x0000008000000000, 
            0x0000010000000000, 0x0000020000000000, 0x0000040000000000, 0x0000080000000000, 0x0000100000000000, 0x0000200000000000, 0x0000400000000000, 
            0x0000800000000000, 0x0001000000000000, 0x0002000000000000, 0x0004000000000000, 0x0008000000000000, 0x0010000000000000, 0x0020000000000000, 
            0x0040000000000000, 0x0080000000000000, 0x8000000000000000 };
            for (int i = dwItemCapsFlags.Length - 1; i >= 0; i--)
            {
                if (dwCapacity >= dwItemCapsFlags[i])
                {
                    strCapacity = strCapacity + strItemCapsFlags[i] + "|";
                    dwCapacity -= dwItemCapsFlags[i];
                }
            }*/

            string[] strCapsShoot = { "itcf_shoot_bow", "itcf_shoot_javelin", "itcf_shoot_crossbow", "itcf_throw_stone", "itcf_throw_knife", "itcf_throw_axe",
            "itcf_throw_javelin", "itcf_shoot_pistol", "itcf_shoot_musket" };
            ulong[] dwCapsShoot = { 0x0000000000001000, 0x0000000000002000, 0x0000000000004000, 0x0000000000010000, 0x0000000000020000, 0x0000000000030000,
            0x0000000000040000, 0x0000000000070000, 0x0000000000080000 };
            const ulong dwCapsShootMask = 0x00000000000ff000;
            ulong dwShoot = dwCapacity & dwCapsShootMask;
            for (int i = 0; i < dwCapsShoot.Length; i++)
            {
                if (dwShoot != dwCapsShoot[i]) continue;
                sbCapacity.Append(strCapsShoot[i]);
                sbCapacity.Append('|');
                break;
            }

            string[] strCapsCarry = { "itcf_carry_sword_left_hip", "itcf_carry_axe_left_hip", "itcf_carry_dagger_front_left", "itcf_carry_dagger_front_right",
            "itcf_carry_quiver_front_right", "itcf_carry_quiver_back_right", "itcf_carry_quiver_right_vertical", "itcf_carry_quiver_back",
            "itcf_carry_revolver_right", "itcf_carry_pistol_front_left", "itcf_carry_bowcase_left", "itcf_carry_mace_left_hip", "itcf_carry_axe_back",
            "itcf_carry_sword_back", "itcf_carry_kite_shield", "itcf_carry_round_shield", "itcf_carry_buckler_left", "itcf_carry_crossbow_back",
            "itcf_carry_bow_back", "itcf_carry_spear", "itcf_carry_board_shield", "itcf_carry_katana", "itcf_carry_wakizashi" };
            ulong[] dwCapsCarry = { 0x0000000010000000, 0x0000000020000000, 0x0000000030000000, 0x0000000040000000, 0x0000000050000000, 0x0000000060000000,
            0x0000000070000000, 0x0000000080000000, 0x0000000090000000, 0x00000000a0000000, 0x00000000b0000000, 0x00000000c0000000, 0x0000000100000000,
            0x0000000110000000, 0x0000000120000000, 0x0000000130000000, 0x0000000140000000, 0x0000000150000000, 0x0000000160000000, 0x0000000170000000,
            0x0000000180000000, 0x0000000210000000, 0x0000000220000000 };
            const ulong dwCapsCarryMask = 0x00000007f0000000;
            ulong dwCarry = dwCapacity & dwCapsCarryMask;
            for (int i = 0; i < dwCapsCarry.Length; i++)
            {
                if (dwCarry != dwCapsCarry[i]) continue;
                sbCapacity.Append(strCapsCarry[i]);
                sbCapacity.Append('|');
                break;
            }

            const ulong dwCapsReloadMask = 0x000000f000000000;
            ulong dwReload = dwCapacity & dwCapsReloadMask;
            switch (dwReload)
            {
                case 0x0000007000000000:
                    sbCapacity.Append("itcf_reload_pistol|");
                    break;
                case 0x0000008000000000:
                    sbCapacity.Append("itcf_reload_musket|");
                    break;
            }

            string[] strItemCapsConstant = { "itc_longsword", "itc_scimitar", "itc_parry_onehanded", "itc_greatsword", "itc_bastardsword", "itc_nodachi",
            "itc_morningstar", "itc_parry_two_handed", "itc_cut_two_handed", "itc_poleaxe", "itc_staff", "itc_cutting_spear", "itc_spear", "itc_pike",
            "itc_guandao", "itc_parry_polearm", "itc_greatlance", "itc_dagger", "itc_cleaver", "itc_musket_melee" };
            ulong[] dwItemCapsConstant = { 9223388529554358287, 9223388529554358286, 9223388529529192448, 9223635919737716976, 9223635919670608127,
            9223635919670608096, 9223635919670608110, 9223635919645442048, 9223372036879941856, 4222124650663680, 4222124851990272, 4222124851987200,
            4222124851986688, 201326848, 8725724303200000, 4222124650659840, 201326848, 9223372036879941647, 9223372036879941646, 58265320179105984 };
            for (int i = 0; i < dwItemCapsConstant.Length; i++)
            {
                ulong temp = dwCapacity & dwItemCapsConstant[i];
                if (temp - dwItemCapsConstant[i] != 0) continue;
                sbCapacity.Append(strItemCapsConstant[i]);
                sbCapacity.Append('|');
                dwCapacity ^= dwItemCapsConstant[i];
            }

            string[] strItemCapsFlags = { "itcf_thrust_onehanded", "itcf_overswing_onehanded", "itcf_slashright_onehanded", "itcf_slashleft_onehanded",
            "itcf_thrust_twohanded", "itcf_overswing_twohanded", "itcf_slashright_twohanded", "itcf_slashleft_twohanded", "itcf_thrust_polearm",
            "itcf_overswing_polearm", "itcf_slashright_polearm", "itcf_slashleft_polearm", "itcf_horseback_thrust_onehanded",
            "itcf_horseback_overswing_right_onehanded", "itcf_horseback_overswing_left_onehanded", "itcf_horseback_slashright_onehanded",
            "itcf_horseback_slashleft_onehanded", "itcf_thrust_onehanded_lance", "itcf_thrust_onehanded_lance_horseback", "itcf_show_holster_when_drawn",
            "itcf_parry_forward_onehanded", "itcf_parry_up_onehanded", "itcf_parry_right_onehanded", "itcf_parry_left_onehanded",
            "itcf_parry_forward_twohanded", "itcf_parry_up_twohanded", "itcf_parry_right_twohanded", "itcf_parry_left_twohanded",
            "itcf_parry_forward_polearm", "itcf_parry_up_polearm", "itcf_parry_right_polearm", "itcf_parry_left_polearm", "itcf_horseback_slash_polearm",
            "itcf_overswing_spear", "itcf_overswing_musket", "itcf_thrust_musket", "itcf_force_64_bits" };
            ulong[] dwItemCapsFlags = { 0x0000000000000001, 0x0000000000000002, 0x0000000000000004, 0x0000000000000008, 0x0000000000000010,
            0x0000000000000020, 0x0000000000000040, 0x0000000000000080, 0x0000000000000100, 0x0000000000000200, 0x0000000000000400, 0x0000000000000800,
            0x0000000000100000, 0x0000000000200000, 0x0000000000400000, 0x0000000000800000, 0x0000000001000000, 0x0000000004000000, 0x0000000008000000,
            0x0000000800000000, 0x0000010000000000, 0x0000020000000000, 0x0000040000000000, 0x0000080000000000, 0x0000100000000000, 0x0000200000000000,
            0x0000400000000000, 0x0000800000000000, 0x0001000000000000, 0x0002000000000000, 0x0004000000000000, 0x0008000000000000, 0x0010000000000000,
            0x0020000000000000, 0x0040000000000000, 0x0080000000000000, 0x8000000000000000 };
            for (int i = 0; i < dwItemCapsFlags.Length; i++)
            {
                if ((dwCapacity & dwItemCapsFlags[i]) == 0) continue;
                sbCapacity.Append(strItemCapsFlags[i]);
                sbCapacity.Append('|');
            }

            if (sbCapacity.Length == 0)
                sbCapacity.Append('0');
            else
                sbCapacity.Length--;

            return sbCapacity.ToString();
        }

        private string decompileModifiers(ulong dwMeshBits)
        {
            var sbFlag = new StringBuilder(2048);
            ulong dwMeshExtraBits = (dwMeshBits & 0xFF00000000000000) >> 56;
            switch (dwMeshExtraBits)
            {
                case 0x10:
                    sbFlag.Append("ixmesh_inventory|");
                    break;
                case 0x20:
                    sbFlag.Append("ixmesh_flying_ammo|");
                    break;
                case 0x30:
                    sbFlag.Append("ixmesh_carry|");
                    break;
            }
            ulong dwMeshImodBits = dwMeshBits & 0x00FFFFFFFFFFFFFF;
            string[] strImodBits = { "imodbit_plain", "imodbit_cracked", "imodbit_rusty", "imodbit_bent", "imodbit_chipped", "imodbit_battered", "imodbit_poor", "imodbit_crude", "imodbit_old",
            "imodbit_cheap", "imodbit_fine", "imodbit_well_made", "imodbit_sharp", "imodbit_balanced", "imodbit_tempered", "imodbit_deadly", "imodbit_exquisite", "imodbit_masterwork",
            "imodbit_heavy", "imodbit_strong", "imodbit_powerful", "imodbit_tattered", "imodbit_ragged", "imodbit_rough", "imodbit_sturdy", "imodbit_thick", "imodbit_hardened",
            "imodbit_reinforced", "imodbit_superb", "imodbit_lordly", "imodbit_lame", "imodbit_swaybacked", "imodbit_stubborn", "imodbit_timid", "imodbit_meek", "imodbit_spirited",
            "imodbit_champion", "imodbit_fresh", "imodbit_day_old", "imodbit_two_day_old", "imodbit_smelling", "imodbit_rotten", "imodbit_large_bag" };
            ulong[] dwImodBits = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576,
            2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, 2147483648, 4294967296, 8589934592,
            17179869184, 34359738368, 68719476736, 137438953472, 274877906944, 549755813888, 1099511627776, 2199023255552, 4398046511104 };

            for (int i = 0; i < dwImodBits.Length; i++)
            {
                if ((dwMeshImodBits & dwImodBits[i]) == 0) continue;
                sbFlag.Append(strImodBits[i]);
                sbFlag.Append('|');
            }

            if (sbFlag.Length == 0)
                sbFlag.Append('0');
            else
                sbFlag.Length--;

            return sbFlag.ToString();
        }
    }
}
