namespace Nhom_1_DotNet
{
    partial class FrmDuyetDT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataOfficial = new Nhom_1_DotNet.dataOfficial();
            this.deTaiNCKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiNCKHTableAdapter = new Nhom_1_DotNet.dataOfficialTableAdapters.DeTaiNCKHTableAdapter();
            this.dataOfficial1 = new Nhom_1_DotNet.dataOfficial();
            this.button2 = new System.Windows.Forms.Button();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mADTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALINHVUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAGIANGVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMHOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAGIAITHUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANXETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiNCKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfficial1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các đề tài đã đăng ký";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTION,
            this.mADTDataGridViewTextBoxColumn,
            this.tENDTDataGridViewTextBoxColumn,
            this.mOTADataGridViewTextBoxColumn,
            this.mALINHVUCDataGridViewTextBoxColumn,
            this.mASVDataGridViewTextBoxColumn,
            this.mAKHOADataGridViewTextBoxColumn,
            this.mAGIANGVIENDataGridViewTextBoxColumn,
            this.nAMHOCDataGridViewTextBoxColumn,
            this.mATRANGTHAIDataGridViewTextBoxColumn,
            this.mAGIAITHUONGDataGridViewTextBoxColumn,
            this.nHANXETDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deTaiNCKHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1171, 443);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataOfficial
            // 
            this.dataOfficial.DataSetName = "dataOfficial";
            this.dataOfficial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deTaiNCKHBindingSource
            // 
            this.deTaiNCKHBindingSource.DataMember = "DeTaiNCKH";
            this.deTaiNCKHBindingSource.DataSource = this.dataOfficial;
            // 
            // deTaiNCKHTableAdapter
            // 
            this.deTaiNCKHTableAdapter.ClearBeforeFill = true;
            // 
            // dataOfficial1
            // 
            this.dataOfficial1.DataSetName = "dataOfficial";
            this.dataOfficial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(996, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chỉnh sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ACTION
            // 
            this.ACTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ACTION.Frozen = true;
            this.ACTION.HeaderText = "Chọn";
            this.ACTION.Name = "ACTION";
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // mADTDataGridViewTextBoxColumn
            // 
            this.mADTDataGridViewTextBoxColumn.DataPropertyName = "MADT";
            this.mADTDataGridViewTextBoxColumn.Frozen = true;
            this.mADTDataGridViewTextBoxColumn.HeaderText = "MADT";
            this.mADTDataGridViewTextBoxColumn.Name = "mADTDataGridViewTextBoxColumn";
            // 
            // tENDTDataGridViewTextBoxColumn
            // 
            this.tENDTDataGridViewTextBoxColumn.DataPropertyName = "TENDT";
            this.tENDTDataGridViewTextBoxColumn.Frozen = true;
            this.tENDTDataGridViewTextBoxColumn.HeaderText = "TENDT";
            this.tENDTDataGridViewTextBoxColumn.Name = "tENDTDataGridViewTextBoxColumn";
            // 
            // mOTADataGridViewTextBoxColumn
            // 
            this.mOTADataGridViewTextBoxColumn.DataPropertyName = "MOTA";
            this.mOTADataGridViewTextBoxColumn.HeaderText = "MOTA";
            this.mOTADataGridViewTextBoxColumn.Name = "mOTADataGridViewTextBoxColumn";
            // 
            // mALINHVUCDataGridViewTextBoxColumn
            // 
            this.mALINHVUCDataGridViewTextBoxColumn.DataPropertyName = "MALINHVUC";
            this.mALINHVUCDataGridViewTextBoxColumn.HeaderText = "MALINHVUC";
            this.mALINHVUCDataGridViewTextBoxColumn.Name = "mALINHVUCDataGridViewTextBoxColumn";
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // mAKHOADataGridViewTextBoxColumn
            // 
            this.mAKHOADataGridViewTextBoxColumn.DataPropertyName = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.HeaderText = "MAKHOA";
            this.mAKHOADataGridViewTextBoxColumn.Name = "mAKHOADataGridViewTextBoxColumn";
            // 
            // mAGIANGVIENDataGridViewTextBoxColumn
            // 
            this.mAGIANGVIENDataGridViewTextBoxColumn.DataPropertyName = "MAGIANGVIEN";
            this.mAGIANGVIENDataGridViewTextBoxColumn.HeaderText = "MAGIANGVIEN";
            this.mAGIANGVIENDataGridViewTextBoxColumn.Name = "mAGIANGVIENDataGridViewTextBoxColumn";
            // 
            // nAMHOCDataGridViewTextBoxColumn
            // 
            this.nAMHOCDataGridViewTextBoxColumn.DataPropertyName = "NAMHOC";
            this.nAMHOCDataGridViewTextBoxColumn.HeaderText = "NAMHOC";
            this.nAMHOCDataGridViewTextBoxColumn.Name = "nAMHOCDataGridViewTextBoxColumn";
            // 
            // mATRANGTHAIDataGridViewTextBoxColumn
            // 
            this.mATRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "MATRANGTHAI";
            this.mATRANGTHAIDataGridViewTextBoxColumn.HeaderText = "MATRANGTHAI";
            this.mATRANGTHAIDataGridViewTextBoxColumn.Name = "mATRANGTHAIDataGridViewTextBoxColumn";
            // 
            // mAGIAITHUONGDataGridViewTextBoxColumn
            // 
            this.mAGIAITHUONGDataGridViewTextBoxColumn.DataPropertyName = "MAGIAITHUONG";
            this.mAGIAITHUONGDataGridViewTextBoxColumn.HeaderText = "MAGIAITHUONG";
            this.mAGIAITHUONGDataGridViewTextBoxColumn.Name = "mAGIAITHUONGDataGridViewTextBoxColumn";
            // 
            // nHANXETDataGridViewTextBoxColumn
            // 
            this.nHANXETDataGridViewTextBoxColumn.DataPropertyName = "NHANXET";
            this.nHANXETDataGridViewTextBoxColumn.HeaderText = "NHANXET";
            this.nHANXETDataGridViewTextBoxColumn.Name = "nHANXETDataGridViewTextBoxColumn";
            // 
            // FrmDuyetDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 714);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDuyetDT";
            this.Text = "FrmDuyetDT";
            this.Load += new System.EventHandler(this.FrmDuyetDT_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiNCKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfficial1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataOfficial dataOfficial;
        private System.Windows.Forms.BindingSource deTaiNCKHBindingSource;
        private dataOfficialTableAdapters.DeTaiNCKHTableAdapter deTaiNCKHTableAdapter;
        private dataOfficial dataOfficial1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALINHVUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGIANGVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMHOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGIAITHUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHANXETDataGridViewTextBoxColumn;
    }
}