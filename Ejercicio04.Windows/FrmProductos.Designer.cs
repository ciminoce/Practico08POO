﻿namespace Ejercicio04.Windows
{
    partial class FrmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            StatusBar = new StatusStrip();
            LblStatus = new ToolStripStatusLabel();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            tsbDetalles = new ToolStripButton();
            TsbFiltrar = new ToolStripDropDownButton();
            tipoDeProductoToolStripMenuItem = new ToolStripMenuItem();
            CboTiposProductosFiltro = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            StatusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(StatusBar);
            splitContainer1.Size = new Size(800, 555);
            splitContainer1.SplitterDistance = 444;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colPrecio, colStock, colTipo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 444);
            dgvDatos.TabIndex = 2;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo Producto";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // StatusBar
            // 
            StatusBar.Items.AddRange(new ToolStripItem[] { LblStatus });
            StatusBar.Location = new Point(0, 85);
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(800, 22);
            StatusBar.TabIndex = 0;
            StatusBar.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(118, 17);
            LblStatus.Text = "toolStripStatusLabel1";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Ejercicio04W.Windows.Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(46, 59);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += btnNuevo_Click;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Ejercicio04W.Windows.Properties.Resources.Delete;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(44, 59);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrar.Click += TsbBorrar_Click;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Ejercicio04W.Windows.Properties.Resources.Edit;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(44, 59);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditar.Click += TsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Ejercicio04W.Windows.Properties.Resources.Update;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(63, 59);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbActualizar.Click += TsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // TsbCerrar
            // 
            TsbCerrar.Image = Ejercicio04W.Windows.Properties.Resources.Close;
            TsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrar.ImageTransparentColor = Color.Magenta;
            TsbCerrar.Name = "TsbCerrar";
            TsbCerrar.Size = new Size(44, 59);
            TsbCerrar.Text = "Cerrar";
            TsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrar.Click += TsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, tsbDetalles, TsbFiltrar, TsbActualizar, toolStripSeparator2, TsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = Ejercicio04W.Windows.Properties.Resources.details_40px;
            tsbDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 59);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbDetalles.Click += tsbDetalles_Click;
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { tipoDeProductoToolStripMenuItem });
            TsbFiltrar.Image = Ejercicio04W.Windows.Properties.Resources.filter_40px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(53, 59);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tipoDeProductoToolStripMenuItem
            // 
            tipoDeProductoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CboTiposProductosFiltro });
            tipoDeProductoToolStripMenuItem.Name = "tipoDeProductoToolStripMenuItem";
            tipoDeProductoToolStripMenuItem.Size = new Size(165, 22);
            tipoDeProductoToolStripMenuItem.Text = "Tipo de Producto";
            // 
            // CboTiposProductosFiltro
            // 
            CboTiposProductosFiltro.Name = "CboTiposProductosFiltro";
            CboTiposProductosFiltro.Size = new Size(121, 23);
            CboTiposProductosFiltro.SelectedIndexChanged += CboTiposProductosFiltro_SelectedIndexChanged;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += FrmProductos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            StatusBar.ResumeLayout(false);
            StatusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbCerrar;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colTipo;
        private ToolStripButton tsbDetalles;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel LblStatus;
        private ToolStripDropDownButton TsbFiltrar;
        private ToolStripMenuItem tipoDeProductoToolStripMenuItem;
        private ToolStripComboBox CboTiposProductosFiltro;
    }
}