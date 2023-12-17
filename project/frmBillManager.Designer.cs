namespace project
{
    partial class frmBillManager
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
            this.dataGridListBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListBill
            // 
            this.dataGridListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListBill.Location = new System.Drawing.Point(16, 15);
            this.dataGridListBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridListBill.Name = "dataGridListBill";
            this.dataGridListBill.RowHeadersWidth = 51;
            this.dataGridListBill.Size = new System.Drawing.Size(743, 510);
            this.dataGridListBill.TabIndex = 0;
            // 
            // frmBillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 554);
            this.Controls.Add(this.dataGridListBill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBillManager";
            this.Text = "Danh sach hoa don";
            this.Load += new System.EventHandler(this.frmBillManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListBill;
    }
}