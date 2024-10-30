namespace HospitalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataListaPersonas = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textDNIPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPersonas)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataListaPersonas
            // 
            this.dataListaPersonas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataListaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPersonas.Location = new System.Drawing.Point(12, 150);
            this.dataListaPersonas.Name = "dataListaPersonas";
            this.dataListaPersonas.RowHeadersWidth = 51;
            this.dataListaPersonas.RowTemplate.Height = 24;
            this.dataListaPersonas.Size = new System.Drawing.Size(700, 380);
            this.dataListaPersonas.TabIndex = 1;
            this.dataListaPersonas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPersonas_CellEndEdit);
            this.dataListaPersonas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPersonas_CellValueChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(730, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 57);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "AGREGAR";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(730, 230);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 57);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "ELIMINAR";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Pacientes",
            "Medicos",
            "Administrativos",
            "Citas"});
            this.comboBox1.Location = new System.Drawing.Point(15, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textDNIPaciente
            // 
            this.textDNIPaciente.Location = new System.Drawing.Point(200, 28);
            this.textDNIPaciente.Name = "textDNIPaciente";
            this.textDNIPaciente.Size = new System.Drawing.Size(135, 26);
            this.textDNIPaciente.TabIndex = 9;
            this.textDNIPaciente.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI Paciente";
            this.label1.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(351, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 28);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.comboBox1);
            this.groupBoxFiltros.Controls.Add(this.textDNIPaciente);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.Controls.Add(this.buttonBuscar);
            this.groupBoxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 30);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(450, 75);
            this.groupBoxFiltros.TabIndex = 12;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataListaPersonas);
            this.Name = "Form1";
            this.Text = "Gestión de Personas en Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPersonas)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataListaPersonas;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textDNIPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
    }
}
