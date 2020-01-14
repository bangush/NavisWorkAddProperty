using NVApi = Autodesk.Navisworks.Api;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Autodesk.Navisworks.Api.ComApi;
using COM = Autodesk.Navisworks.Api.Interop.ComApi;
using Autodesk.Navisworks.Api.Controls;
using System.Drawing;
using SysColor = System.Drawing;

namespace NavisWorkAddProperty
{
    public partial class FrmNavisWorkAddProp : Form
    {
        DataTable dtListOfFiles = new DataTable();
        List<string> lstFiles = new List<string>();
        private ViewControl viewControl;
        private DocumentControl documentControl;
        public FrmNavisWorkAddProp()
        {
            InitializeComponent();

            viewControl = new ViewControl();
            documentControl = new DocumentControl();
            viewControl.Dock = DockStyle.Fill;
            viewControl.DocumentControl = this.documentControl;
            viewControl.Location = new Point(0, 24);
            viewControl.Name = "viewControl";
            viewControl.Size = new Size(745, 496);
            viewControl.TabIndex = 1;
            this.viewControl.Text = "viewControl";
            viewControl.BringToFront();

            viewControl.BackColor = SysColor.Color.Red;
            viewControl.CreateControl();
            splitContainerMain.Panel2.Controls.Add(viewControl);
            /********************/
            documentControl.SetAsMainDocument();
            /********************/

            GrdNavisModelFile.AutoGenerateColumns = false;
            dtListOfFiles.Columns.AddRange(new[]
                 {
                new DataColumn("cFileName", typeof(string)),
                new DataColumn("cFileLocation", typeof(string)),
                new DataColumn("cPropertyName", typeof(string)),
                new DataColumn("cPropertyValue", typeof(string)),
                new DataColumn("cPropertyValueCombo", typeof(string)),
                });
            GrdNavisModelFile.DataSource = dtListOfFiles;
            AddComboBoxValue();
        }
        private void ErrorMessage(Exception ex)
        {
            MessageBox.Show(ex.Message.ToString(), "NavisWorks Add Property Stand-Alone", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowMessage(string _StrMsg, MessageBoxButtons _MessageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon _MessageBoxIcon = MessageBoxIcon.Information)
        {
            MessageBox.Show(_StrMsg, "NavisWorks Add Property Stand-Alone", _MessageBoxButtons, _MessageBoxIcon);
        }
        private DialogResult QuestionMessage(string _StrMsg, MessageBoxButtons _MessageBoxButtons = MessageBoxButtons.YesNo, MessageBoxIcon _MessageBoxIcon = MessageBoxIcon.Question)
        {
            return MessageBox.Show(_StrMsg, "NavisWorks Add Property Stand-Alone", _MessageBoxButtons, _MessageBoxIcon);
        }
        private void AddComboBoxValue()
        {
            try
            {
                DataGridViewComboBoxColumn _DataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.GrdNavisModelFile.Columns["GrdColPropertyValueCombo"];
                _DataGridViewComboBoxColumn.Items.Add("-- Select Property Value --");
                for (int i = 1; i <= 100; i++)
                {
                    _DataGridViewComboBoxColumn.Items.Add(string.Format("Value - {0}", i));
                }

            }
            catch (Exception ex)
            {

                ErrorMessage(ex);
            }
        }
        private void FrmNavisWorkAddProp_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var OpenDlg = new OpenFileDialog())
                {
                    OpenDlg.Title = "Select NavisWorks Files";
                    OpenDlg.Multiselect = true;
                    OpenDlg.RestoreDirectory =true;
                    OpenDlg.Filter = "Navis-Works Cache file (*.nwc)|*.nwc|Navis-Works file (*.nwd)|*.nwd|All files (*.*)|*.*";
                    if (OpenDlg.ShowDialog() == DialogResult.OK)
                    {
                        TxtNavisWorkFileLocation.Text =Path.GetDirectoryName(OpenDlg.FileName);

                        string strFilePath = "";
                        strFilePath = TxtNavisWorkFileLocation.Text.Trim();
                        //lstFiles = new List<string>();
                        //lstFiles = Directory.GetFiles(strFilePath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".nwd") || s.EndsWith(".nwc")).ToList();
                        dtListOfFiles.Rows.Clear();
                        foreach (var item in OpenDlg.FileNames)
                        {

                            DataRow dRow = dtListOfFiles.NewRow();
                            dRow["cFileName"] = Path.GetFileName(item);
                            dRow["cFileLocation"] = item;
                            dtListOfFiles.Rows.Add(dRow);

                        }

                    }
                }

            }
            catch (Exception ex)
            {

                ErrorMessage(ex);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (RbModelFileOnly.Checked)
                {
                    AddPropertyModelFile();
                }
                else if (RbItemOnly.Checked)
                {
                    AddPropertyItem();
                }
                else if (RbModelFileItem.Checked)
                {
                    AddPropertyModelFile_ItemBoth();
                }
                Cursor = Cursors.Default;
                ShowMessage("Property Added!!");
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                ErrorMessage(ex);
            }

        }
//
        private void AddPropertyModelFile()
        {
            try
            {
                foreach (DataRowView DrvFileName in dtListOfFiles.DefaultView)
                {
                    /*-----------------------------------------------------------------------------------*/
                    NVApi.Application.ActiveDocument.TryOpenFile(DrvFileName["cFileLocation"].ToString());

                    string _StrNewFilePath = Path.Combine(Path.GetDirectoryName(DrvFileName["cFileLocation"].ToString()), Path.ChangeExtension(DrvFileName["cFileLocation"].ToString(), ".nwf"));
                    string _StrPropName = "";
                    string _StrPropValue = "";
                    _StrPropName = DrvFileName["cFileLocation"] == DBNull.Value || DrvFileName["cPropertyName"].ToString().Trim() == "" ? "Custom Property" : DrvFileName["cPropertyName"].ToString().Trim();
                    _StrPropValue = DrvFileName["cPropertyValueCombo"] == DBNull.Value || DrvFileName["cPropertyValueCombo"].ToString().Trim() == "" ? "Custom Property Combo Value" : DrvFileName["cPropertyValueCombo"].ToString().Trim();
                    if (_StrPropValue == "" || _StrPropValue == "Custom Property Combo Value")
                    {
                        _StrPropValue = DrvFileName["cPropertyValue"] == DBNull.Value || DrvFileName["cPropertyValue"].ToString().Trim() == "" ? "Custom Property Value" : DrvFileName["cPropertyValue"].ToString().Trim();
                    }
                    addProperty(PropModelItem: NVApi.Application.ActiveDocument.Models.First.RootItem, strPropName: _StrPropName, strPropValue: _StrPropValue);
                    NVApi.Application.ActiveDocument.SaveFile(_StrNewFilePath, NVApi.DocumentFileVersion.Current);
                }

            }
            catch 
            {
                throw;
            }
        }
        private void AddPropertyItem()
        {
            try
            {
                foreach (DataRowView DrvFileName in dtListOfFiles.DefaultView)
                {
                    /*-----------------------------------------------------------------------------------*/
                    NVApi.Application.ActiveDocument.TryOpenFile(DrvFileName["cFileLocation"].ToString());

                    //Autodesk.Navisworks.Api.Application.ActiveDocument.SetActiveSheet(strSheetId);
                    string _StrNewFilePath = Path.Combine(Path.GetDirectoryName(DrvFileName["cFileLocation"].ToString()), Path.ChangeExtension(DrvFileName["cFileLocation"].ToString(), ".nwf"));
                    NVApi.ModelItem[] Modelitems = NVApi.Application.ActiveDocument.Models.First.RootItem.DescendantsAndSelf.ToArray();
                    if (Modelitems == null) { return; }
                    foreach (var PropModelItem in Modelitems)
                    {
                        string _StrPropName = "";
                        string _StrPropValue = "";
                        _StrPropName = DrvFileName["cFileLocation"] == DBNull.Value || DrvFileName["cPropertyName"].ToString().Trim() == "" ? "Custom Property" : DrvFileName["cPropertyName"].ToString().Trim();
                        _StrPropValue = DrvFileName["cPropertyValueCombo"] == DBNull.Value || DrvFileName["cPropertyValueCombo"].ToString().Trim() == "" ? "Custom Property Combo Value" : DrvFileName["cPropertyValueCombo"].ToString().Trim();
                        if (_StrPropValue == "" || _StrPropValue == "Custom Property Combo Value")
                        {
                            _StrPropValue = DrvFileName["cPropertyValue"] == DBNull.Value || DrvFileName["cPropertyValue"].ToString().Trim() == "" ? "Custom Property Value" : DrvFileName["cPropertyValue"].ToString().Trim();
                        }

                        addProperty(PropModelItem: PropModelItem, strPropName: _StrPropName, strPropValue: _StrPropValue);
                    }
                    NVApi.Application.ActiveDocument.SaveFile(_StrNewFilePath, NVApi.DocumentFileVersion.Current);
                }
            }
            catch
            {
                throw;
            }
        }
        private void AddPropertyModelFile_ItemBoth()
        {
            try
            {
                foreach (DataRowView DrvFileName in dtListOfFiles.DefaultView)
                {
                    /*-----------------------------------------------------------------------------------*/
                    NVApi.Application.ActiveDocument.TryOpenFile(DrvFileName["cFileLocation"].ToString());

                    string _StrNewFilePath = Path.Combine(Path.GetDirectoryName(DrvFileName["cFileLocation"].ToString()), Path.ChangeExtension(DrvFileName["cFileLocation"].ToString(), ".nwf"));
                    string _StrPropName = "";
                    string _StrPropValue = "";
                    _StrPropName = DrvFileName["cFileLocation"] == DBNull.Value || DrvFileName["cPropertyName"].ToString().Trim() == "" ? "Custom Property" : DrvFileName["cPropertyName"].ToString().Trim();
                    _StrPropValue = DrvFileName["cPropertyValueCombo"] == DBNull.Value || DrvFileName["cPropertyValueCombo"].ToString().Trim() == "" ? "Custom Property Combo Value" : DrvFileName["cPropertyValueCombo"].ToString().Trim();
                    if (_StrPropValue == "" || _StrPropValue == "Custom Property Combo Value")
                    {
                        _StrPropValue = DrvFileName["cPropertyValue"] == DBNull.Value || DrvFileName["cPropertyValue"].ToString().Trim() == "" ? "Custom Property Value" : DrvFileName["cPropertyValue"].ToString().Trim();
                    }

                    addProperty(PropModelItem: NVApi.Application.ActiveDocument.Models.First.RootItem, strPropName: _StrPropName, strPropValue: _StrPropValue);


                    NVApi.ModelItem[] Modelitems = NVApi.Application.ActiveDocument.Models.First.RootItem.DescendantsAndSelf.ToArray();
                    if (Modelitems == null) { return; }
                    foreach (var PropModelItem in Modelitems)
                    {
                        addProperty(PropModelItem: PropModelItem, strPropName: _StrPropName, strPropValue: _StrPropValue);
                    }
                    NVApi.Application.ActiveDocument.SaveFile(_StrNewFilePath, NVApi.DocumentFileVersion.Current);
                }
            }
            catch
            {
                throw;
            }
        }
        private void addProperty(NVApi.ModelItem PropModelItem, string strPropName, string strPropValue)
        {
            try
            {
                COM.InwOpState10 state;
                state = ComApiBridge.State;
                // get current selection
                NVApi.ModelItemCollection modelItemCollectionIn = new NVApi.ModelItemCollection();
                modelItemCollectionIn.Add(PropModelItem);
                // get the selection in COM
                Autodesk.Navisworks.Api.Interop.ComApi.InwOpSelection comSelectionOut = ComApiBridge.ToInwOpSelection(modelItemCollectionIn);
                // get paths within the selection
                COM.InwSelectionPathsColl oPaths = comSelectionOut.Paths();
                COM.InwOaPath3 oPath = (COM.InwOaPath3)oPaths.Last();
                // get properties collection of the path
                COM.InwGUIPropertyNode2 propn = (COM.InwGUIPropertyNode2)state.GetGUIPropertyNode(oPath, true);

                // create new property category
                // (new tab in the properties dialog)
                COM.InwOaPropertyVec newPvec = (COM.InwOaPropertyVec)state.ObjectFactory(COM.nwEObjectType.eObjectType_nwOaPropertyVec, null, null);
                // create new property
                COM.InwOaProperty newP = (COM.InwOaProperty)state.ObjectFactory(COM.nwEObjectType.eObjectType_nwOaProperty, null, null);
                // set the name, username and value of the new property
                newP.name = "lc" + strPropName;
                newP.UserName = strPropName;
                newP.value = strPropValue;
                // add the new property to the new property category
                newPvec.Properties().Add(newP);
                // add the new property category to the path
                propn.SetUserDefined(0, "NV-AddedProety", "lcNVAddedProety", newPvec);
            }
            catch
            {
                throw;
            }
        }

    }
}

