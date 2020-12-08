namespace KalkulatorEvent
{
    partial class formHasil
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
            this.listView = new System.Windows.Forms.ListView();
            this.kalkulator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 21);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 345);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // kalkulator
            // 
            this.kalkulator.Location = new System.Drawing.Point(280, 386);
            this.kalkulator.Name = "kalkulator";
            this.kalkulator.Size = new System.Drawing.Size(252, 36);
            this.kalkulator.TabIndex = 1;
            this.kalkulator.Text = "kalkulator";
            this.kalkulator.UseVisualStyleBackColor = true;
            this.kalkulator.Click += new System.EventHandler(this.button1_Click);
            // 
            // formHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kalkulator);
            this.Controls.Add(this.listView);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "formHasil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formHasil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button kalkulator;
    }
}

