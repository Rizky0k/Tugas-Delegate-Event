
namespace TugasDelegate
{
    partial class FrmHasil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grup = new System.Windows.Forms.GroupBox();
            this.btnHasil = new System.Windows.Forms.Button();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.Grup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grup
            // 
            this.Grup.Controls.Add(this.listHasil);
            this.Grup.Location = new System.Drawing.Point(15, 12);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(318, 195);
            this.Grup.TabIndex = 0;
            this.Grup.TabStop = false;
            this.Grup.Text = "[Hasil]";
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(14, 213);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(318, 35);
            this.btnHasil.TabIndex = 1;
            this.btnHasil.Text = "Hitung";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // listHasil
            // 
            this.listHasil.FormattingEnabled = true;
            this.listHasil.ItemHeight = 15;
            this.listHasil.Location = new System.Drawing.Point(7, 23);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(305, 169);
            this.listHasil.TabIndex = 0;
            // 
            // FrmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 255);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.Grup);
            this.MaximizeBox = false;
            this.Name = "FrmHasil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.Grup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grup;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.ListBox listHasil;
    }
}

