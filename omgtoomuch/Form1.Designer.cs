namespace omgtoomuch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(8, 9);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(655, 18);
            this.bar.TabIndex = 0;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_MouseDown);
            this.bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_MouseMove);
            this.bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 9);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Close_this);
            // 
            // TT
            // 
            this.TT.Tick += new System.EventHandler(this.Check);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 33);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Omg Such Load!";
            this.Load += new System.EventHandler(this.Transparency);
            this.DoubleClick += new System.EventHandler(this.Close_this);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TT;
    }
}

