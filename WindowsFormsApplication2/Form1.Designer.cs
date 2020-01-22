namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAjou = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btSup = new System.Windows.Forms.Button();
            this.btRech = new System.Windows.Forms.Button();
            this.textBRef = new System.Windows.Forms.TextBox();
            this.textBDes = new System.Windows.Forms.TextBox();
            this.textBPu = new System.Windows.Forms.TextBox();
            this.textBTva = new System.Windows.Forms.TextBox();
            this.comboBCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btFermer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAjou
            // 
            this.btAjou.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btAjou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjou.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjou.ForeColor = System.Drawing.Color.White;
            this.btAjou.Location = new System.Drawing.Point(596, 19);
            this.btAjou.Name = "btAjou";
            this.btAjou.Size = new System.Drawing.Size(145, 48);
            this.btAjou.TabIndex = 0;
            this.btAjou.Text = "Ajouter";
            this.btAjou.UseVisualStyleBackColor = false;
            this.btAjou.Click += new System.EventHandler(this.btAjou_Click);
            // 
            // btMod
            // 
            this.btMod.BackColor = System.Drawing.Color.Gold;
            this.btMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.ForeColor = System.Drawing.Color.White;
            this.btMod.Location = new System.Drawing.Point(596, 98);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(145, 48);
            this.btMod.TabIndex = 1;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = false;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btSup
            // 
            this.btSup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSup.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSup.ForeColor = System.Drawing.Color.White;
            this.btSup.Location = new System.Drawing.Point(596, 177);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(145, 48);
            this.btSup.TabIndex = 2;
            this.btSup.Text = "Effacer";
            this.btSup.UseVisualStyleBackColor = false;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // btRech
            // 
            this.btRech.BackColor = System.Drawing.Color.Teal;
            this.btRech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRech.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRech.ForeColor = System.Drawing.Color.White;
            this.btRech.Location = new System.Drawing.Point(596, 256);
            this.btRech.Name = "btRech";
            this.btRech.Size = new System.Drawing.Size(145, 48);
            this.btRech.TabIndex = 3;
            this.btRech.Text = "Recherche";
            this.btRech.UseVisualStyleBackColor = false;
            this.btRech.Click += new System.EventHandler(this.btRech_Click);
            // 
            // textBRef
            // 
            this.textBRef.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBRef.Location = new System.Drawing.Point(118, 19);
            this.textBRef.Multiline = true;
            this.textBRef.Name = "textBRef";
            this.textBRef.Size = new System.Drawing.Size(212, 28);
            this.textBRef.TabIndex = 4;
            this.textBRef.TextChanged += new System.EventHandler(this.textBRef_TextChanged);
            // 
            // textBDes
            // 
            this.textBDes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBDes.Location = new System.Drawing.Point(118, 85);
            this.textBDes.Multiline = true;
            this.textBDes.Name = "textBDes";
            this.textBDes.Size = new System.Drawing.Size(212, 28);
            this.textBDes.TabIndex = 5;
            // 
            // textBPu
            // 
            this.textBPu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBPu.Location = new System.Drawing.Point(118, 151);
            this.textBPu.Multiline = true;
            this.textBPu.Name = "textBPu";
            this.textBPu.Size = new System.Drawing.Size(212, 28);
            this.textBPu.TabIndex = 6;
            // 
            // textBTva
            // 
            this.textBTva.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBTva.Location = new System.Drawing.Point(118, 279);
            this.textBTva.Multiline = true;
            this.textBTva.Name = "textBTva";
            this.textBTva.Size = new System.Drawing.Size(212, 28);
            this.textBTva.TabIndex = 7;
            // 
            // comboBCat
            // 
            this.comboBCat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBCat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBCat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBCat.FormattingEnabled = true;
            this.comboBCat.Location = new System.Drawing.Point(118, 217);
            this.comboBCat.Name = "comboBCat";
            this.comboBCat.Size = new System.Drawing.Size(212, 24);
            this.comboBCat.TabIndex = 8;
            this.comboBCat.SelectedIndexChanged += new System.EventHandler(this.comboBCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Référence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Désignation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prix unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Catégorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(6, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "TVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(336, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBCat);
            this.panel2.Controls.Add(this.textBTva);
            this.panel2.Controls.Add(this.textBPu);
            this.panel2.Controls.Add(this.textBDes);
            this.panel2.Controls.Add(this.textBRef);
            this.panel2.Controls.Add(this.btRech);
            this.panel2.Controls.Add(this.btSup);
            this.panel2.Controls.Add(this.btMod);
            this.panel2.Controls.Add(this.btAjou);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(4, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 375);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btFermer
            // 
            this.btFermer.BackColor = System.Drawing.Color.Red;
            this.btFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFermer.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFermer.ForeColor = System.Drawing.Color.White;
            this.btFermer.Location = new System.Drawing.Point(746, -1);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(34, 34);
            this.btFermer.TabIndex = 17;
            this.btFermer.Text = "x";
            this.btFermer.UseVisualStyleBackColor = false;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAjou;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btRech;
        private System.Windows.Forms.TextBox textBRef;
        private System.Windows.Forms.TextBox textBDes;
        private System.Windows.Forms.TextBox textBPu;
        private System.Windows.Forms.TextBox textBTva;
        private System.Windows.Forms.ComboBox comboBCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFermer;
    }
}

