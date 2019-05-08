namespace PrototipoPulseira
{
    partial class CadDep
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeDependenteLabel;
            System.Windows.Forms.Label codResponsavelLabel;
            System.Windows.Forms.Label codDependenteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadDep));
            this.natalidDataSetOK = new PrototipoPulseira.natalidDataSetOK();
            this.dependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependenteTableAdapter = new PrototipoPulseira.natalidDataSetOKTableAdapters.DependenteTableAdapter();
            this.tableAdapterManager = new PrototipoPulseira.natalidDataSetOKTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dependenteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dependenteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.nomeDependenteTextBox = new System.Windows.Forms.TextBox();
            this.codDependenteTextBox = new System.Windows.Forms.TextBox();
            this.codResponsavelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nomeDependenteLabel = new System.Windows.Forms.Label();
            codResponsavelLabel = new System.Windows.Forms.Label();
            codDependenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.natalidDataSetOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingNavigator)).BeginInit();
            this.dependenteBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeDependenteLabel
            // 
            nomeDependenteLabel.AutoSize = true;
            nomeDependenteLabel.Location = new System.Drawing.Point(6, 42);
            nomeDependenteLabel.Name = "nomeDependenteLabel";
            nomeDependenteLabel.Size = new System.Drawing.Size(115, 13);
            nomeDependenteLabel.TabIndex = 3;
            nomeDependenteLabel.Text = "Nome do Dependente:";
            // 
            // codResponsavelLabel
            // 
            codResponsavelLabel.AutoSize = true;
            codResponsavelLabel.Location = new System.Drawing.Point(6, 68);
            codResponsavelLabel.Name = "codResponsavelLabel";
            codResponsavelLabel.Size = new System.Drawing.Size(123, 13);
            codResponsavelLabel.TabIndex = 5;
            codResponsavelLabel.Text = "Código do Responsavel:";
            // 
            // codDependenteLabel
            // 
            codDependenteLabel.AutoSize = true;
            codDependenteLabel.Location = new System.Drawing.Point(6, 16);
            codDependenteLabel.Name = "codDependenteLabel";
            codDependenteLabel.Size = new System.Drawing.Size(120, 13);
            codDependenteLabel.TabIndex = 1;
            codDependenteLabel.Text = "Código do Dependente:";
            // 
            // natalidDataSetOK
            // 
            this.natalidDataSetOK.DataSetName = "natalidDataSetOK";
            this.natalidDataSetOK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dependenteBindingSource
            // 
            this.dependenteBindingSource.DataMember = "Dependente";
            this.dependenteBindingSource.DataSource = this.natalidDataSetOK;
            // 
            // dependenteTableAdapter
            // 
            this.dependenteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguelPagamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependenteTableAdapter = this.dependenteTableAdapter;
            this.tableAdapterManager.deTableAdapter = null;
            this.tableAdapterManager.DispositivosTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.TipoDispositivoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrototipoPulseira.natalidDataSetOKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.vinculaseTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(474, 396);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(474, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover ao primeiro cadastro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover ao cadastro anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "mover ao próximo cadastro";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover ao último cadastro";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo cadastro";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir cadastro";
            // 
            // dependenteBindingNavigatorSaveItem
            // 
            this.dependenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dependenteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dependenteBindingNavigatorSaveItem.Image")));
            this.dependenteBindingNavigatorSaveItem.Name = "dependenteBindingNavigatorSaveItem";
            this.dependenteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dependenteBindingNavigatorSaveItem.Text = "Salvar Alterações";
            this.dependenteBindingNavigatorSaveItem.Click += new System.EventHandler(this.dependenteBindingNavigatorSaveItem_Click);
            // 
            // dependenteBindingNavigator
            // 
            this.dependenteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dependenteBindingNavigator.BindingSource = this.dependenteBindingSource;
            this.dependenteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dependenteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dependenteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.dependenteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dependenteBindingNavigatorSaveItem});
            this.dependenteBindingNavigator.Location = new System.Drawing.Point(0, 52);
            this.dependenteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dependenteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dependenteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dependenteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dependenteBindingNavigator.Name = "dependenteBindingNavigator";
            this.dependenteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dependenteBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dependenteBindingNavigator.Size = new System.Drawing.Size(309, 25);
            this.dependenteBindingNavigator.TabIndex = 0;
            this.dependenteBindingNavigator.Text = "bindingNavigator1";
            // 
            // nomeDependenteTextBox
            // 
            this.nomeDependenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependenteBindingSource, "NomeDependente", true));
            this.nomeDependenteTextBox.Location = new System.Drawing.Point(140, 39);
            this.nomeDependenteTextBox.Name = "nomeDependenteTextBox";
            this.nomeDependenteTextBox.Size = new System.Drawing.Size(102, 20);
            this.nomeDependenteTextBox.TabIndex = 4;
            this.nomeDependenteTextBox.TextChanged += new System.EventHandler(this.nomeDependenteTextBox_TextChanged);
            // 
            // codDependenteTextBox
            // 
            this.codDependenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependenteBindingSource, "CodDependente", true));
            this.codDependenteTextBox.Location = new System.Drawing.Point(140, 13);
            this.codDependenteTextBox.Name = "codDependenteTextBox";
            this.codDependenteTextBox.Size = new System.Drawing.Size(102, 20);
            this.codDependenteTextBox.TabIndex = 2;
            this.codDependenteTextBox.TextChanged += new System.EventHandler(this.codDependenteTextBox_TextChanged);
            // 
            // codResponsavelTextBox
            // 
            this.codResponsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependenteBindingSource, "CodResponsavel", true));
            this.codResponsavelTextBox.Location = new System.Drawing.Point(140, 65);
            this.codResponsavelTextBox.Name = "codResponsavelTextBox";
            this.codResponsavelTextBox.Size = new System.Drawing.Size(102, 20);
            this.codResponsavelTextBox.TabIndex = 6;
            this.codResponsavelTextBox.TextChanged += new System.EventHandler(this.codResponsavelTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(codDependenteLabel);
            this.groupBox1.Controls.Add(this.codResponsavelTextBox);
            this.groupBox1.Controls.Add(this.codDependenteTextBox);
            this.groupBox1.Controls.Add(codResponsavelLabel);
            this.groupBox1.Controls.Add(nomeDependenteLabel);
            this.groupBox1.Controls.Add(this.nomeDependenteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CadDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 396);
            this.Controls.Add(this.dependenteBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "CadDep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dependente";
            this.Load += new System.EventHandler(this.CadDep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.natalidDataSetOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingNavigator)).EndInit();
            this.dependenteBindingNavigator.ResumeLayout(false);
            this.dependenteBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private natalidDataSetOK natalidDataSetOK;
        private System.Windows.Forms.BindingSource dependenteBindingSource;
        private natalidDataSetOKTableAdapters.DependenteTableAdapter dependenteTableAdapter;
        private natalidDataSetOKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton dependenteBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator dependenteBindingNavigator;
        private System.Windows.Forms.TextBox nomeDependenteTextBox;
        private System.Windows.Forms.TextBox codDependenteTextBox;
        private System.Windows.Forms.TextBox codResponsavelTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}