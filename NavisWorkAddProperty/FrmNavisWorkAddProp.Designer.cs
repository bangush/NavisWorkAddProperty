namespace NavisWorkAddProperty
{
    partial class FrmNavisWorkAddProp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RbModelFileItem = new System.Windows.Forms.RadioButton();
            this.RbItemOnly = new System.Windows.Forms.RadioButton();
            this.RbModelFileOnly = new System.Windows.Forms.RadioButton();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TxtNavisWorkFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddProperty = new System.Windows.Forms.Button();
            this.GrdNavisModelFile = new System.Windows.Forms.DataGridView();
            this.GrdColModelFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdColPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdColPropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdColPropertyValueCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlUpdateButtons = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNavisModelFile)).BeginInit();
            this.pnlUpdateButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.RbModelFileItem);
            this.pnlHeader.Controls.Add(this.RbItemOnly);
            this.pnlHeader.Controls.Add(this.RbModelFileOnly);
            this.pnlHeader.Controls.Add(this.BtnSelectFile);
            this.pnlHeader.Controls.Add(this.TxtNavisWorkFileLocation);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(909, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Property";
            // 
            // RbModelFileItem
            // 
            this.RbModelFileItem.AutoSize = true;
            this.RbModelFileItem.Location = new System.Drawing.Point(430, 37);
            this.RbModelFileItem.Name = "RbModelFileItem";
            this.RbModelFileItem.Size = new System.Drawing.Size(130, 17);
            this.RbModelFileItem.TabIndex = 5;
            this.RbModelFileItem.Text = "Model File && Item Both";
            this.RbModelFileItem.UseVisualStyleBackColor = true;
            // 
            // RbItemOnly
            // 
            this.RbItemOnly.AutoSize = true;
            this.RbItemOnly.Location = new System.Drawing.Point(298, 36);
            this.RbItemOnly.Name = "RbItemOnly";
            this.RbItemOnly.Size = new System.Drawing.Size(80, 17);
            this.RbItemOnly.TabIndex = 4;
            this.RbItemOnly.Text = "Item(s) Only";
            this.RbItemOnly.UseVisualStyleBackColor = true;
            // 
            // RbModelFileOnly
            // 
            this.RbModelFileOnly.AutoSize = true;
            this.RbModelFileOnly.Checked = true;
            this.RbModelFileOnly.Location = new System.Drawing.Point(168, 36);
            this.RbModelFileOnly.Name = "RbModelFileOnly";
            this.RbModelFileOnly.Size = new System.Drawing.Size(97, 17);
            this.RbModelFileOnly.TabIndex = 3;
            this.RbModelFileOnly.TabStop = true;
            this.RbModelFileOnly.Text = "Model File Only";
            this.RbModelFileOnly.UseVisualStyleBackColor = true;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectFile.FlatAppearance.BorderSize = 0;
            this.BtnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectFile.Image = global::NavisWorkAddProperty.Properties.Resources.OpenFolder22X22;
            this.BtnSelectFile.Location = new System.Drawing.Point(641, 8);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(28, 23);
            this.BtnSelectFile.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BtnSelectFile, "Select File Location");
            this.BtnSelectFile.UseVisualStyleBackColor = false;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TxtNavisWorkFileLocation
            // 
            this.TxtNavisWorkFileLocation.BackColor = System.Drawing.Color.White;
            this.TxtNavisWorkFileLocation.Location = new System.Drawing.Point(168, 10);
            this.TxtNavisWorkFileLocation.Name = "TxtNavisWorkFileLocation";
            this.TxtNavisWorkFileLocation.ReadOnly = true;
            this.TxtNavisWorkFileLocation.Size = new System.Drawing.Size(467, 20);
            this.TxtNavisWorkFileLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select NavisWork File Location";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.Image = global::NavisWorkAddProperty.Properties.Resources.SelectNone16X16;
            this.BtnClose.Location = new System.Drawing.Point(776, 8);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 28);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = " &Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnClose, "Select File Location");
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddProperty
            // 
            this.BtnAddProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddProperty.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddProperty.FlatAppearance.BorderSize = 0;
            this.BtnAddProperty.Image = global::NavisWorkAddProperty.Properties.Resources.UpArrowGreen8X16;
            this.BtnAddProperty.Location = new System.Drawing.Point(650, 8);
            this.BtnAddProperty.Name = "BtnAddProperty";
            this.BtnAddProperty.Size = new System.Drawing.Size(120, 28);
            this.BtnAddProperty.TabIndex = 2;
            this.BtnAddProperty.Text = "  &Add Properties";
            this.BtnAddProperty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnAddProperty, "Select File Location");
            this.BtnAddProperty.UseVisualStyleBackColor = false;
            this.BtnAddProperty.Click += new System.EventHandler(this.BtnAddProperty_Click);
            // 
            // GrdNavisModelFile
            // 
            this.GrdNavisModelFile.AllowUserToAddRows = false;
            this.GrdNavisModelFile.AllowUserToDeleteRows = false;
            this.GrdNavisModelFile.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GrdNavisModelFile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdNavisModelFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdNavisModelFile.BackgroundColor = System.Drawing.Color.White;
            this.GrdNavisModelFile.ColumnHeadersHeight = 35;
            this.GrdNavisModelFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrdColModelFileName,
            this.GrdColPropertyName,
            this.GrdColPropertyValue,
            this.GrdColPropertyValueCombo});
            this.GrdNavisModelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdNavisModelFile.GridColor = System.Drawing.Color.White;
            this.GrdNavisModelFile.Location = new System.Drawing.Point(0, 0);
            this.GrdNavisModelFile.Name = "GrdNavisModelFile";
            this.GrdNavisModelFile.Size = new System.Drawing.Size(398, 589);
            this.GrdNavisModelFile.TabIndex = 1;
            // 
            // GrdColModelFileName
            // 
            this.GrdColModelFileName.DataPropertyName = "cFileName";
            this.GrdColModelFileName.HeaderText = "Model File Name";
            this.GrdColModelFileName.Name = "GrdColModelFileName";
            this.GrdColModelFileName.ReadOnly = true;
            // 
            // GrdColPropertyName
            // 
            this.GrdColPropertyName.DataPropertyName = "cPropertyName";
            this.GrdColPropertyName.HeaderText = "Property Name";
            this.GrdColPropertyName.Name = "GrdColPropertyName";
            // 
            // GrdColPropertyValue
            // 
            this.GrdColPropertyValue.DataPropertyName = "cPropertyValue";
            this.GrdColPropertyValue.HeaderText = "Property Value";
            this.GrdColPropertyValue.Name = "GrdColPropertyValue";
            // 
            // GrdColPropertyValueCombo
            // 
            this.GrdColPropertyValueCombo.DataPropertyName = "cPropertyValueCombo";
            this.GrdColPropertyValueCombo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.GrdColPropertyValueCombo.HeaderText = "Property Value Combobox";
            this.GrdColPropertyValueCombo.Name = "GrdColPropertyValueCombo";
            // 
            // pnlUpdateButtons
            // 
            this.pnlUpdateButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateButtons.Controls.Add(this.BtnClose);
            this.pnlUpdateButtons.Controls.Add(this.BtnAddProperty);
            this.pnlUpdateButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateButtons.Location = new System.Drawing.Point(0, 650);
            this.pnlUpdateButtons.Name = "pnlUpdateButtons";
            this.pnlUpdateButtons.Size = new System.Drawing.Size(909, 49);
            this.pnlUpdateButtons.TabIndex = 2;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 61);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.GrdNavisModelFile);
            this.splitContainerMain.Size = new System.Drawing.Size(909, 589);
            this.splitContainerMain.SplitterDistance = 398;
            this.splitContainerMain.TabIndex = 3;
            // 
            // FrmNavisWorkAddProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 699);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.pnlUpdateButtons);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmNavisWorkAddProp";
            this.Text = "NavisWork Add Properties";
            this.Load += new System.EventHandler(this.FrmNavisWorkAddProp_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNavisModelFile)).EndInit();
            this.pnlUpdateButtons.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.TextBox TxtNavisWorkFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView GrdNavisModelFile;
        private System.Windows.Forms.Panel pnlUpdateButtons;
        private System.Windows.Forms.Button BtnAddProperty;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrdColModelFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrdColPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrdColPropertyValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn GrdColPropertyValueCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbModelFileItem;
        private System.Windows.Forms.RadioButton RbItemOnly;
        private System.Windows.Forms.RadioButton RbModelFileOnly;
        private System.Windows.Forms.SplitContainer splitContainerMain;
    }
}

