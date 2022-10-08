
namespace WebScraping.View
{
    partial class frmFolhaPgto
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
            this.gv_folhaPgto = new System.Windows.Forms.DataGridView();
            this.Competência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vantagens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.cbxAno = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.chk_acumulado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_folhaPgto)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_folhaPgto
            // 
            this.gv_folhaPgto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_folhaPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_folhaPgto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competência,
            this.Matricula,
            this.Nome,
            this.CPF,
            this.Cargo,
            this.Secretaria,
            this.Regime,
            this.DtAdmissao,
            this.Vantagens,
            this.Descontos,
            this.Liquido,
            this.cpt});
            this.gv_folhaPgto.Location = new System.Drawing.Point(12, 79);
            this.gv_folhaPgto.Name = "gv_folhaPgto";
            this.gv_folhaPgto.Size = new System.Drawing.Size(776, 359);
            this.gv_folhaPgto.TabIndex = 0;
            // 
            // Competência
            // 
            this.Competência.HeaderText = "Competencia";
            this.Competência.Name = "Competência";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Secretaria
            // 
            this.Secretaria.HeaderText = "Secretaria";
            this.Secretaria.Name = "Secretaria";
            // 
            // Regime
            // 
            this.Regime.HeaderText = "Regime";
            this.Regime.Name = "Regime";
            // 
            // DtAdmissao
            // 
            this.DtAdmissao.HeaderText = "Dt. Admissão";
            this.DtAdmissao.Name = "DtAdmissao";
            // 
            // Vantagens
            // 
            this.Vantagens.HeaderText = "Salário bruto";
            this.Vantagens.Name = "Vantagens";
            // 
            // Descontos
            // 
            this.Descontos.HeaderText = "Descontos";
            this.Descontos.Name = "Descontos";
            // 
            // Liquido
            // 
            this.Liquido.HeaderText = "Salário líquido";
            this.Liquido.Name = "Liquido";
            // 
            // cpt
            // 
            this.cpt.HeaderText = "cpt";
            this.cpt.Name = "cpt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mês:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano:";
            // 
            // cbxMes
            // 
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxMes.Location = new System.Drawing.Point(49, 10);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(121, 21);
            this.cbxMes.TabIndex = 3;
            // 
            // cbxAno
            // 
            this.cbxAno.FormattingEnabled = true;
            this.cbxAno.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbxAno.Location = new System.Drawing.Point(49, 37);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(121, 21);
            this.cbxAno.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(604, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(184, 48);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // chk_acumulado
            // 
            this.chk_acumulado.AutoSize = true;
            this.chk_acumulado.Location = new System.Drawing.Point(190, 9);
            this.chk_acumulado.Name = "chk_acumulado";
            this.chk_acumulado.Size = new System.Drawing.Size(170, 17);
            this.chk_acumulado.TabIndex = 6;
            this.chk_acumulado.Text = "Acumulado (Últimos 12 meses)";
            this.chk_acumulado.UseVisualStyleBackColor = true;
            this.chk_acumulado.CheckedChanged += new System.EventHandler(this.chk_acumulado_CheckedChanged);
            // 
            // frmFolhaPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_acumulado);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cbxAno);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_folhaPgto);
            this.Name = "frmFolhaPgto";
            this.Text = "Folha de pgto";
            ((System.ComponentModel.ISupportInitialize)(this.gv_folhaPgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_folhaPgto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.ComboBox cbxAno;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competência;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vantagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpt;
        private System.Windows.Forms.CheckBox chk_acumulado;
    }
}