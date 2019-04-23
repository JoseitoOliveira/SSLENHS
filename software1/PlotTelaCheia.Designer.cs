namespace software1 {
    partial class PlotTelaCheia {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grafico1 = new software1.grafico();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            this.grafico1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grafico1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafico1.Location = new System.Drawing.Point(0, 0);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(800, 450);
            this.grafico1.TabIndex = 0;
            // 
            // PlotTelaCheia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grafico1);
            this.Name = "PlotTelaCheia";
            this.Text = "PlotTelaCheia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private grafico grafico1;
    }
}