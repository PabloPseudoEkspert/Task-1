namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.Label();
            this.txtTwo = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(436, 63);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(126, 19);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "+1 to One ";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(436, 124);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(126, 19);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "+1 to Second";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // txtOne
            // 
            this.txtOne.AutoSize = true;
            this.txtOne.Location = new System.Drawing.Point(138, 68);
            this.txtOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(13, 13);
            this.txtOne.TabIndex = 2;
            this.txtOne.Text = "0";
            this.txtOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOne.Click += new System.EventHandler(this.txtOne_Click);
            // 
            // txtTwo
            // 
            this.txtTwo.AutoSize = true;
            this.txtTwo.Location = new System.Drawing.Point(140, 129);
            this.txtTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(13, 13);
            this.txtTwo.TabIndex = 3;
            this.txtTwo.Text = "0";
            this.txtTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTwo.Click += new System.EventHandler(this.txtTwo_Click);
            // 
            // txtChange
            // 
            this.txtChange.AutoSize = true;
            this.txtChange.Location = new System.Drawing.Point(262, 276);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(43, 13);
            this.txtChange.TabIndex = 4;
            this.txtChange.Text = "Buttons";
            this.txtChange.Click += new System.EventHandler(this.txtChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Label txtOne;
        private System.Windows.Forms.Label txtTwo;
        private System.Windows.Forms.Label txtChange;
    }
}

