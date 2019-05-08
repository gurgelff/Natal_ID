namespace PrototipoPulseira
{
    partial class DadosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosPessoais));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.natalidDataSet3 = new PrototipoPulseira.natalidDataSet3();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new PrototipoPulseira.natalidDataSet3TableAdapters.ResponsavelTableAdapter();
            this.tableAdapterManager = new PrototipoPulseira.natalidDataSet3TableAdapters.TableAdapterManager();
            this.empresaTableAdapter = new PrototipoPulseira.natalidDataSet3TableAdapters.EmpresaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.responsavelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.natalidDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pessoa Física";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(46, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pessoa Jurídica";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // natalidDataSet3
            // 
            this.natalidDataSet3.DataSetName = "natalidDataSet3";
            this.natalidDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.natalidDataSet3;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguelPagamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DependenteTableAdapter = null;
            this.tableAdapterManager.deTableAdapter = null;
            this.tableAdapterManager.DispositivosTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.ResponsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.TipoDispositivoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrototipoPulseira.natalidDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vinculaseTableAdapter = null;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // responsavelBindingSource1
            // 
            this.responsavelBindingSource1.DataMember = "Responsavel";
            this.responsavelBindingSource1.DataSource = this.natalidDataSet3;
            // 
            // responsavelBindingSource2
            // 
            this.responsavelBindingSource2.DataMember = "Responsavel";
            this.responsavelBindingSource2.DataSource = this.natalidDataSet3;
            // 
            // responsavelBindingSource3
            // 
            this.responsavelBindingSource3.DataMember = "Responsavel";
            this.responsavelBindingSource3.DataSource = this.natalidDataSet3;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.natalidDataSet3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(126, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o tipo de pessoa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-54, -151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(473, 49);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(473, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 363);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 401);
            this.MinimumSize = new System.Drawing.Size(490, 401);
            this.Name = "DadosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Pessoais";
            this.Load += new System.EventHandler(this.DadosPessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.natalidDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private natalidDataSet3 natalidDataSet3;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private natalidDataSet3TableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private natalidDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource responsavelBindingSource1;
        private System.Windows.Forms.BindingSource responsavelBindingSource2;
        private System.Windows.Forms.BindingSource responsavelBindingSource3;
        private natalidDataSet3TableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}