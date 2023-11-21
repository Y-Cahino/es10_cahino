namespace es10_cahino
{
    partial class UserControl1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.chkCard = new System.Windows.Forms.CheckBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.code1 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(71, 342);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calcola";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // chkCard
            // 
            this.chkCard.AutoSize = true;
            this.chkCard.Location = new System.Drawing.Point(71, 389);
            this.chkCard.Name = "chkCard";
            this.chkCard.Size = new System.Drawing.Size(89, 17);
            this.chkCard.TabIndex = 1;
            this.chkCard.Text = "Carta Fedeltà";
            this.chkCard.UseVisualStyleBackColor = true;
            this.chkCard.CheckedChanged += new System.EventHandler(this.chkCard_CheckedChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(71, 132);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(230, 176);
            this.desc.TabIndex = 2;
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // code1
            // 
            this.code1.Location = new System.Drawing.Point(71, 85);
            this.code1.Name = "code1";
            this.code1.Size = new System.Drawing.Size(100, 20);
            this.code1.TabIndex = 3;
            this.code1.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(201, 85);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 4;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(167, 341);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Aggiungi Articolo";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add);
            this.Controls.Add(this.price);
            this.Controls.Add(this.code1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.chkCard);
            this.Controls.Add(this.calculate);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.CheckBox chkCard;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox code1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button add;
    }
}
