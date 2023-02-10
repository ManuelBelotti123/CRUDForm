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
            this.StampaArr.Location = new System.Drawing.Point(30, 183);
            this.StampaArr.Name = "StampaArr";
            this.StampaArr.Size = new System.Drawing.Size(215, 23);
            this.StampaArr.TabIndex = 4;
            this.StampaArr.Text = "Stampa dell\'array";
            this.StampaArr.UseVisualStyleBackColor = true;
            // 
            // CancElem
            // 
            this.CancElem.Location = new System.Drawing.Point(30, 120);
            this.CancElem.Name = "CancElem";
            this.CancElem.Size = new System.Drawing.Size(215, 23);
            this.CancElem.TabIndex = 5;
            this.CancElem.Text = "Cancella un elemento";
            this.CancElem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestione di un array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

