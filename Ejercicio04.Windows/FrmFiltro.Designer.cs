namespace Ejercicio04W.Windows
{
    partial class FrmFiltro
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
            label1 = new Label();
            CboTipoProducto = new ComboBox();
            BtnCancelar = new Button();
            BtnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Producto:";
            // 
            // CboTipoProducto
            // 
            CboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoProducto.FormattingEnabled = true;
            CboTipoProducto.Location = new Point(161, 51);
            CboTipoProducto.Name = "CboTipoProducto";
            CboTipoProducto.Size = new Size(192, 23);
            CboTipoProducto.TabIndex = 1;
            CboTipoProducto.SelectedIndexChanged += CboTipoProducto_SelectedIndexChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(278, 109);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 52);
            BtnCancelar.TabIndex = 31;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(54, 109);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 32;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 186);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Controls.Add(CboTipoProducto);
            Controls.Add(label1);
            Name = "FrmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFiltro";
            Load += FrmFiltro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CboTipoProducto;
        private Button BtnCancelar;
        private Button BtnOK;
    }
}