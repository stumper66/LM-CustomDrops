using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization.TypeResolvers;

namespace LM_CustomDrops
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> m_NameToId;
        private const decimal m_DefaultChance = 0.20M;
        private string m_SaveFile;
        private string m_Header;

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleTheUnhandled);

            m_NameToId = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            string MaterialsFile = "materials.txt";
            string MobsFile = "moblist.txt";

            if (System.IO.File.Exists(MobsFile))
            {
                string[] Mobs = null;
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(MobsFile))
                        Mobs = sr.ReadToEnd().Replace("\r", "").Split('\n');
                }
                catch { }

                if (Mobs != null)
                    cboMobOrGroup.Items.AddRange(Mobs);
            }

            if (System.IO.File.Exists(MaterialsFile))
            {
                string[] Materials = null;
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(MaterialsFile))
                        Materials = sr.ReadToEnd().Replace("\r", "").Split('\n');
                }
                catch { }

                if (Materials != null)
                    cboMaterials.Items.AddRange(Materials);
            }

            cboMobOrGroup.Text = cboMobOrGroup.Items[0].ToString();
            cboMaterials.Text = cboMaterials.Items[0].ToString();
        }

        private static void HandleTheUnhandled(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            string StrCD = Environment.CurrentDirectory;
            if (!StrCD.EndsWith("\\")) StrCD += "\\";

            StringBuilder sb = new StringBuilder("Program: LM-CustomDrops\r\n");
            sb.AppendFormat("Version: {0}\r\n", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            Exception ex2 = null;
            if (ex.InnerException != null) ex2 = (Exception)ex.InnerException;

            sb.AppendFormat("exception message: {0}\r\n" +
                "exception object: {1}\r\n" +
                "exception type: {2}\r\n",
                ex.Message, ex, ex.GetType());

            if (ex2 != null)
            {
                sb.AppendFormat("inner exception message: {0}\r\n" +
                "inner exception object: {1}\r\n" +
                "inner exception type: {2}\r\n",
                ex2.Message, ex2, ex2.GetType());
            }

            string file = StrCD + "debug.txt";

            try
            {
                System.IO.StreamWriter SW = new System.IO.StreamWriter(file);
                SW.Write(sb.ToString());
                SW.Close();
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewMobOrGroup(cboMobOrGroup.Text, chkOverride.Checked);
        }

        private int AddNewMobOrGroup(string Name, bool Override)
        {

            if (m_NameToId.ContainsKey(Name))
            {
                MessageBox.Show("That mob or group is already in the list!");
                return -1;
            }

            lstMobOrGroup.Items.Add(chkOverride.Checked ? Name + " - override" : Name);

            DataRow row = dtMobOrGroup.NewRow();
            row["Name"] = Name;
            row["Override"] = chkOverride.Checked;
            dtMobOrGroup.Rows.Add(row);

            int Id = (int)row["Id"];
            m_NameToId.Add(Name, Id);
            lstMobOrGroup.SelectedIndex = lstMobOrGroup.Items.Count - 1;

            return Id;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            string MobOrGroupName = lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex].ToString();
            string MobOrGroupName_Only = MobOrGroupName;
            int Dash = MobOrGroupName.IndexOf(" -");
            if (Dash > 0)
                MobOrGroupName = MobOrGroupName.Substring(0, Dash);

            int Id = m_NameToId[MobOrGroupName];

            DataRow row = AddNewMaterial(Id, MobOrGroupName_Only, cboMaterials.Text);

            if (numMinValue.Value > -1) row["MinLevel"] = (int)numMinValue.Value;
            if (numMaxValue.Value > -1) row["MaxLevel"] = (int)numMaxValue.Value;
            row["Amount"] = ((int)numAmount.Value).ToString();
            if (numChance.Value != m_DefaultChance) row["Chance"] = (double)numChance.Value;
            row["NoMultiplier"] = chkNoMultiplier.Checked;
            row["NoSpawner"] = chkNoSpawner.Checked;
            row["Equipped"] = chkEquipped.Checked;
            if (!string.IsNullOrEmpty(txtGroupId.Text)) row["GroupId"] = txtGroupId.Text;
            if (!string.IsNullOrEmpty(txtEnchantments.Text)) row["Enchantments"] = txtEnchantments.Text;
        }

        private DataRow AddNewMaterial(int NameId, string MobOrGroupName, string MaterialName)
        {
            DataRow row = dtItem.NewRow();
            row["NameId"] = NameId;
            row["Material"] = MaterialName;
            row["MobOrGroup"] = MobOrGroupName;

            dtItem.Rows.Add(row);

            return row;
        }

        private void lstMobOrGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMobOrGroup.SelectedIndex < 0)
            {
                dvMain.RowFilter = string.Empty;
                btnAddMaterial.Enabled = false;
            }
            else
            {
                string MobOrGroupName = lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex].ToString();
                int Dash = MobOrGroupName.IndexOf(" -");
                if (Dash > 0)
                    MobOrGroupName = MobOrGroupName.Substring(0, Dash);

                int Id = m_NameToId[MobOrGroupName];

                dvMain.RowFilter = dvMain.RowFilter = "NameId = " + Id.ToString();
                btnAddMaterial.Enabled = true;
                btnShowAllItems.Enabled = true;
            }
        }

        private void btnShowAllItems_Click(object sender, EventArgs e)
        {
            lstMobOrGroup.SelectedIndex = -1;
            btnShowAllItems.Enabled = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMobOrGroup.Items.Count > 0)
            {
                DialogResult DR = MessageBox.Show("Loading a file will clear all current values.\r\nContinue?", "Overwrite Existing Values", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DR != DialogResult.OK) return;
            }

            if (OFD.ShowDialog() != DialogResult.OK) return;

            m_SaveFile = OFD.FileName;
            lstMobOrGroup.Items.Clear();
            m_NameToId.Clear();
            dtItem.Clear();
            dtMobOrGroup.Clear();

            IDeserializer deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            Dictionary<object, object> dict = null;

            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(OFD.FileName))
                    dict = deserializer.Deserialize<Dictionary<object, object>>(sr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parsing file: " + ex.Message);
                return;
            }

            if (dict == null) return;

            foreach (object key in dict.Keys)
            {
                string MobOrGroup = key.ToString();
                if (string.Equals(MobOrGroup, "file-version")) continue;

                int NameId = AddNewMobOrGroup(MobOrGroup, false);
                if (NameId < 0) continue;

                object test = dict[key];
                string test2 = test.GetType().ToString();

                ParseMaterial((List<object>)dict[key], NameId, MobOrGroup);
            }

        }

        private void ParseMaterial(List<object> MaterialList, int NameId, string MobOrGroup)
        {
            foreach (object MaterialObj in MaterialList)
            {
                DataRow row = null;

                if (MaterialObj is string)
                {
                    string Material = MaterialObj.ToString();
                    if (string.Equals(Material, "override", StringComparison.CurrentCultureIgnoreCase))
                    {
                        ToggleMobOverride(MobOrGroup, true);
                        continue;
                    }
                    row = AddNewMaterial(NameId, MobOrGroup, Material);
                    continue;
                }

                int MinLevel = -1;
                int MaxLevel = -1;
                int Amount = 1;
                double Chance = 0.2;
                bool NoMultiplier = false;
                bool NoSpawner = false;
                bool Equipped = false;
                object Lore = DBNull.Value;
                string Enchantments = null;

                if (MaterialObj is Dictionary<object, object>)
                {
                    Dictionary<object, object> MaterialList2 = (Dictionary<object, object>)MaterialObj;

                    foreach (object MaterialObj2 in MaterialList2.Keys)
                    {
                        string Material = MaterialObj2.ToString();

                        Dictionary<object, object> MaterialAttribs = (Dictionary<object, object>)MaterialList2[MaterialObj2];

                        foreach (object Attrib in MaterialAttribs.Keys)
                        {
                            double TempD = 0.0;
                            bool TempBool = false;
                            string AttribName = Attrib.ToString().ToLower();
                            object AttribValue = MaterialAttribs[Attrib];
                            switch (AttribName)
                            {
                                case "minlevel":
                                    if (double.TryParse(AttribValue.ToString(), out TempD))
                                        MinLevel = (int)TempD;
                                    break;
                                case "maxlevel":
                                    if (double.TryParse(AttribValue.ToString(), out TempD))
                                        MaxLevel = (int)TempD;
                                    break;
                                case "amount":
                                    if (double.TryParse(AttribValue.ToString(), out TempD))
                                        Amount = (int)TempD;
                                    break;
                                case "chance":
                                    if (double.TryParse(AttribValue.ToString(), out TempD))
                                        Chance = TempD;
                                    break;
                                case "nomultiplier":
                                    if (bool.TryParse(AttribValue.ToString(), out TempBool))
                                        NoMultiplier = TempBool;
                                    break;
                                case "nospawner":
                                    if (bool.TryParse(AttribValue.ToString(), out TempBool))
                                        NoSpawner = TempBool;
                                    break;
                                case "equipped":
                                    if (bool.TryParse(AttribValue.ToString(), out TempBool))
                                        Equipped = TempBool;
                                    break;
                                case "lore":
                                    if (AttribValue is List<Object>)
                                    {
                                        List<Object> LoreStrings = (List<Object>)AttribValue;
                                        StringBuilder sb = new StringBuilder();
                                        foreach (object obj in LoreStrings)
                                        {
                                            if (sb.Length > 0) sb.Append(";");
                                            sb.Append(obj);
                                        }
                                        if (sb.Length > 0) Lore = sb.ToString();
                                    }
                                    break;
                                case "enchantments":
                                    Enchantments = ParseEnchantments(AttribValue);
                                    break;
                            }
                        }

                        row = AddNewMaterial(NameId, MobOrGroup, Material);

                        if (MinLevel > -1) row["MinLevel"] = MinLevel;
                        if (MaxLevel > -1) row["MaxLevel"] = MaxLevel;
                        if (Amount != 1) row["Amount"] = Amount;
                        if ((decimal)Chance != m_DefaultChance) row["Chance"] = Chance;
                        row["NoMultiplier"] = NoMultiplier;
                        row["NoSpawner"] = NoSpawner;
                        row["Equipped"] = Equipped;
                        row["Lore"] = Lore;
                        if (Enchantments != null) row["Enchantments"] = Enchantments;
                    }
                } 
            }
        }

        private string ParseEnchantments(object Input)
        {
            if (!(Input is Dictionary<Object, Object>)) return null;

            Dictionary<Object, Object> Enchantments = (Dictionary<Object, Object>)Input;
            StringBuilder sb = new StringBuilder();

            foreach (object EnchantmentName in Enchantments.Keys)
            {
                if (sb.Length > 0) sb.Append(",");
                sb.Append(EnchantmentName);
                object EnchantValue = Enchantments[EnchantmentName].ToString();
                if (EnchantValue != null)
                {
                    string temp = EnchantValue.ToString();
                    if (!string.IsNullOrEmpty(temp)) sb.Append(":" + temp);
                }
            }

            return sb.Length > 0 ? sb.ToString() : null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() != DialogResult.OK) return;

            m_SaveFile = SFD.FileName;
            SaveFile();
        }

        private void SaveFile()
        {
            YmlBuilder Yml = new YmlBuilder();
            DataView DV = new DataView(dtItem);

            for (int i = 0; i < dtMobOrGroup.Rows.Count; i++)
            {
                DataRow MobRow = dtMobOrGroup.Rows[i];
                int Id = (int)MobRow["Id"];
                string MobName = MobRow["Name"].ToString();
                bool UseOverride = Helpers.GetBool(MobRow["Override"]);

                DV.RowFilter = "NameId = " + Id.ToString();
                if (DV.Count == 0) continue;

                Yml.WriteNewMobOrGroup(MobName);

                for (int t = 0; t < DV.Count; t++)
                {
                    Yml.CurrentWhiteSpace = 2;

                    string Material = DV[t]["Material"].ToString();
                    int MinLevel = Helpers.GetInt(DV[t]["MinLevel"], -1);
                    int MaxLevel = Helpers.GetInt(DV[t]["MaxLevel"], -1);
                    double? Chance = Helpers.GetDoubleN(DV[t]["Chance"]);
                    int Amount = Helpers.GetInt(DV[t]["Amount"], 1);
                    bool NoMultiplier = Helpers.GetBool(DV[t]["NoMultiplier"]);
                    bool NoSpawner = Helpers.GetBool(DV[t]["NoSpawner"]);
                    int GroupId = Helpers.GetInt(DV[t]["GroupId"], -1);
                    string Lore = Helpers.GetString(DV[t]["Lore"]);
                    string CustomName = Helpers.GetString(DV[t]["CustomName"]);
                    string Damage = Helpers.GetString(DV[t]["Damage"]);
                    bool Equipped = Helpers.GetBool(DV[t]["Equipped"]);
                    string Enchantments = Helpers.GetString(DV[t]["Enchantments"]);

                    bool ContainsSubvalues = (
                        MinLevel >= 0 ||
                        MaxLevel >= 0 ||
                        Chance.HasValue && (decimal)Chance.Value != m_DefaultChance ||
                        Amount != 1 ||
                        NoMultiplier ||
                        NoSpawner ||
                        GroupId >= 0 ||
                        !string.IsNullOrEmpty(Lore) ||
                        !string.IsNullOrEmpty(CustomName) ||
                        !string.IsNullOrEmpty(Damage) ||
                        !string.IsNullOrWhiteSpace(Enchantments) ||
                        Equipped
                        );

                    Yml.WriteArrayValue(Material.ToLower(), ContainsSubvalues);
                    if (!ContainsSubvalues) continue;

                    // only write non-default values
                    if (MinLevel >= 0) Yml.WriteValue("minlevel", MinLevel);
                    if (MaxLevel >= 0) Yml.WriteValue("maxlevel", MaxLevel);
                    if ((decimal)Chance != m_DefaultChance) Yml.WriteValue("chance", Chance);
                    if (Amount > 1) Yml.WriteValue("amount", Amount);
                    if (NoMultiplier) Yml.WriteValue("nomultiplier", NoMultiplier);
                    if (NoSpawner) Yml.WriteValue("nospawner", NoSpawner);
                    if (GroupId > 0) Yml.WriteValue("groupid", GroupId);
                    if (!string.IsNullOrEmpty(CustomName)) Yml.WriteValue("name", CustomName);
                    if (!string.IsNullOrEmpty(Damage)) Yml.WriteValue("damage", Damage);
                    if (Equipped) Yml.WriteValue("equipped", Equipped);
                    if (!string.IsNullOrEmpty(Lore))
                    {
                        string[] LoreLines = Lore.Split(';');
                        Yml.CurrentWhiteSpace = 6;
                        Yml.WriteValue("lore", null);
                        Yml.CurrentWhiteSpace = 8;
                        foreach (string LoreLine in LoreLines)
                            Yml.WriteArrayValue(LoreLine, false, false);
                    }
                    if (!string.IsNullOrWhiteSpace(Enchantments))
                    {
                        Enchantments = Enchantments.Replace(";", ","); // incase they used semi-colon separators
                        string[] Enchants = Enchantments.Split(',');
                        Yml.CurrentWhiteSpace = 6;
                        Yml.WriteValue("enchantments", null);
                        Yml.CurrentWhiteSpace = 8;
                        foreach (string en in Enchants)
                        {
                            string enTrimmed = en.Trim();
                            int Value = 1;
                            string EnchantNameOnly = enTrimmed;
                            int Colon = enTrimmed.IndexOf(":");
                            if (Colon > 0)
                            {
                                string[] EnchantValue = enTrimmed.Split(':');
                                EnchantNameOnly = EnchantValue[0].Trim();
                                double d = 0.0;
                                if (!Double.TryParse(EnchantValue[1].Trim(), out d))
                                {
                                    MessageBox.Show(String.Format("Invalid enchantment value for mob: {0}, material: {1}, enchantment: {2}.\r\nMust be a number",
                                        MobName, Material, EnchantNameOnly));
                                    return;
                                }
                                Value = Convert.ToInt32(d);
                            }

                            Yml.WriteValue(EnchantNameOnly.ToLower(), Value);
                        }
                    }
                } // next material
            } // next mob

            string HeaderFile = "headers.txt";
            string HeaderContents = null;
            if (System.IO.File.Exists(HeaderFile))
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(HeaderFile))
                        HeaderContents = sr.ReadToEnd();
                }
                catch { }
            }

            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(m_SaveFile, false, Encoding.UTF8))
                {
                    if (HeaderContents != null) sw.Write(HeaderContents);
                    sw.Write(Yml.GetFinalString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_SaveFile == null && SFD.ShowDialog() == DialogResult.OK)
            {
                m_SaveFile = SFD.FileName;
                SaveFile();
            }
            else if (m_SaveFile != null)
                SaveFile();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteMobOrGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MobOrGroupName = lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex].ToString();
            string MobOrGroupName_Only = MobOrGroupName;
            int Dash = MobOrGroupName.IndexOf(" -");
            if (Dash > 0)
                MobOrGroupName = MobOrGroupName.Substring(0, Dash);

            int Id = m_NameToId[MobOrGroupName];

            m_NameToId.Remove(MobOrGroupName_Only);

            DataView DV = new DataView(dtItem);
            DV.RowFilter = "NameId = " + Id.ToString();

            DataRow row = dtMobOrGroup.Rows.Find(Id);
            lstMobOrGroup.Items.RemoveAt(lstMobOrGroup.SelectedIndex);

            for (int i = DV.Count - 1; i >= 0; i--)
                DV[i].Delete();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MobOrGroupName = lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex].ToString();
            string MobOrGroupName_Only = MobOrGroupName;
            int Dash = MobOrGroupName.IndexOf(" -");
            if (Dash > 0)
                MobOrGroupName = MobOrGroupName.Substring(0, Dash);

            int Id = m_NameToId[MobOrGroupName];

            RenameForm Rename = new RenameForm(MobOrGroupName_Only, this);
            if (Rename.ShowDialog() != DialogResult.OK) return;

            MobOrGroupName_Only = Rename.RenamedName;
            m_NameToId.Remove(MobOrGroupName_Only);

            DataView DV = new DataView(dtItem);
            DV.RowFilter = "NameId = " + Id.ToString();

            DataRow row = dtMobOrGroup.Rows.Find(Id);
            bool Override = (bool)row["Override"];
            MobOrGroupName = Override ? MobOrGroupName_Only + " - override" : MobOrGroupName_Only;
            m_NameToId.Add(MobOrGroupName_Only, Id);
            lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex] = MobOrGroupName_Only;

            for (int i = 0; i < DV.Count; i++)
                DV[i]["MobOrGroup"] = MobOrGroupName_Only;
        }

        private void toggleOverrideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MobOrGroupName = lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex].ToString();
            int Dash = MobOrGroupName.IndexOf(" -");
            if (Dash > 0)
                MobOrGroupName = MobOrGroupName.Substring(0, Dash);

            int Id = m_NameToId[MobOrGroupName];
            DataRow row = dtMobOrGroup.Rows.Find(Id);
            bool Override = !(bool)row["Override"];

            ToggleMobOverride(MobOrGroupName, Override);
        }

        private void ToggleMobOverride(string MobOrGroupName, bool DoOverride)
        {
            if (!m_NameToId.ContainsKey(MobOrGroupName)) return;

            int Id = m_NameToId[MobOrGroupName];

            DataRow row = dtMobOrGroup.Rows.Find(Id);
            row["Override"] = DoOverride;

            MobOrGroupName = DoOverride ? MobOrGroupName + " - override" : MobOrGroupName;
            lstMobOrGroup.Items[lstMobOrGroup.SelectedIndex] = MobOrGroupName;
        }

        public bool IsMobOrGroupNameInUse(string Name)
        {
            return m_NameToId.ContainsKey(Name);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }

        private void removeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> RowIds = new List<int>();
            for (int i = 0; i < dgvItem.SelectedCells.Count; i++)
            {
                DataGridViewCell cell = dgvItem.SelectedCells[i];
                if (!RowIds.Contains(cell.RowIndex)) RowIds.Add(cell.RowIndex);
            }

            RowIds.Sort();
            for (int i = RowIds.Count - 1; i >= 0; i--)
                dgvItem.Rows.RemoveAt(RowIds[i]);
        }

        private void dgvItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmenu2.Show(Cursor.Position);
        }
    }
}
