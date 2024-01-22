namespace Bibliotek_App
{
    partial class RegistreraBok
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
            this.titelFält = new System.Windows.Forms.TextBox();
            this.författarFält = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bakåtbtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bokdropdn = new System.Windows.Forms.ComboBox();
            this.avregistrerabok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titelFält
            // 
            this.titelFält.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelFält.Location = new System.Drawing.Point(106, 122);
            this.titelFält.Name = "titelFält";
            this.titelFält.Size = new System.Drawing.Size(197, 26);
            this.titelFält.TabIndex = 0;
            this.titelFält.Tag = "";
            // 
            // författarFält
            // 
            this.författarFält.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.författarFält.Location = new System.Drawing.Point(106, 198);
            this.författarFält.Name = "författarFält";
            this.författarFält.Size = new System.Drawing.Size(197, 26);
            this.författarFält.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrera Bok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(156, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Boktitel";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(156, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 19);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Författare";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bakåtbtn
            // 
            this.bakåtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakåtbtn.Location = new System.Drawing.Point(12, 568);
            this.bakåtbtn.Name = "bakåtbtn";
            this.bakåtbtn.Size = new System.Drawing.Size(105, 28);
            this.bakåtbtn.TabIndex = 4;
            this.bakåtbtn.Text = "<--Bakåt";
            this.bakåtbtn.UseVisualStyleBackColor = true;
            this.bakåtbtn.Click += new System.EventHandler(this.bakåtbtn_Click);
            // 
            // bokdropdn
            // 
            this.bokdropdn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bokdropdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bokdropdn.FormattingEnabled = true;
            this.bokdropdn.Location = new System.Drawing.Point(106, 364);
            this.bokdropdn.Name = "bokdropdn";
            this.bokdropdn.Size = new System.Drawing.Size(197, 28);
            this.bokdropdn.TabIndex = 5;
            // 
            // avregistrerabok
            // 
            this.avregistrerabok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avregistrerabok.Location = new System.Drawing.Point(141, 408);
            this.avregistrerabok.Name = "avregistrerabok";
            this.avregistrerabok.Size = new System.Drawing.Size(131, 31);
            this.avregistrerabok.TabIndex = 6;
            this.avregistrerabok.Text = "Avregistrera Bok";
            this.avregistrerabok.UseVisualStyleBackColor = true;
            this.avregistrerabok.Click += new System.EventHandler(this.avregistrerabok_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Registrera Bok";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(124, 315);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 24);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Avregistrera Bok";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegistreraBok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 634);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.avregistrerabok);
            this.Controls.Add(this.bokdropdn);
            this.Controls.Add(this.bakåtbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.författarFält);
            this.Controls.Add(this.titelFält);
            this.Name = "RegistreraBok";
            this.Text = "RegistreraBok";
            this.Load += new System.EventHandler(this.RegistreraBok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titelFält;
        private System.Windows.Forms.TextBox författarFält;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bakåtbtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox bokdropdn;
        private System.Windows.Forms.Button avregistrerabok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}