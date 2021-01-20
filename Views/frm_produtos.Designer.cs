namespace SS_Almoxarifado.Views
{
    partial class frm_produtos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_novoProduto = new System.Windows.Forms.Button();
            this.btn_editarProduto = new System.Windows.Forms.Button();
            this.btn_excluirProduto = new System.Windows.Forms.Button();
            this.btn_imprimirProduto = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_buscarImagem = new System.Windows.Forms.Button();
            this.btn_salvarImagem = new System.Windows.Forms.Button();
            this.btn_excluirImagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_qtdProdutos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_imagemProduto = new System.Windows.Forms.PictureBox();
            this.img_qrCodeProduto = new System.Windows.Forms.PictureBox();
            this.lvw_listaProdutos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_setor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_subCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_unidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_disponivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_bloqueado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qrCodeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btn_novoProduto);
            this.panel1.Controls.Add(this.btn_editarProduto);
            this.panel1.Controls.Add(this.btn_excluirProduto);
            this.panel1.Controls.Add(this.btn_imprimirProduto);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_buscarImagem);
            this.panel1.Controls.Add(this.btn_salvarImagem);
            this.panel1.Controls.Add(this.btn_excluirImagem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_qtdProdutos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.img_imagemProduto);
            this.panel1.Controls.Add(this.img_qrCodeProduto);
            this.panel1.Controls.Add(this.lvw_listaProdutos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 729);
            this.panel1.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(255, 194);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 20);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Categoria";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(187, 194);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Setor";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(119, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nome";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(43, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Código";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // btn_novoProduto
            // 
            this.btn_novoProduto.BackColor = System.Drawing.Color.White;
            this.btn_novoProduto.Image = global::SS_Almoxarifado.Properties.Resources.add_icon;
            this.btn_novoProduto.Location = new System.Drawing.Point(43, 111);
            this.btn_novoProduto.Name = "btn_novoProduto";
            this.btn_novoProduto.Size = new System.Drawing.Size(50, 44);
            this.btn_novoProduto.TabIndex = 4;
            this.btn_novoProduto.Tag = "";
            this.btn_novoProduto.UseVisualStyleBackColor = false;
            this.btn_novoProduto.Click += new System.EventHandler(this.Btn_novoProduto_Click);
            // 
            // btn_editarProduto
            // 
            this.btn_editarProduto.BackColor = System.Drawing.Color.White;
            this.btn_editarProduto.Image = global::SS_Almoxarifado.Properties.Resources.Text_Edit_icon;
            this.btn_editarProduto.Location = new System.Drawing.Point(96, 111);
            this.btn_editarProduto.Name = "btn_editarProduto";
            this.btn_editarProduto.Size = new System.Drawing.Size(50, 44);
            this.btn_editarProduto.TabIndex = 4;
            this.btn_editarProduto.Tag = "";
            this.btn_editarProduto.UseVisualStyleBackColor = false;
            // 
            // btn_excluirProduto
            // 
            this.btn_excluirProduto.BackColor = System.Drawing.Color.White;
            this.btn_excluirProduto.Image = global::SS_Almoxarifado.Properties.Resources.Actions_trash_empty_icon;
            this.btn_excluirProduto.Location = new System.Drawing.Point(149, 111);
            this.btn_excluirProduto.Name = "btn_excluirProduto";
            this.btn_excluirProduto.Size = new System.Drawing.Size(50, 44);
            this.btn_excluirProduto.TabIndex = 4;
            this.btn_excluirProduto.Tag = "";
            this.btn_excluirProduto.UseVisualStyleBackColor = false;
            // 
            // btn_imprimirProduto
            // 
            this.btn_imprimirProduto.BackColor = System.Drawing.Color.White;
            this.btn_imprimirProduto.Image = global::SS_Almoxarifado.Properties.Resources.print_icon;
            this.btn_imprimirProduto.Location = new System.Drawing.Point(202, 111);
            this.btn_imprimirProduto.Name = "btn_imprimirProduto";
            this.btn_imprimirProduto.Size = new System.Drawing.Size(50, 44);
            this.btn_imprimirProduto.TabIndex = 4;
            this.btn_imprimirProduto.Tag = "";
            this.btn_imprimirProduto.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SS_Almoxarifado.Properties.Resources.Button_Turn_Off_icon;
            this.btn_sair.Location = new System.Drawing.Point(255, 111);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(50, 44);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Tag = "";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // btn_buscarImagem
            // 
            this.btn_buscarImagem.BackColor = System.Drawing.Color.White;
            this.btn_buscarImagem.Image = global::SS_Almoxarifado.Properties.Resources.Zoom_icon;
            this.btn_buscarImagem.Location = new System.Drawing.Point(995, 127);
            this.btn_buscarImagem.Name = "btn_buscarImagem";
            this.btn_buscarImagem.Size = new System.Drawing.Size(50, 44);
            this.btn_buscarImagem.TabIndex = 4;
            this.btn_buscarImagem.Tag = "";
            this.btn_buscarImagem.UseVisualStyleBackColor = false;
            this.btn_buscarImagem.Click += new System.EventHandler(this.Btn_buscarImagem_Click);
            // 
            // btn_salvarImagem
            // 
            this.btn_salvarImagem.BackColor = System.Drawing.Color.White;
            this.btn_salvarImagem.Image = global::SS_Almoxarifado.Properties.Resources.Devices_media_floppy_icon;
            this.btn_salvarImagem.Location = new System.Drawing.Point(995, 172);
            this.btn_salvarImagem.Name = "btn_salvarImagem";
            this.btn_salvarImagem.Size = new System.Drawing.Size(50, 44);
            this.btn_salvarImagem.TabIndex = 4;
            this.btn_salvarImagem.Tag = "Salvar Imagem";
            this.btn_salvarImagem.UseVisualStyleBackColor = false;
            // 
            // btn_excluirImagem
            // 
            this.btn_excluirImagem.BackColor = System.Drawing.Color.White;
            this.btn_excluirImagem.Image = global::SS_Almoxarifado.Properties.Resources.Actions_trash_empty_icon;
            this.btn_excluirImagem.Location = new System.Drawing.Point(995, 217);
            this.btn_excluirImagem.Name = "btn_excluirImagem";
            this.btn_excluirImagem.Size = new System.Drawing.Size(50, 44);
            this.btn_excluirImagem.TabIndex = 4;
            this.btn_excluirImagem.Tag = "Delatar Imagem";
            this.btn_excluirImagem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1200, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "QRCode";
            // 
            // lbl_qtdProdutos
            // 
            this.lbl_qtdProdutos.AutoSize = true;
            this.lbl_qtdProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdProdutos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdProdutos.Location = new System.Drawing.Point(711, 684);
            this.lbl_qtdProdutos.Name = "lbl_qtdProdutos";
            this.lbl_qtdProdutos.Size = new System.Drawing.Size(23, 16);
            this.lbl_qtdProdutos.TabIndex = 3;
            this.lbl_qtdProdutos.Text = "...";
            this.lbl_qtdProdutos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pesquisar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1048, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imagem";
            // 
            // img_imagemProduto
            // 
            this.img_imagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_imagemProduto.Image = global::SS_Almoxarifado.Properties.Resources.sem_imagem;
            this.img_imagemProduto.Location = new System.Drawing.Point(1051, 127);
            this.img_imagemProduto.Name = "img_imagemProduto";
            this.img_imagemProduto.Size = new System.Drawing.Size(146, 134);
            this.img_imagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagemProduto.TabIndex = 2;
            this.img_imagemProduto.TabStop = false;
            // 
            // img_qrCodeProduto
            // 
            this.img_qrCodeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_qrCodeProduto.Image = global::SS_Almoxarifado.Properties.Resources.sem_qrcode;
            this.img_qrCodeProduto.Location = new System.Drawing.Point(1203, 127);
            this.img_qrCodeProduto.Name = "img_qrCodeProduto";
            this.img_qrCodeProduto.Size = new System.Drawing.Size(146, 134);
            this.img_qrCodeProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_qrCodeProduto.TabIndex = 2;
            this.img_qrCodeProduto.TabStop = false;
            // 
            // lvw_listaProdutos
            // 
            this.lvw_listaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_codigo,
            this.col_nome,
            this.col_descricao,
            this.col_setor,
            this.col_categoria,
            this.col_subCategoria,
            this.col_unidade,
            this.col_total,
            this.col_disponivel,
            this.col_bloqueado});
            this.lvw_listaProdutos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaProdutos.FullRowSelect = true;
            this.lvw_listaProdutos.GridLines = true;
            this.lvw_listaProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_listaProdutos.HideSelection = false;
            this.lvw_listaProdutos.Location = new System.Drawing.Point(30, 267);
            this.lvw_listaProdutos.MultiSelect = false;
            this.lvw_listaProdutos.Name = "lvw_listaProdutos";
            this.lvw_listaProdutos.Size = new System.Drawing.Size(1319, 391);
            this.lvw_listaProdutos.TabIndex = 1;
            this.lvw_listaProdutos.UseCompatibleStateImageBehavior = false;
            this.lvw_listaProdutos.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "Id";
            this.col_id.Width = 56;
            // 
            // col_codigo
            // 
            this.col_codigo.Text = "Código";
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 150;
            // 
            // col_descricao
            // 
            this.col_descricao.Text = "Descrição";
            this.col_descricao.Width = 400;
            // 
            // col_setor
            // 
            this.col_setor.Text = "Setor";
            this.col_setor.Width = 120;
            // 
            // col_categoria
            // 
            this.col_categoria.Text = "Categoria";
            this.col_categoria.Width = 120;
            // 
            // col_subCategoria
            // 
            this.col_subCategoria.Text = "Sub Categoria";
            this.col_subCategoria.Width = 120;
            // 
            // col_unidade
            // 
            this.col_unidade.Text = "Unidade";
            this.col_unidade.Width = 80;
            // 
            // col_total
            // 
            this.col_total.Text = "Total";
            this.col_total.Width = 80;
            // 
            // col_disponivel
            // 
            this.col_disponivel.Text = "Disponível";
            this.col_disponivel.Width = 80;
            // 
            // col_bloqueado
            // 
            this.col_bloqueado.Text = "Bloqueado";
            this.col_bloqueado.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1393, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBox1_LoadCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Arquivos de Imagem JPRG (*.jpg)";
            this.openFileDialog1.Title = "Selecione uma imagem";
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 729);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOFTSAL Sistemas v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_produtos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qrCodeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvw_listaProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_imagemProduto;
        private System.Windows.Forms.PictureBox img_qrCodeProduto;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_codigo;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_descricao;
        private System.Windows.Forms.ColumnHeader col_setor;
        private System.Windows.Forms.ColumnHeader col_categoria;
        private System.Windows.Forms.ColumnHeader col_subCategoria;
        private System.Windows.Forms.ColumnHeader col_unidade;
        private System.Windows.Forms.ColumnHeader col_total;
        private System.Windows.Forms.ColumnHeader col_disponivel;
        private System.Windows.Forms.ColumnHeader col_bloqueado;
        private System.Windows.Forms.Label lbl_qtdProdutos;
        private System.Windows.Forms.Button btn_buscarImagem;
        private System.Windows.Forms.Button btn_salvarImagem;
        private System.Windows.Forms.Button btn_excluirImagem;
        private System.Windows.Forms.Button btn_novoProduto;
        private System.Windows.Forms.Button btn_editarProduto;
        private System.Windows.Forms.Button btn_excluirProduto;
        private System.Windows.Forms.Button btn_imprimirProduto;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}