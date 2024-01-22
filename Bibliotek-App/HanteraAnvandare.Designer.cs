namespace Bibliotek_App
{
    partial class HanteraAnvandare
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
            this.AnvandarLista = new System.Windows.Forms.ComboBox();
            this.NamnFält = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NamnFalt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MobilFalt = new System.Windows.Forms.TextBox();
            this.PersonnummerFalt = new System.Windows.Forms.TextBox();
            this.RegistreraAnvandarebtn = new System.Windows.Forms.Button();
            this.bakåtbtn = new System.Windows.Forms.Button();
            this.InfoAnvandare = new System.Windows.Forms.TextBox();
            this.Mobilnummer = new System.Windows.Forms.TextBox();
            this.Namn = new System.Windows.Forms.TextBox();
            this.Personnummer = new System.Windows.Forms.TextBox();
            this.Avregistreraanv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnvandarLista
            // 
            this.AnvandarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnvandarLista.FormattingEnabled = true;
            this.AnvandarLista.Location = new System.Drawing.Point(300, 49);
            this.AnvandarLista.Name = "AnvandarLista";
            this.AnvandarLista.Size = new System.Drawing.Size(184, 28);
            this.AnvandarLista.TabIndex = 8;
            this.AnvandarLista.Text = "Användare";
            this.AnvandarLista.SelectedIndexChanged += new System.EventHandler(this.AnvandarLista_SelectedIndexChanged);
            // 
            // NamnFält
            // 
            this.NamnFält.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamnFält.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamnFält.Location = new System.Drawing.Point(58, 49);
            this.NamnFält.Multiline = true;
            this.NamnFält.Name = "NamnFält";
            this.NamnFält.ReadOnly = true;
            this.NamnFält.Size = new System.Drawing.Size(184, 28);
            this.NamnFält.TabIndex = 5;
            this.NamnFält.Text = "Fullständigt namn:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(58, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Mobiltelefon:";
            // 
            // NamnFalt
            // 
            this.NamnFalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamnFalt.Location = new System.Drawing.Point(58, 95);
            this.NamnFalt.Name = "NamnFalt";
            this.NamnFalt.Size = new System.Drawing.Size(184, 26);
            this.NamnFalt.TabIndex = 0;
            this.NamnFalt.TextChanged += new System.EventHandler(this.NamnFalt_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(58, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(184, 19);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Personnummer:";
            // 
            // MobilFalt
            // 
            this.MobilFalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobilFalt.Location = new System.Drawing.Point(58, 292);
            this.MobilFalt.Name = "MobilFalt";
            this.MobilFalt.Size = new System.Drawing.Size(184, 26);
            this.MobilFalt.TabIndex = 2;
            // 
            // PersonnummerFalt
            // 
            this.PersonnummerFalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnummerFalt.Location = new System.Drawing.Point(58, 189);
            this.PersonnummerFalt.Name = "PersonnummerFalt";
            this.PersonnummerFalt.Size = new System.Drawing.Size(184, 26);
            this.PersonnummerFalt.TabIndex = 1;
            // 
            // RegistreraAnvandarebtn
            // 
            this.RegistreraAnvandarebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistreraAnvandarebtn.Location = new System.Drawing.Point(58, 345);
            this.RegistreraAnvandarebtn.Name = "RegistreraAnvandarebtn";
            this.RegistreraAnvandarebtn.Size = new System.Drawing.Size(184, 43);
            this.RegistreraAnvandarebtn.TabIndex = 3;
            this.RegistreraAnvandarebtn.Text = "Registrera Användare";
            this.RegistreraAnvandarebtn.UseVisualStyleBackColor = true;
            this.RegistreraAnvandarebtn.Click += new System.EventHandler(this.RegistreraAnvandarebtn_Click);
            // 
            // bakåtbtn
            // 
            this.bakåtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakåtbtn.Location = new System.Drawing.Point(12, 449);
            this.bakåtbtn.Name = "bakåtbtn";
            this.bakåtbtn.Size = new System.Drawing.Size(105, 28);
            this.bakåtbtn.TabIndex = 4;
            this.bakåtbtn.Text = "<--Bakåt";
            this.bakåtbtn.UseVisualStyleBackColor = true;
            this.bakåtbtn.Click += new System.EventHandler(this.bakåtbtn_Click);
            // 
            // InfoAnvandare
            // 
            this.InfoAnvandare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoAnvandare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoAnvandare.Location = new System.Drawing.Point(300, 219);
            this.InfoAnvandare.Multiline = true;
            this.InfoAnvandare.Name = "InfoAnvandare";
            this.InfoAnvandare.ReadOnly = true;
            this.InfoAnvandare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoAnvandare.Size = new System.Drawing.Size(289, 169);
            this.InfoAnvandare.TabIndex = 9;
            // 
            // Mobilnummer
            // 
            this.Mobilnummer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Mobilnummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobilnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobilnummer.Location = new System.Drawing.Point(300, 189);
            this.Mobilnummer.Name = "Mobilnummer";
            this.Mobilnummer.ReadOnly = true;
            this.Mobilnummer.Size = new System.Drawing.Size(184, 19);
            this.Mobilnummer.TabIndex = 10;
            // 
            // Namn
            // 
            this.Namn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Namn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Namn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namn.Location = new System.Drawing.Point(300, 102);
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            this.Namn.Size = new System.Drawing.Size(184, 19);
            this.Namn.TabIndex = 11;
            // 
            // Personnummer
            // 
            this.Personnummer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Personnummer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Personnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personnummer.Location = new System.Drawing.Point(300, 144);
            this.Personnummer.Name = "Personnummer";
            this.Personnummer.ReadOnly = true;
            this.Personnummer.Size = new System.Drawing.Size(184, 19);
            this.Personnummer.TabIndex = 12;
            // 
            // Avregistreraanv
            // 
            this.Avregistreraanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avregistreraanv.Location = new System.Drawing.Point(490, 49);
            this.Avregistreraanv.Name = "Avregistreraanv";
            this.Avregistreraanv.Size = new System.Drawing.Size(99, 28);
            this.Avregistreraanv.TabIndex = 13;
            this.Avregistreraanv.Text = "Avregistrera";
            this.Avregistreraanv.UseVisualStyleBackColor = true;
            this.Avregistreraanv.Click += new System.EventHandler(this.Avregistreraanv_Click);
            // 
            // HanteraAnvandare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 489);
            this.Controls.Add(this.Avregistreraanv);
            this.Controls.Add(this.Personnummer);
            this.Controls.Add(this.Namn);
            this.Controls.Add(this.Mobilnummer);
            this.Controls.Add(this.InfoAnvandare);
            this.Controls.Add(this.bakåtbtn);
            this.Controls.Add(this.RegistreraAnvandarebtn);
            this.Controls.Add(this.PersonnummerFalt);
            this.Controls.Add(this.MobilFalt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.NamnFalt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NamnFält);
            this.Controls.Add(this.AnvandarLista);
            this.Name = "HanteraAnvandare";
            this.Text = "HanteraAnvandare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AnvandarLista;
        private System.Windows.Forms.TextBox NamnFält;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NamnFalt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox MobilFalt;
        private System.Windows.Forms.TextBox PersonnummerFalt;
        private System.Windows.Forms.Button RegistreraAnvandarebtn;
        private System.Windows.Forms.Button bakåtbtn;
        private System.Windows.Forms.TextBox InfoAnvandare;
        private System.Windows.Forms.TextBox Mobilnummer;
        private System.Windows.Forms.TextBox Namn;
        private System.Windows.Forms.TextBox Personnummer;
        private System.Windows.Forms.Button Avregistreraanv;
    }
}