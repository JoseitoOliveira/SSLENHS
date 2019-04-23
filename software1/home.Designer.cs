namespace software1 {
    partial class home {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogout = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPesquisaArquivo = new System.Windows.Forms.PictureBox();
            this.btnPesquisaDB = new System.Windows.Forms.PictureBox();
            this.btnGraficos = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.painelGraficos = new System.Windows.Forms.FlowLayoutPanel();
            this.grafico1 = new software1.grafico();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisaArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGraficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            this.painelGraficos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.imgLogout);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblPermissao);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 701);
            this.panel1.TabIndex = 1;
            // 
            // imgLogout
            // 
            this.imgLogout.Image = ((System.Drawing.Image)(resources.GetObject("imgLogout.Image")));
            this.imgLogout.Location = new System.Drawing.Point(204, 652);
            this.imgLogout.Name = "imgLogout";
            this.imgLogout.Size = new System.Drawing.Size(41, 40);
            this.imgLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogout.TabIndex = 8;
            this.imgLogout.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLogout.Location = new System.Drawing.Point(121, 668);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(82, 24);
            this.lblLogout.TabIndex = 7;
            this.lblLogout.Text = "Logout";
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPermissao.Location = new System.Drawing.Point(19, 585);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(75, 24);
            this.lblPermissao.TabIndex = 6;
            this.lblPermissao.Text = "Status";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUser.Location = new System.Drawing.Point(19, 559);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(56, 24);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel4.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel4.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel4.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 498);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel4.Size = new System.Drawing.Size(239, 48);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(197, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(148, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(95, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnPesquisaArquivo);
            this.flowLayoutPanel3.Controls.Add(this.btnPesquisaDB);
            this.flowLayoutPanel3.Controls.Add(this.btnGraficos);
            this.flowLayoutPanel3.Controls.Add(this.btnUsers);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(239, 110);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btnPesquisaArquivo
            // 
            this.btnPesquisaArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaArquivo.Image")));
            this.btnPesquisaArquivo.Location = new System.Drawing.Point(2, 2);
            this.btnPesquisaArquivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisaArquivo.Name = "btnPesquisaArquivo";
            this.btnPesquisaArquivo.Size = new System.Drawing.Size(53, 50);
            this.btnPesquisaArquivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPesquisaArquivo.TabIndex = 1;
            this.btnPesquisaArquivo.TabStop = false;
            // 
            // btnPesquisaDB
            // 
            this.btnPesquisaDB.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaDB.Image")));
            this.btnPesquisaDB.Location = new System.Drawing.Point(59, 2);
            this.btnPesquisaDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisaDB.Name = "btnPesquisaDB";
            this.btnPesquisaDB.Size = new System.Drawing.Size(68, 50);
            this.btnPesquisaDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPesquisaDB.TabIndex = 2;
            this.btnPesquisaDB.TabStop = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Image = ((System.Drawing.Image)(resources.GetObject("btnGraficos.Image")));
            this.btnGraficos.Location = new System.Drawing.Point(131, 2);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(53, 50);
            this.btnGraficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGraficos.TabIndex = 3;
            this.btnGraficos.TabStop = false;
            // 
            // btnUsers
            // 
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(188, 2);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(43, 50);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUsers.TabIndex = 4;
            this.btnUsers.TabStop = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 134);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(239, 364);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // painelGraficos
            // 
            this.painelGraficos.BackColor = System.Drawing.Color.Silver;
            this.painelGraficos.Controls.Add(this.grafico1);
            this.painelGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelGraficos.Location = new System.Drawing.Point(260, 0);
            this.painelGraficos.Name = "painelGraficos";
            this.painelGraficos.Padding = new System.Windows.Forms.Padding(5);
            this.painelGraficos.Size = new System.Drawing.Size(868, 701);
            this.painelGraficos.TabIndex = 2;
            // 
            // grafico1
            // 
            this.grafico1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grafico1.Location = new System.Drawing.Point(8, 8);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(282, 237);
            this.grafico1.TabIndex = 0;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1128, 701);
            this.Controls.Add(this.painelGraficos);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "SSLENS - Tela inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisaArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGraficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            this.painelGraficos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel painelGraficos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox btnPesquisaArquivo;
        private System.Windows.Forms.PictureBox btnPesquisaDB;
        private System.Windows.Forms.PictureBox btnGraficos;
        private System.Windows.Forms.PictureBox btnUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox imgLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblPermissao;
        private grafico grafico1;
    }
}

