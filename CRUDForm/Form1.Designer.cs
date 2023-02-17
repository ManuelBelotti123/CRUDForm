namespace CRUDForm
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.liststampa = new System.Windows.Forms.ListView();
            this.AggButton = new System.Windows.Forms.Button();
            this.StampaArr = new System.Windows.Forms.Button();
            this.CancElem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ModificaElem = new System.Windows.Forms.Button();
            this.InputMod = new System.Windows.Forms.TextBox();
            this.LabelMod = new System.Windows.Forms.Label();
            this.InvioMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(30, 56);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(215, 20);
            this.Input.TabIndex = 1;
            // 
            // liststampa
            // 
            this.liststampa.HideSelection = false;
            this.liststampa.Location = new System.Drawing.Point(465, 27);
            this.liststampa.Name = "liststampa";
            this.liststampa.Size = new System.Drawing.Size(304, 382);
            this.liststampa.TabIndex = 2;
            this.liststampa.UseCompatibleStateImageBehavior = false;
            this.liststampa.View = System.Windows.Forms.View.List;
            // 
            // AggButton
            // 
            this.AggButton.Location = new System.Drawing.Point(30, 91);
            this.AggButton.Name = "AggButton";
            this.AggButton.Size = new System.Drawing.Size(215, 23);
            this.AggButton.TabIndex = 3;
            this.AggButton.Text = "Aggiungi un elemento";
            this.AggButton.UseVisualStyleBackColor = true;
            this.AggButton.Click += new System.EventHandler(this.AggButton_Click);
            // 
            // StampaArr
            // 
            this.StampaArr.Location = new System.Drawing.Point(30, 178);
            this.StampaArr.Name = "StampaArr";
            this.StampaArr.Size = new System.Drawing.Size(215, 23);
            this.StampaArr.TabIndex = 4;
            this.StampaArr.Text = "Stampa dell\'array";
            this.StampaArr.UseVisualStyleBackColor = true;
            this.StampaArr.Click += new System.EventHandler(this.StampaArr_Click);
            // 
            // CancElem
            // 
            this.CancElem.Location = new System.Drawing.Point(30, 120);
            this.CancElem.Name = "CancElem";
            this.CancElem.Size = new System.Drawing.Size(215, 23);
            this.CancElem.TabIndex = 5;
            this.CancElem.Text = "Cancella un elemento";
            this.CancElem.UseVisualStyleBackColor = true;
            this.CancElem.Click += new System.EventHandler(this.CancElem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestione di un array";
            // 
            // ModificaElem
            // 
            this.ModificaElem.Location = new System.Drawing.Point(30, 149);
            this.ModificaElem.Name = "ModificaElem";
            this.ModificaElem.Size = new System.Drawing.Size(215, 23);
            this.ModificaElem.TabIndex = 7;
            this.ModificaElem.Text = "Modifica un elemento";
            this.ModificaElem.UseVisualStyleBackColor = true;
            this.ModificaElem.Click += new System.EventHandler(this.ModificaElem_Click);
            // 
            // InputMod
            // 
            this.InputMod.Location = new System.Drawing.Point(30, 248);
            this.InputMod.Name = "InputMod";
            this.InputMod.Size = new System.Drawing.Size(215, 20);
            this.InputMod.TabIndex = 8;
            // 
            // LabelMod
            // 
            this.LabelMod.AutoSize = true;
            this.LabelMod.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMod.Location = new System.Drawing.Point(26, 221);
            this.LabelMod.Name = "LabelMod";
            this.LabelMod.Size = new System.Drawing.Size(183, 24);
            this.LabelMod.TabIndex = 9;
            this.LabelMod.Text = "Inserire la modifica";
            // 
            // InvioMod
            // 
            this.InvioMod.Location = new System.Drawing.Point(30, 274);
            this.InvioMod.Name = "InvioMod";
            this.InvioMod.Size = new System.Drawing.Size(215, 23);
            this.InvioMod.TabIndex = 10;
            this.InvioMod.Text = "Invio";
            this.InvioMod.UseVisualStyleBackColor = true;
            this.InvioMod.Click += new System.EventHandler(this.InvioMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvioMod);
            this.Controls.Add(this.LabelMod);
            this.Controls.Add(this.InputMod);
            this.Controls.Add(this.ModificaElem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancElem);
            this.Controls.Add(this.StampaArr);
            this.Controls.Add(this.AggButton);
            this.Controls.Add(this.liststampa);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.ListView liststampa;
        private System.Windows.Forms.Button AggButton;
        private System.Windows.Forms.Button StampaArr;
        private System.Windows.Forms.Button CancElem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModificaElem;
        private System.Windows.Forms.TextBox InputMod;
        private System.Windows.Forms.Label LabelMod;
        private System.Windows.Forms.Button InvioMod;
    }
}

