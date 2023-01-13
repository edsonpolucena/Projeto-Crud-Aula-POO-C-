namespace Crud
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
            this.components = new System.ComponentModel.Container();
            this.Nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTtelefone = new System.Windows.Forms.TextBox();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LSTcontato = new System.Windows.Forms.ListView();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(34, 13);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(34, 75);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(61, 16);
            this.Telefone.TabIndex = 1;
            this.Telefone.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(37, 39);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(423, 22);
            this.TXTnome.TabIndex = 3;
            // 
            // TXTtelefone
            // 
            this.TXTtelefone.Location = new System.Drawing.Point(37, 102);
            this.TXTtelefone.Name = "TXTtelefone";
            this.TXTtelefone.Size = new System.Drawing.Size(423, 22);
            this.TXTtelefone.TabIndex = 4;
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(37, 166);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(423, 22);
            this.TXTemail.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LSTcontato
            // 
            this.LSTcontato.ContextMenuStrip = this.contextMenuStrip1;
            this.LSTcontato.HideSelection = false;
            this.LSTcontato.Location = new System.Drawing.Point(479, 75);
            this.LSTcontato.MultiSelect = false;
            this.LSTcontato.Name = "LSTcontato";
            this.LSTcontato.Size = new System.Drawing.Size(594, 347);
            this.LSTcontato.TabIndex = 7;
            this.LSTcontato.UseCompatibleStateImageBehavior = false;
            this.LSTcontato.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LSTcontato_ItemSelectionChanged);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(479, 39);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(497, 22);
            this.TXTbuscar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar Contato";
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.Location = new System.Drawing.Point(992, 39);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNbuscar.TabIndex = 10;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = true;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem1.Text = "Excluir Contato";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.LSTcontato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTemail);
            this.Controls.Add(this.TXTtelefone);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos C# com MySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTtelefone;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LSTcontato;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button3;
    }
}

