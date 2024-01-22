namespace Bibliotek_App
{
    partial class LamnaTillbakaBok
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
            this.användaredropdn = new System.Windows.Forms.ComboBox();
            this.bakåtbtn = new System.Windows.Forms.Button();
            this.bokdropdn = new System.Windows.Forms.ComboBox();
            this.återlämning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // användaredropdn
            // 
            this.användaredropdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.användaredropdn.FormattingEnabled = true;
            this.användaredropdn.Location = new System.Drawing.Point(173, 65);
            this.användaredropdn.Name = "användaredropdn";
            this.användaredropdn.Size = new System.Drawing.Size(184, 28);
            this.användaredropdn.TabIndex = 1;
            this.användaredropdn.Text = "Användare";
            this.användaredropdn.SelectedIndexChanged += new System.EventHandler(this.användaredropdn_SelectedIndexChanged);
            // 
            // bakåtbtn
            // 
            this.bakåtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakåtbtn.Location = new System.Drawing.Point(22, 400);
            this.bakåtbtn.Name = "bakåtbtn";
            this.bakåtbtn.Size = new System.Drawing.Size(105, 28);
            this.bakåtbtn.TabIndex = 9;
            this.bakåtbtn.Text = "<--Bakåt";
            this.bakåtbtn.UseVisualStyleBackColor = true;
            this.bakåtbtn.Click += new System.EventHandler(this.bakåtbtn_Click);
            // 
            // bokdropdn
            // 
            this.bokdropdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bokdropdn.FormattingEnabled = true;
            this.bokdropdn.Location = new System.Drawing.Point(440, 65);
            this.bokdropdn.Name = "bokdropdn";
            this.bokdropdn.Size = new System.Drawing.Size(184, 28);
            this.bokdropdn.TabIndex = 10;
            this.bokdropdn.Text = "Böcker";
            // 
            // återlämning
            // 
            this.återlämning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.återlämning.Location = new System.Drawing.Point(346, 154);
            this.återlämning.Name = "återlämning";
            this.återlämning.Size = new System.Drawing.Size(105, 39);
            this.återlämning.TabIndex = 11;
            this.återlämning.Text = "Återlämning";
            this.återlämning.UseVisualStyleBackColor = true;
            this.återlämning.Click += new System.EventHandler(this.återlämning_Click);
            // 
            // LamnaTillbakaBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.återlämning);
            this.Controls.Add(this.bokdropdn);
            this.Controls.Add(this.bakåtbtn);
            this.Controls.Add(this.användaredropdn);
            this.Name = "LamnaTillbakaBok";
            this.Text = "LamnaTillbakaBok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox användaredropdn;
        private System.Windows.Forms.Button bakåtbtn;
        private System.Windows.Forms.ComboBox bokdropdn;
        private System.Windows.Forms.Button återlämning;
    }
}