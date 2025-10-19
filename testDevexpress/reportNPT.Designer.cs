namespace testDevexpress
{
    partial class reportNPT
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
            this.checkedListDepartments = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateStartEdit = new DevExpress.XtraEditors.DateEdit();
            this.dateEndEdit = new DevExpress.XtraEditors.DateEdit();
            this.comboPeriodicity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAddPeriod = new DevExpress.XtraEditors.SimpleButton();
            this.gridPeriods = new DevExpress.XtraGrid.GridControl();
            this.gridViewPeriods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddNomenclature = new DevExpress.XtraEditors.SimpleButton();
            this.treeListNomenclature = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriodicity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListNomenclature)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListDepartments
            // 
            this.checkedListDepartments.Location = new System.Drawing.Point(986, 35);
            this.checkedListDepartments.Name = "checkedListDepartments";
            this.checkedListDepartments.Size = new System.Drawing.Size(207, 147);
            this.checkedListDepartments.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(986, 359);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(207, 23);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Сформировать отчёт";
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridPeriods);
            this.groupControl1.Controls.Add(this.btnAddPeriod);
            this.groupControl1.Controls.Add(this.comboPeriodicity);
            this.groupControl1.Controls.Add(this.dateEndEdit);
            this.groupControl1.Controls.Add(this.dateStartEdit);
            this.groupControl1.Location = new System.Drawing.Point(370, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(557, 434);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // dateStartEdit
            // 
            this.dateStartEdit.EditValue = null;
            this.dateStartEdit.Location = new System.Drawing.Point(14, 26);
            this.dateStartEdit.Name = "dateStartEdit";
            this.dateStartEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartEdit.Size = new System.Drawing.Size(100, 20);
            this.dateStartEdit.TabIndex = 0;
            // 
            // dateEndEdit
            // 
            this.dateEndEdit.EditValue = null;
            this.dateEndEdit.Location = new System.Drawing.Point(14, 52);
            this.dateEndEdit.Name = "dateEndEdit";
            this.dateEndEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndEdit.Size = new System.Drawing.Size(100, 20);
            this.dateEndEdit.TabIndex = 1;
            // 
            // comboPeriodicity
            // 
            this.comboPeriodicity.Location = new System.Drawing.Point(140, 26);
            this.comboPeriodicity.Name = "comboPeriodicity";
            this.comboPeriodicity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboPeriodicity.Size = new System.Drawing.Size(166, 20);
            this.comboPeriodicity.TabIndex = 2;
            // 
            // btnAddPeriod
            // 
            this.btnAddPeriod.Location = new System.Drawing.Point(354, 29);
            this.btnAddPeriod.Name = "btnAddPeriod";
            this.btnAddPeriod.Size = new System.Drawing.Size(75, 23);
            this.btnAddPeriod.TabIndex = 3;
            this.btnAddPeriod.Text = "Добавить период/переодичность";
            this.btnAddPeriod.Click += new System.EventHandler(this.BtnAddPeriod_Click);
            // 
            // gridPeriods
            // 
            this.gridPeriods.Location = new System.Drawing.Point(14, 93);
            this.gridPeriods.MainView = this.gridViewPeriods;
            this.gridPeriods.Name = "gridPeriods";
            this.gridPeriods.Size = new System.Drawing.Size(533, 327);
            this.gridPeriods.TabIndex = 4;
            this.gridPeriods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPeriods});
            // 
            // gridViewPeriods
            // 
            this.gridViewPeriods.GridControl = this.gridPeriods;
            this.gridViewPeriods.Name = "gridViewPeriods";
            // 
            // btnAddNomenclature
            // 
            this.btnAddNomenclature.Location = new System.Drawing.Point(12, 128);
            this.btnAddNomenclature.Name = "btnAddNomenclature";
            this.btnAddNomenclature.Size = new System.Drawing.Size(319, 23);
            this.btnAddNomenclature.TabIndex = 1;
            this.btnAddNomenclature.Text = "Добавить выбранные позиции";
            this.btnAddNomenclature.Click += new System.EventHandler(this.btnAddNomenclature_Click);
            // 
            // treeListNomenclature
            // 
            this.treeListNomenclature.Location = new System.Drawing.Point(12, 12);
            this.treeListNomenclature.Name = "treeListNomenclature";
            this.treeListNomenclature.Size = new System.Drawing.Size(319, 95);
            this.treeListNomenclature.TabIndex = 7;
            // 
            // reportNPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 521);
            this.Controls.Add(this.treeListNomenclature);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.checkedListDepartments);
            this.Controls.Add(this.btnAddNomenclature);
            this.Name = "reportNPT";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.checkedListDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateStartEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriodicity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListNomenclature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListDepartments;
        private DevExpress.XtraEditors.SimpleButton btnGenerateReport;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddPeriod;
        private DevExpress.XtraEditors.ComboBoxEdit comboPeriodicity;
        private DevExpress.XtraEditors.DateEdit dateEndEdit;
        private DevExpress.XtraEditors.DateEdit dateStartEdit;
        private DevExpress.XtraGrid.GridControl gridPeriods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPeriods;
        private DevExpress.XtraEditors.SimpleButton btnAddNomenclature;
        private DevExpress.XtraTreeList.TreeList treeListNomenclature;
    }
}

