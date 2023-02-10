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
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(30, 48);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(103, 20);
            this.Input.TabIndex = 1;
            // 
            // liststampa
            // 
            this.liststampa.HideSelection = false;
            this.liststampa.Location = new System.Drawing.Point(449, 12);
            this.liststampa.Name = "liststampa";
            this.liststampa.Size = new System.Drawing.Size(339, 426);
            this.liststampa.TabIndex = 2;
            this.liststampa.UseCompatibleStateImageBehavior = false;
            this.liststampa.View = System.Windows.Forms.View.List;
            // 
            // AggButton
            // 
            this.AggButton.Location = new System.Drawing.Point(30, 103);
            this.AggButton.Name = "AggButton";
            this.AggButton.Size = new System.Drawing.Size(133, 23);
            this.AggButton.TabIndex = 3;
            this.AggButton.Text = "Aggiungi un elemento";
            this.AggButton.UseVisualStyleBackColor = true;
            this.AggButton.Click += new System.EventHandler(this.AggButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

