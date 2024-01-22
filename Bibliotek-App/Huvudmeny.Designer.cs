namespace Bibliotek_App
{
    partial class Huvudmeny
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
            this.RegistreraBok = new System.Windows.Forms.Button();
            this.HanteraAnvändare = new System.Windows.Forms.Button();
            this.LånaBok = new System.Windows.Forms.Button();
            this.LämnaTillbakaBok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistreraBok
            // 
            this.RegistreraBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistreraBok.Location = new System.Drawing.Point(110, 76);
            this.RegistreraBok.Name = "RegistreraBok";
            this.RegistreraBok.Size = new System.Drawing.Size(340, 80);
            this.RegistreraBok.TabIndex = 0;
            this.RegistreraBok.Text = "Hantera Böcker";
            this.RegistreraBok.UseVisualStyleBackColor = true;
            this.RegistreraBok.Click += new System.EventHandler(this.RegistreraBok_Click);
            // 
            // HanteraAnvändare
            // 
            this.HanteraAnvändare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HanteraAnvändare.Location = new System.Drawing.Point(110, 201);
            this.HanteraAnvändare.Name = "HanteraAnvändare";
            this.HanteraAnvändare.Size = new System.Drawing.Size(340, 80);
            this.HanteraAnvändare.TabIndex = 0;
            this.HanteraAnvändare.Text = "Hantera Användare";
            this.HanteraAnvändare.UseVisualStyleBackColor = true;
            this.HanteraAnvändare.Click += new System.EventHandler(this.HanteraAnvändare_Click);
            // 
            // LånaBok
            // 
            this.LånaBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LånaBok.Location = new System.Drawing.Point(110, 324);
            this.LånaBok.Name = "LånaBok";
            this.LånaBok.Size = new System.Drawing.Size(340, 80);
            this.LånaBok.TabIndex = 0;
            this.LånaBok.Text = "Låna Bok";
            this.LånaBok.UseVisualStyleBackColor = true;
            this.LånaBok.Click += new System.EventHandler(this.LånaBok_Click);
            // 
            // LämnaTillbakaBok
            // 
            this.LämnaTillbakaBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LämnaTillbakaBok.Location = new System.Drawing.Point(110, 454);
            this.LämnaTillbakaBok.Name = "LämnaTillbakaBok";
            this.LämnaTillbakaBok.Size = new System.Drawing.Size(340, 80);
            this.LämnaTillbakaBok.TabIndex = 0;
            this.LämnaTillbakaBok.Text = "Lämna Tillbaka Bok";
            this.LämnaTillbakaBok.UseVisualStyleBackColor = true;
            this.LämnaTillbakaBok.Click += new System.EventHandler(this.LämnaTillbakaBok_Click);
            // 
            // Huvudmeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 682);
            this.Controls.Add(this.LämnaTillbakaBok);
            this.Controls.Add(this.LånaBok);
            this.Controls.Add(this.HanteraAnvändare);
            this.Controls.Add(this.RegistreraBok);
            this.Name = "Huvudmeny";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistreraBok;
        private System.Windows.Forms.Button HanteraAnvändare;
        private System.Windows.Forms.Button LånaBok;
        private System.Windows.Forms.Button LämnaTillbakaBok;
    }
}

