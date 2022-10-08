
namespace WebScraping.View
{
    partial class frmMain
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
            this.btn_abrir = new System.Windows.Forms.Button();
            this.cbx_opcao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_subForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(442, 8);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(75, 23);
            this.btn_abrir.TabIndex = 1;
            this.btn_abrir.Text = "Acessar";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // cbx_opcao
            // 
            this.cbx_opcao.FormattingEnabled = true;
            this.cbx_opcao.Items.AddRange(new object[] {
            "Folha de pgto",
            "Post Msdn"});
            this.cbx_opcao.Location = new System.Drawing.Point(67, 8);
            this.cbx_opcao.Name = "cbx_opcao";
            this.cbx_opcao.Size = new System.Drawing.Size(360, 21);
            this.cbx_opcao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dados:";
            // 
            // panel_subForm
            // 
            this.panel_subForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_subForm.Location = new System.Drawing.Point(14, 49);
            this.panel_subForm.Name = "panel_subForm";
            this.panel_subForm.Size = new System.Drawing.Size(795, 389);
            this.panel_subForm.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.panel_subForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_opcao);
            this.Controls.Add(this.btn_abrir);
            this.Name = "frmMain";
            this.Text = "WebScralling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.ComboBox cbx_opcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_subForm;
    }
}

