namespace poopart2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Llamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Llamar
            // 
            this.Llamar.Location = new System.Drawing.Point(327, 213);
            this.Llamar.Name = "Llamar";
            this.Llamar.Size = new System.Drawing.Size(108, 37);
            this.Llamar.TabIndex = 0;
            this.Llamar.Text = "button1";
            this.Llamar.UseVisualStyleBackColor = true;
            this.Llamar.Click += new System.EventHandler(this.Llamar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Llamar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Llamar;
    }
}