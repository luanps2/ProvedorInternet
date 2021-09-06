namespace ProvedorInternet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpVelocidade = new System.Windows.Forms.GroupBox();
            this.rb60MB = new System.Windows.Forms.RadioButton();
            this.rb30MB = new System.Windows.Forms.RadioButton();
            this.rb10MB = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkHospedagem = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpVelocidade.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Campo Grande",
            "Brasília",
            "Curitiba",
            "Manaus",
            "Porto Alegre",
            "Osasco",
            "Salvador",
            "Campinas",
            "Fortaleza"});
            this.cboCidade.Location = new System.Drawing.Point(132, 62);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(121, 21);
            this.cboCidade.TabIndex = 0;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provedor de Internet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a cidade:";
            // 
            // grpVelocidade
            // 
            this.grpVelocidade.Controls.Add(this.rb60MB);
            this.grpVelocidade.Controls.Add(this.rb30MB);
            this.grpVelocidade.Controls.Add(this.rb10MB);
            this.grpVelocidade.Location = new System.Drawing.Point(28, 93);
            this.grpVelocidade.Name = "grpVelocidade";
            this.grpVelocidade.Size = new System.Drawing.Size(225, 100);
            this.grpVelocidade.TabIndex = 3;
            this.grpVelocidade.TabStop = false;
            this.grpVelocidade.Text = "Selecione a velocidade";
            // 
            // rb60MB
            // 
            this.rb60MB.AutoSize = true;
            this.rb60MB.Location = new System.Drawing.Point(7, 66);
            this.rb60MB.Name = "rb60MB";
            this.rb60MB.Size = new System.Drawing.Size(129, 17);
            this.rb60MB.TabIndex = 0;
            this.rb60MB.TabStop = true;
            this.rb60MB.Text = "60 MBs - (+ R$ 60,00)";
            this.rb60MB.UseVisualStyleBackColor = true;
            // 
            // rb30MB
            // 
            this.rb30MB.AutoSize = true;
            this.rb30MB.Location = new System.Drawing.Point(7, 43);
            this.rb30MB.Name = "rb30MB";
            this.rb30MB.Size = new System.Drawing.Size(126, 17);
            this.rb30MB.TabIndex = 0;
            this.rb30MB.TabStop = true;
            this.rb30MB.Text = "30 MBs - (+ R$30,00)";
            this.rb30MB.UseVisualStyleBackColor = true;
            // 
            // rb10MB
            // 
            this.rb10MB.AutoSize = true;
            this.rb10MB.Location = new System.Drawing.Point(7, 20);
            this.rb10MB.Name = "rb10MB";
            this.rb10MB.Size = new System.Drawing.Size(102, 17);
            this.rb10MB.TabIndex = 0;
            this.rb10MB.TabStop = true;
            this.rb10MB.Text = "10 MBs - Básico";
            this.rb10MB.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Green;
            this.lblResultado.Location = new System.Drawing.Point(132, 263);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "R$";
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(118, 295);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 31);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(28, 200);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(157, 17);
            this.chkEmail.TabIndex = 7;
            this.chkEmail.Text = "+ Três E-mails - (+ R$10,00)";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkHospedagem
            // 
            this.chkHospedagem.AutoSize = true;
            this.chkHospedagem.Location = new System.Drawing.Point(28, 223);
            this.chkHospedagem.Name = "chkHospedagem";
            this.chkHospedagem.Size = new System.Drawing.Size(231, 17);
            this.chkHospedagem.TabIndex = 7;
            this.chkHospedagem.Text = "+ Página Pessoal Hospedada - (+ R$15,00)";
            this.chkHospedagem.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 349);
            this.Controls.Add(this.chkHospedagem);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.grpVelocidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provedor de Internet";
            this.grpVelocidade.ResumeLayout(false);
            this.grpVelocidade.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpVelocidade;
        private System.Windows.Forms.RadioButton rb60MB;
        private System.Windows.Forms.RadioButton rb30MB;
        private System.Windows.Forms.RadioButton rb10MB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkHospedagem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

