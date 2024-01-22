namespace Bibliotek_App
{
    partial class Lanabok
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
            this.bokdropdn = new System.Windows.Forms.ComboBox();
            this.lanabokBtn = new System.Windows.Forms.Button();
            this.bakåtbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // användaredropdn
            // 
            this.användaredropdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.användaredropdn.FormattingEnabled = true;
            this.användaredropdn.Location = new System.Drawing.Point(30, 37);
            this.användaredropdn.Name = "användaredropdn";
            this.användaredropdn.Size = new System.Drawing.Size(194, 32);
            this.användaredropdn.TabIndex = 0;
            this.användaredropdn.Text = "Användare";
            this.användaredropdn.SelectedIndexChanged += new System.EventHandler(this.användaredropdn_SelectedIndexChanged);
            // 
            // bokdropdn
            // 
            this.bokdropdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bokdropdn.FormattingEnabled = true;
            this.bokdropdn.Location = new System.Drawing.Point(251, 37);
            this.bokdropdn.Name = "bokdropdn";
            this.bokdropdn.Size = new System.Drawing.Size(194, 32);
            this.bokdropdn.TabIndex = 1;
            this.bokdropdn.Text = "Böcker";
            this.bokdropdn.SelectedIndexChanged += new System.EventHandler(this.bokdropdn_SelectedIndexChanged);
            // 
            // lanabokBtn
            // 
            this.lanabokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanabokBtn.Location = new System.Drawing.Point(461, 37);
            this.lanabokBtn.Name = "lanabokBtn";
            this.lanabokBtn.Size = new System.Drawing.Size(92, 32);
            this.lanabokBtn.TabIndex = 2;
            this.lanabokBtn.Text = "Låna bok";
            this.lanabokBtn.UseVisualStyleBackColor = true;
            this.lanabokBtn.Click += new System.EventHandler(this.lanabokBtn_Click);
            // 
            // bakåtbtn
            // 
            this.bakåtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakåtbtn.Location = new System.Drawing.Point(13, 494);
            this.bakåtbtn.Name = "bakåtbtn";
            this.bakåtbtn.Size = new System.Drawing.Size(105, 28);
            this.bakåtbtn.TabIndex = 3;
            this.bakåtbtn.Text = "<--Bakåt";
            this.bakåtbtn.UseVisualStyleBackColor = true;
            this.bakåtbtn.Click += new System.EventHandler(this.bakåtbtn_Click);
            // 
            // Lanabok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 534);
            this.Controls.Add(this.bakåtbtn);
            this.Controls.Add(this.lanabokBtn);
            this.Controls.Add(this.bokdropdn);
            this.Controls.Add(this.användaredropdn);
            this.Name = "Lanabok";
            this.Text = "Lanabok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox användaredropdn;
        private System.Windows.Forms.ComboBox bokdropdn;
        private System.Windows.Forms.Button lanabokBtn;
        private System.Windows.Forms.Button bakåtbtn;
    }
}