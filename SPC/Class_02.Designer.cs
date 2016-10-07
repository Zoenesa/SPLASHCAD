namespace SPC
{
    partial class FormExtendedSelect
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
            this.Field_00 = new System.Windows.Forms.Button();
            this.ButtonRemoveIntervalX = new System.Windows.Forms.Button();
            this.TextBoxLIX = new System.Windows.Forms.TextBox();
            this.TextBoxLSX = new System.Windows.Forms.TextBox();
            this.LabelFromX = new System.Windows.Forms.Label();
            this.LabelToX = new System.Windows.Forms.Label();
            this.DataGridViewX = new System.Windows.Forms.DataGridView();
            this.ColumnIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddIntervalZ = new System.Windows.Forms.Button();
            this.LabelFilterXCoordinate = new System.Windows.Forms.Label();
            this.LabelFilterCoordinateY = new System.Windows.Forms.Label();
            this.ButtonRemoveIntervalY = new System.Windows.Forms.Button();
            this.DataGridViewY = new System.Windows.Forms.DataGridView();
            this.ColumnIy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelFromY = new System.Windows.Forms.Label();
            this.TextBoxLSY = new System.Windows.Forms.TextBox();
            this.TextBoxLIY = new System.Windows.Forms.TextBox();
            this.Field_03 = new System.Windows.Forms.Button();
            this.LabelFilterZCoordinate = new System.Windows.Forms.Label();
            this.ButtonRemoveIntervalZ = new System.Windows.Forms.Button();
            this.LabelFromZ = new System.Windows.Forms.Label();
            this.Field_04 = new System.Windows.Forms.Label();
            this.TextBoxLSZ = new System.Windows.Forms.TextBox();
            this.TextBoxLIZ = new System.Windows.Forms.TextBox();
            this.Field_05 = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ComboBoxLayer = new System.Windows.Forms.ComboBox();
            this.LabelLayer = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.CheckBoxAddCurrentSelectionSet = new System.Windows.Forms.CheckBox();
            this.CheckBoxSetColor = new System.Windows.Forms.CheckBox();
            this.CheckBoxSetLayer = new System.Windows.Forms.CheckBox();
            this.CheckBoxExportExcel = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonRefreshLayerList = new System.Windows.Forms.Button();
            this.ButtonVideoHelp = new System.Windows.Forms.Button();
            this.ButtonAddIntervalX = new System.Windows.Forms.Button();
            this.GroupBoxAction = new System.Windows.Forms.GroupBox();
            this.ButtonAddIntervalY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewY)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.GroupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // Field_00
            // 
            this.Field_00.Location = new System.Drawing.Point(14, 83);
            this.Field_00.Name = "Field_00";
            this.Field_00.Size = new System.Drawing.Size(87, 27);
            this.Field_00.TabIndex = 0;
            this.Field_00.Text = "button1";
            this.Field_00.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveIntervalX
            // 
            this.ButtonRemoveIntervalX.Location = new System.Drawing.Point(297, 26);
            this.ButtonRemoveIntervalX.Name = "ButtonRemoveIntervalX";
            this.ButtonRemoveIntervalX.Size = new System.Drawing.Size(92, 30);
            this.ButtonRemoveIntervalX.TabIndex = 6;
            this.ButtonRemoveIntervalX.Text = "Remove Interval";
            this.ButtonRemoveIntervalX.UseVisualStyleBackColor = true;
            // 
            // TextBoxLIX
            // 
            this.TextBoxLIX.Location = new System.Drawing.Point(45, 120);
            this.TextBoxLIX.Name = "TextBoxLIX";
            this.TextBoxLIX.Size = new System.Drawing.Size(100, 23);
            this.TextBoxLIX.TabIndex = 1;
            // 
            // TextBoxLSX
            // 
            this.TextBoxLSX.Location = new System.Drawing.Point(191, 120);
            this.TextBoxLSX.Name = "TextBoxLSX";
            this.TextBoxLSX.Size = new System.Drawing.Size(100, 23);
            this.TextBoxLSX.TabIndex = 2;
            // 
            // LabelFromX
            // 
            this.LabelFromX.AutoSize = true;
            this.LabelFromX.Location = new System.Drawing.Point(8, 123);
            this.LabelFromX.Name = "LabelFromX";
            this.LabelFromX.Size = new System.Drawing.Size(35, 15);
            this.LabelFromX.TabIndex = 4;
            this.LabelFromX.Text = "From";
            // 
            // LabelToX
            // 
            this.LabelToX.AutoSize = true;
            this.LabelToX.Location = new System.Drawing.Point(151, 123);
            this.LabelToX.Name = "LabelToX";
            this.LabelToX.Size = new System.Drawing.Size(20, 15);
            this.LabelToX.TabIndex = 4;
            this.LabelToX.Text = "To";
            // 
            // DataGridViewX
            // 
            this.DataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIX,
            this.ColumnSX});
            this.DataGridViewX.Location = new System.Drawing.Point(14, 117);
            this.DataGridViewX.Name = "DataGridViewX";
            this.DataGridViewX.Size = new System.Drawing.Size(279, 84);
            this.DataGridViewX.TabIndex = 5;
            // 
            // ColumnIX
            // 
            this.ColumnIX.HeaderText = "Limit Inferior";
            this.ColumnIX.Name = "ColumnIX";
            this.ColumnIX.ReadOnly = true;
            this.ColumnIX.Width = 110;
            // 
            // ColumnSX
            // 
            this.ColumnSX.HeaderText = "Limit Superior";
            this.ColumnSX.Name = "ColumnSX";
            this.ColumnSX.ReadOnly = true;
            this.ColumnSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSX.Width = 110;
            // 
            // ButtonAddIntervalZ
            // 
            this.ButtonAddIntervalZ.Location = new System.Drawing.Point(297, 395);
            this.ButtonAddIntervalZ.Name = "ButtonAddIntervalZ";
            this.ButtonAddIntervalZ.Size = new System.Drawing.Size(87, 27);
            this.ButtonAddIntervalZ.TabIndex = 16;
            this.ButtonAddIntervalZ.Text = "Add Interval";
            this.ButtonAddIntervalZ.UseVisualStyleBackColor = true;
            // 
            // LabelFilterXCoordinate
            // 
            this.LabelFilterXCoordinate.AutoSize = true;
            this.LabelFilterXCoordinate.Location = new System.Drawing.Point(12, 9);
            this.LabelFilterXCoordinate.Name = "LabelFilterXCoordinate";
            this.LabelFilterXCoordinate.Size = new System.Drawing.Size(122, 15);
            this.LabelFilterXCoordinate.TabIndex = 7;
            this.LabelFilterXCoordinate.Text = "Filter on X Coordinate";
            // 
            // LabelFilterCoordinateY
            // 
            this.LabelFilterCoordinateY.AutoSize = true;
            this.LabelFilterCoordinateY.Location = new System.Drawing.Point(12, 149);
            this.LabelFilterCoordinateY.Name = "LabelFilterCoordinateY";
            this.LabelFilterCoordinateY.Size = new System.Drawing.Size(122, 15);
            this.LabelFilterCoordinateY.TabIndex = 15;
            this.LabelFilterCoordinateY.Text = "Filter on Y Coordinate";
            // 
            // ButtonRemoveIntervalY
            // 
            this.ButtonRemoveIntervalY.Location = new System.Drawing.Point(297, 166);
            this.ButtonRemoveIntervalY.Name = "ButtonRemoveIntervalY";
            this.ButtonRemoveIntervalY.Size = new System.Drawing.Size(92, 30);
            this.ButtonRemoveIntervalY.TabIndex = 14;
            this.ButtonRemoveIntervalY.Text = "Remove Interval";
            this.ButtonRemoveIntervalY.UseVisualStyleBackColor = true;
            // 
            // DataGridViewY
            // 
            this.DataGridViewY.AllowUserToAddRows = false;
            this.DataGridViewY.AllowUserToDeleteRows = false;
            this.DataGridViewY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIy,
            this.ColumnSY});
            this.DataGridViewY.Location = new System.Drawing.Point(14, 207);
            this.DataGridViewY.Name = "DataGridViewY";
            this.DataGridViewY.Size = new System.Drawing.Size(279, 84);
            this.DataGridViewY.TabIndex = 5;
            // 
            // ColumnIy
            // 
            this.ColumnIy.HeaderText = "Limit Inferior";
            this.ColumnIy.Name = "ColumnIy";
            this.ColumnIy.ReadOnly = true;
            this.ColumnIy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnIy.Width = 110;
            // 
            // ColumnSY
            // 
            this.ColumnSY.HeaderText = "Limit Superior";
            this.ColumnSY.Name = "ColumnSY";
            this.ColumnSY.ReadOnly = true;
            this.ColumnSY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSY.Width = 110;
            // 
            // LabelFromY
            // 
            this.LabelFromY.AutoSize = true;
            this.LabelFromY.Location = new System.Drawing.Point(8, 263);
            this.LabelFromY.Name = "LabelFromY";
            this.LabelFromY.Size = new System.Drawing.Size(35, 15);
            this.LabelFromY.TabIndex = 4;
            this.LabelFromY.Text = "From";
            // 
            // TextBoxLSY
            // 
            this.TextBoxLSY.Location = new System.Drawing.Point(19, 260);
            this.TextBoxLSY.Name = "TextBoxLSY";
            this.TextBoxLSY.Size = new System.Drawing.Size(100, 23);
            this.TextBoxLSY.TabIndex = 10;
            // 
            // TextBoxLIY
            // 
            this.TextBoxLIY.Location = new System.Drawing.Point(45, 260);
            this.TextBoxLIY.Name = "TextBoxLIY";
            this.TextBoxLIY.Size = new System.Drawing.Size(100, 23);
            this.TextBoxLIY.TabIndex = 3;
            // 
            // Field_03
            // 
            this.Field_03.Location = new System.Drawing.Point(301, 171);
            this.Field_03.Name = "Field_03";
            this.Field_03.Size = new System.Drawing.Size(87, 27);
            this.Field_03.TabIndex = 1;
            this.Field_03.Text = "button2";
            this.Field_03.UseVisualStyleBackColor = true;
            // 
            // LabelFilterZCoordinate
            // 
            this.LabelFilterZCoordinate.AutoSize = true;
            this.LabelFilterZCoordinate.Location = new System.Drawing.Point(12, 290);
            this.LabelFilterZCoordinate.Name = "LabelFilterZCoordinate";
            this.LabelFilterZCoordinate.Size = new System.Drawing.Size(130, 13);
            this.LabelFilterZCoordinate.TabIndex = 23;
            this.LabelFilterZCoordinate.Text = "Filter on Z Coordinate";
            // 
            // ButtonRemoveIntervalZ
            // 
            this.ButtonRemoveIntervalZ.Location = new System.Drawing.Point(297, 307);
            this.ButtonRemoveIntervalZ.Name = "ButtonRemoveIntervalZ";
            this.ButtonRemoveIntervalZ.Size = new System.Drawing.Size(92, 30);
            this.ButtonRemoveIntervalZ.TabIndex = 1;
            this.ButtonRemoveIntervalZ.Text = "Remove Interval";
            this.ButtonRemoveIntervalZ.UseVisualStyleBackColor = true;
            // 
            // LabelFromZ
            // 
            this.LabelFromZ.AutoSize = true;
            this.LabelFromZ.Location = new System.Drawing.Point(395, 171);
            this.LabelFromZ.Name = "LabelFromZ";
            this.LabelFromZ.Size = new System.Drawing.Size(38, 15);
            this.LabelFromZ.TabIndex = 4;
            this.LabelFromZ.Text = "label1";
            // 
            // Field_04
            // 
            this.Field_04.AutoSize = true;
            this.Field_04.Location = new System.Drawing.Point(395, 204);
            this.Field_04.Name = "Field_04";
            this.Field_04.Size = new System.Drawing.Size(38, 15);
            this.Field_04.TabIndex = 4;
            this.Field_04.Text = "label1";
            // 
            // TextBoxLSZ
            // 
            this.TextBoxLSZ.Location = new System.Drawing.Point(301, 238);
            this.TextBoxLSZ.Name = "TextBoxLSZ";
            this.TextBoxLSZ.Size = new System.Drawing.Size(116, 23);
            this.TextBoxLSZ.TabIndex = 2;
            // 
            // TextBoxLIZ
            // 
            this.TextBoxLIZ.Location = new System.Drawing.Point(301, 268);
            this.TextBoxLIZ.Name = "TextBoxLIZ";
            this.TextBoxLIZ.Size = new System.Drawing.Size(116, 23);
            this.TextBoxLIZ.TabIndex = 17;
            // 
            // Field_05
            // 
            this.Field_05.Location = new System.Drawing.Point(443, 165);
            this.Field_05.Name = "Field_05";
            this.Field_05.Size = new System.Drawing.Size(87, 27);
            this.Field_05.TabIndex = 1;
            this.Field_05.Text = "button2";
            this.Field_05.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(510, 332);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 34);
            this.ButtonCancel.TabIndex = 26;
            this.ButtonCancel.Text = "Close";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(510, 292);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(97, 34);
            this.ButtonRun.TabIndex = 25;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            // 
            // ComboBoxLayer
            // 
            this.ComboBoxLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLayer.Location = new System.Drawing.Point(414, 149);
            this.ComboBoxLayer.Name = "ComboBoxLayer";
            this.ComboBoxLayer.Size = new System.Drawing.Size(177, 23);
            this.ComboBoxLayer.TabIndex = 27;
            // 
            // LabelLayer
            // 
            this.LabelLayer.AutoSize = true;
            this.LabelLayer.Location = new System.Drawing.Point(411, 130);
            this.LabelLayer.Name = "LabelLayer";
            this.LabelLayer.Size = new System.Drawing.Size(35, 15);
            this.LabelLayer.TabIndex = 30;
            this.LabelLayer.Text = "Layer";
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Location = new System.Drawing.Point(411, 220);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(36, 15);
            this.LabelColor.TabIndex = 30;
            this.LabelColor.Text = "Color";
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(414, 240);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(97, 23);
            this.ComboBoxColor.TabIndex = 29;
            // 
            // CheckBoxAddCurrentSelectionSet
            // 
            this.CheckBoxAddCurrentSelectionSet.AutoSize = true;
            this.CheckBoxAddCurrentSelectionSet.Location = new System.Drawing.Point(20, 85);
            this.CheckBoxAddCurrentSelectionSet.Name = "CheckBoxAddCurrentSelectionSet";
            this.CheckBoxAddCurrentSelectionSet.Size = new System.Drawing.Size(195, 19);
            this.CheckBoxAddCurrentSelectionSet.TabIndex = 31;
            this.CheckBoxAddCurrentSelectionSet.Text = "Append to Current Selection Set";
            this.CheckBoxAddCurrentSelectionSet.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSetColor
            // 
            this.CheckBoxSetColor.AutoSize = true;
            this.CheckBoxSetColor.Location = new System.Drawing.Point(7, 41);
            this.CheckBoxSetColor.Name = "CheckBoxSetColor";
            this.CheckBoxSetColor.Size = new System.Drawing.Size(74, 19);
            this.CheckBoxSetColor.TabIndex = 32;
            this.CheckBoxSetColor.Text = "Set Color";
            this.CheckBoxSetColor.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSetLayer
            // 
            this.CheckBoxSetLayer.AutoSize = true;
            this.CheckBoxSetLayer.Location = new System.Drawing.Point(7, 64);
            this.CheckBoxSetLayer.Name = "CheckBoxSetLayer";
            this.CheckBoxSetLayer.Size = new System.Drawing.Size(73, 19);
            this.CheckBoxSetLayer.TabIndex = 33;
            this.CheckBoxSetLayer.Text = "Set Layer";
            this.CheckBoxSetLayer.UseVisualStyleBackColor = true;
            // 
            // CheckBoxExportExcel
            // 
            this.CheckBoxExportExcel.AutoSize = true;
            this.CheckBoxExportExcel.Location = new System.Drawing.Point(7, 87);
            this.CheckBoxExportExcel.Name = "CheckBoxExportExcel";
            this.CheckBoxExportExcel.Size = new System.Drawing.Size(102, 19);
            this.CheckBoxExportExcel.TabIndex = 34;
            this.CheckBoxExportExcel.Text = "Export to Excel";
            this.CheckBoxExportExcel.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(427, 417);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(178, 12);
            this.ProgressBar.TabIndex = 29;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(655, 24);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelInfo
            // 
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LabelInfo.Size = new System.Drawing.Size(41, 19);
            this.LabelInfo.Text = "Ready";
            // 
            // ButtonRefreshLayerList
            // 
            this.ButtonRefreshLayerList.Location = new System.Drawing.Point(454, 176);
            this.ButtonRefreshLayerList.Name = "ButtonRefreshLayerList";
            this.ButtonRefreshLayerList.Size = new System.Drawing.Size(85, 36);
            this.ButtonRefreshLayerList.TabIndex = 64;
            this.ButtonRefreshLayerList.Text = "Refresh Layer List";
            this.ButtonRefreshLayerList.UseVisualStyleBackColor = true;
            // 
            // ButtonVideoHelp
            // 
            this.ButtonVideoHelp.Location = new System.Drawing.Point(510, 372);
            this.ButtonVideoHelp.Name = "ButtonVideoHelp";
            this.ButtonVideoHelp.Size = new System.Drawing.Size(97, 30);
            this.ButtonVideoHelp.TabIndex = 87;
            this.ButtonVideoHelp.Text = "Video Help";
            this.ButtonVideoHelp.UseVisualStyleBackColor = true;
            // 
            // ButtonAddIntervalX
            // 
            this.ButtonAddIntervalX.Location = new System.Drawing.Point(346, 132);
            this.ButtonAddIntervalX.Name = "ButtonAddIntervalX";
            this.ButtonAddIntervalX.Size = new System.Drawing.Size(107, 35);
            this.ButtonAddIntervalX.TabIndex = 0;
            this.ButtonAddIntervalX.Text = "Add Interval";
            this.ButtonAddIntervalX.UseVisualStyleBackColor = true;
            // 
            // GroupBoxAction
            // 
            this.GroupBoxAction.Controls.Add(this.CheckBoxExportExcel);
            this.GroupBoxAction.Controls.Add(this.CheckBoxAddCurrentSelectionSet);
            this.GroupBoxAction.Controls.Add(this.CheckBoxSetLayer);
            this.GroupBoxAction.Controls.Add(this.CheckBoxSetColor);
            this.GroupBoxAction.Location = new System.Drawing.Point(407, 12);
            this.GroupBoxAction.Name = "GroupBoxAction";
            this.GroupBoxAction.Size = new System.Drawing.Size(200, 110);
            this.GroupBoxAction.TabIndex = 88;
            this.GroupBoxAction.TabStop = false;
            this.GroupBoxAction.Text = "Action";
            // 
            // ButtonAddIntervalY
            // 
            this.ButtonAddIntervalY.Location = new System.Drawing.Point(297, 254);
            this.ButtonAddIntervalY.Name = "ButtonAddIntervalY";
            this.ButtonAddIntervalY.Size = new System.Drawing.Size(92, 30);
            this.ButtonAddIntervalY.TabIndex = 8;
            this.ButtonAddIntervalY.Text = "Add Interval";
            this.ButtonAddIntervalY.UseVisualStyleBackColor = true;
            // 
            // FormExtendedSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 458);
            this.Controls.Add(this.ButtonAddIntervalZ);
            this.Controls.Add(this.GroupBoxAction);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ComboBoxColor);
            this.Controls.Add(this.ComboBoxLayer);
            this.Controls.Add(this.DataGridViewY);
            this.Controls.Add(this.DataGridViewX);
            this.Controls.Add(this.LabelFilterXCoordinate);
            this.Controls.Add(this.LabelFilterCoordinateY);
            this.Controls.Add(this.LabelFromY);
            this.Controls.Add(this.LabelFilterZCoordinate);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.LabelLayer);
            this.Controls.Add(this.Field_04);
            this.Controls.Add(this.LabelFromZ);
            this.Controls.Add(this.LabelToX);
            this.Controls.Add(this.LabelFromX);
            this.Controls.Add(this.TextBoxLIZ);
            this.Controls.Add(this.TextBoxLIY);
            this.Controls.Add(this.TextBoxLSX);
            this.Controls.Add(this.TextBoxLSZ);
            this.Controls.Add(this.TextBoxLSY);
            this.Controls.Add(this.TextBoxLIX);
            this.Controls.Add(this.ButtonRemoveIntervalY);
            this.Controls.Add(this.Field_03);
            this.Controls.Add(this.ButtonRefreshLayerList);
            this.Controls.Add(this.ButtonRun);
            this.Controls.Add(this.ButtonVideoHelp);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.Field_05);
            this.Controls.Add(this.ButtonRemoveIntervalZ);
            this.Controls.Add(this.ButtonAddIntervalY);
            this.Controls.Add(this.ButtonAddIntervalX);
            this.Controls.Add(this.ButtonRemoveIntervalX);
            this.Controls.Add(this.Field_00);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeyPreview = true;
            this.Name = "FormExtendedSelect";
            this.Text = "SPLASH CAD - Extended Point Quick Select and Action";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewY)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupBoxAction.ResumeLayout(false);
            this.GroupBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Field_00;
        private System.Windows.Forms.Button ButtonRemoveIntervalX;
        private System.Windows.Forms.TextBox TextBoxLIX;
        private System.Windows.Forms.TextBox TextBoxLSX;
        private System.Windows.Forms.Label LabelFromX;
        private System.Windows.Forms.Label LabelToX;
        private System.Windows.Forms.DataGridView DataGridViewX;
        private System.Windows.Forms.Button ButtonAddIntervalZ;
        private System.Windows.Forms.Label LabelFilterXCoordinate;
        private System.Windows.Forms.Label LabelFilterCoordinateY;
        private System.Windows.Forms.Button ButtonRemoveIntervalY;
        private System.Windows.Forms.DataGridView DataGridViewY;
        private System.Windows.Forms.Label LabelFromY;
        private System.Windows.Forms.TextBox TextBoxLSY;
        private System.Windows.Forms.TextBox TextBoxLIY;
        private System.Windows.Forms.Button Field_03;
        private System.Windows.Forms.Label LabelFilterZCoordinate;
        private System.Windows.Forms.Button ButtonRemoveIntervalZ;
        private System.Windows.Forms.Label LabelFromZ;
        private System.Windows.Forms.Label Field_04;
        private System.Windows.Forms.TextBox TextBoxLSZ;
        private System.Windows.Forms.TextBox TextBoxLIZ;
        private System.Windows.Forms.Button Field_05;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.ComboBox ComboBoxLayer;
        private System.Windows.Forms.Label LabelLayer;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.ComboBox ComboBoxColor;
        private System.Windows.Forms.CheckBox CheckBoxAddCurrentSelectionSet;
        private System.Windows.Forms.CheckBox CheckBoxSetColor;
        private System.Windows.Forms.CheckBox CheckBoxSetLayer;
        private System.Windows.Forms.CheckBox CheckBoxExportExcel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelInfo;
        private System.Windows.Forms.Button ButtonRefreshLayerList;
        private System.Windows.Forms.Button ButtonVideoHelp;
        private System.Windows.Forms.Button ButtonAddIntervalX;
        private System.Windows.Forms.GroupBox GroupBoxAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSY;
        private System.Windows.Forms.Button ButtonAddIntervalY;
    }
}