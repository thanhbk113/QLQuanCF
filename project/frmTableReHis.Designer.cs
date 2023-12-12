namespace project
{
    partial class frmTableReHis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableReHis));
            this.dataGridTableReHis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableReHis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTableReHis
            // 
            this.dataGridTableReHis.AllowUserToAddRows = false;
            this.dataGridTableReHis.AllowUserToDeleteRows = false;
            this.dataGridTableReHis.AllowUserToOrderColumns = true;
            this.dataGridTableReHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableReHis.Location = new System.Drawing.Point(21, 27);
            this.dataGridTableReHis.Name = "dataGridTableReHis";
            this.dataGridTableReHis.ReadOnly = true;
            this.dataGridTableReHis.RowHeadersWidth = 51;
            this.dataGridTableReHis.RowTemplate.Height = 24;
            this.dataGridTableReHis.Size = new System.Drawing.Size(608, 395);
            this.dataGridTableReHis.TabIndex = 0;
            // 
            // frmTableReHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 429);
            this.Controls.Add(this.dataGridTableReHis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableReHis";
            this.Text = "Lịch sử đặt bàn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableReHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTableReHis;
    }
}