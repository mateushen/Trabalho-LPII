namespace AplicacaoLP
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxMoto = new System.Windows.Forms.ComboBox();
            this.cbxPgto = new System.Windows.Forms.ComboBox();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrarVendas = new System.Windows.Forms.Button();
            this.btnAdicionarPgto = new System.Windows.Forms.Button();
            this.btnAdicionarMoto = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarVendedor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTRO DE VENDAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Método de pgto:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(394, 166);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(145, 21);
            this.cbxCliente.TabIndex = 10;
            // 
            // cbxMoto
            // 
            this.cbxMoto.FormattingEnabled = true;
            this.cbxMoto.Location = new System.Drawing.Point(394, 197);
            this.cbxMoto.Name = "cbxMoto";
            this.cbxMoto.Size = new System.Drawing.Size(145, 21);
            this.cbxMoto.TabIndex = 11;
            // 
            // cbxPgto
            // 
            this.cbxPgto.FormattingEnabled = true;
            this.cbxPgto.Location = new System.Drawing.Point(394, 228);
            this.cbxPgto.Name = "cbxPgto";
            this.cbxPgto.Size = new System.Drawing.Size(145, 21);
            this.cbxPgto.TabIndex = 12;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(261, 68);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(94, 34);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.Location = new System.Drawing.Point(361, 68);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(94, 34);
            this.btnSalvarVenda.TabIndex = 1;
            this.btnSalvarVenda.Text = "Salvar";
            this.btnSalvarVenda.UseVisualStyleBackColor = true;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarVenda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vendedor:";
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(394, 135);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(145, 21);
            this.cbxVendedor.TabIndex = 15;
            this.cbxVendedor.DropDown += new System.EventHandler(this.cbxVendedor_DropDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 68);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrarVendas
            // 
            this.btnMostrarVendas.Location = new System.Drawing.Point(445, 289);
            this.btnMostrarVendas.Name = "btnMostrarVendas";
            this.btnMostrarVendas.Size = new System.Drawing.Size(94, 34);
            this.btnMostrarVendas.TabIndex = 2;
            this.btnMostrarVendas.Text = "Mostrar vendas";
            this.btnMostrarVendas.UseVisualStyleBackColor = true;
            this.btnMostrarVendas.Click += new System.EventHandler(this.btnMostrarVendas_Click);
            // 
            // btnAdicionarPgto
            // 
            this.btnAdicionarPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPgto.Location = new System.Drawing.Point(22, 248);
            this.btnAdicionarPgto.Name = "btnAdicionarPgto";
            this.btnAdicionarPgto.Size = new System.Drawing.Size(172, 57);
            this.btnAdicionarPgto.TabIndex = 2;
            this.btnAdicionarPgto.Text = "Métodos de pagamento";
            this.btnAdicionarPgto.UseVisualStyleBackColor = false;
            this.btnAdicionarPgto.Click += new System.EventHandler(this.btnAdicionarPgto_Click);
            // 
            // btnAdicionarMoto
            // 
            this.btnAdicionarMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMoto.Location = new System.Drawing.Point(22, 180);
            this.btnAdicionarMoto.Name = "btnAdicionarMoto";
            this.btnAdicionarMoto.Size = new System.Drawing.Size(172, 57);
            this.btnAdicionarMoto.TabIndex = 1;
            this.btnAdicionarMoto.Text = "Dados de motos";
            this.btnAdicionarMoto.UseVisualStyleBackColor = false;
            this.btnAdicionarMoto.Click += new System.EventHandler(this.btnAdicionarMoto_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.Location = new System.Drawing.Point(22, 113);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(172, 57);
            this.btnAdicionarCliente.TabIndex = 0;
            this.btnAdicionarCliente.Text = "Dados de clientes";
            this.btnAdicionarCliente.UseVisualStyleBackColor = false;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAdicionarVendedor);
            this.panel1.Controls.Add(this.btnAdicionarCliente);
            this.panel1.Controls.Add(this.btnAdicionarMoto);
            this.panel1.Controls.Add(this.btnAdicionarPgto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 316);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Menu";
            // 
            // btnAdicionarVendedor
            // 
            this.btnAdicionarVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVendedor.Location = new System.Drawing.Point(22, 45);
            this.btnAdicionarVendedor.Name = "btnAdicionarVendedor";
            this.btnAdicionarVendedor.Size = new System.Drawing.Size(172, 57);
            this.btnAdicionarVendedor.TabIndex = 3;
            this.btnAdicionarVendedor.Text = "Cadastrar vendedor";
            this.btnAdicionarVendedor.UseVisualStyleBackColor = false;
            this.btnAdicionarVendedor.Click += new System.EventHandler(this.btnAdicionarVendedor_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(570, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrarVendas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.cbxPgto);
            this.Controls.Add(this.cbxMoto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxMoto;
        private System.Windows.Forms.ComboBox cbxPgto;
        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrarVendas;
        private System.Windows.Forms.Button btnAdicionarPgto;
        private System.Windows.Forms.Button btnAdicionarMoto;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarVendedor;
    }
}

