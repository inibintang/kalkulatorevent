namespace KalkulatorEvent
{
    partial class frmHasil
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
            this.buttKalkulator = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.Hasil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttKalkulator
            // 
            this.buttKalkulator.Location = new System.Drawing.Point(296, 375);
            this.buttKalkulator.Name = "buttKalkulator";
            this.buttKalkulator.Size = new System.Drawing.Size(112, 32);
            this.buttKalkulator.TabIndex = 1;
            this.buttKalkulator.Text = "kalkulator";
            this.buttKalkulator.UseVisualStyleBackColor = true;
            this.buttKalkulator.Click += new System.EventHandler(this.buttKalkulator_Click);
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hasil});
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(12, 40);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(688, 299);
            this.listview.TabIndex = 2;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.SelectedIndexChanged += new System.EventHandler(this.listview_SelectedIndexChanged);
            // 
            // Hasil
            // 
            this.Hasil.Text = "Hasil";
            this.Hasil.Width = 1000;
            // 
            // frmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.buttKalkulator);
            this.Name = "frmHasil";
            this.Text = "frmHasil";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttKalkulator;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader Hasil;
    }
}