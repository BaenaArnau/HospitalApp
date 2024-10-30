using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form1 : Form
    {
        public List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Visibilidad(false,false,false,false,false);
                    CargarListaEnDataGridView(personas);
                    break;
                case 1:
                    Visibilidad(true,true,false,false,false);
                    CargarListaEnDataGridView(personas.OfType<Paciente>().ToList());
                    break;
                case 2:
                    Visibilidad(true,false,false,false,false);
                    CargarListaEnDataGridView(personas.OfType<Medico>().ToList());
                    break;
                case 3:
                    Visibilidad(true,false,false,false,false);
                    CargarListaEnDataGridView(personas.OfType<Administrativo>().ToList());
                    break;
                case 4:
                    Visibilidad(false,false,true,true,true);
                    dataListaPersonas.DataSource = null;
                    break;
            }
        }

        private void Visibilidad(bool add, bool delete, bool buscar, bool label, bool text)
        {
            buttonAdd.Visible = add;
            buttonDelete.Visible = delete;
            buttonBuscar.Visible = buscar;
            label1.Visible = label;
            textDNIPaciente.Visible = text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                foreach (DataGridViewRow fila in dataListaPersonas.SelectedRows)
                {
                    Paciente paciente = (Paciente)fila.DataBoundItem;

                    personas.Remove(paciente);
                }

                dataListaPersonas.DataSource = null;
                CargarListaEnDataGridView(personas.OfType<Paciente>().ToList());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    personas.Add(new Paciente());
                    dataListaPersonas.DataSource = null;
                    CargarListaEnDataGridView(personas.OfType<Paciente>().ToList());
                    break;
                case 2:
                    personas.Add(new Medico());
                    dataListaPersonas.DataSource = null;
                    dataListaPersonas.DataSource = personas.OfType<Medico>().ToList();
                    break;
                case 3:
                    personas.Add(new Administrativo());
                    dataListaPersonas.DataSource = null;
                    dataListaPersonas.DataSource = personas.OfType<Administrativo>().ToList();
                    break;
                case 4:
                    break;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textDNIPaciente.Text.Length == 9)
            {
                foreach (Paciente paciente in personas.OfType<Paciente>().ToList())
                {
                    string dni = paciente.Dni + "" + paciente.LetraDni + "";
                    if (dni == textDNIPaciente.Text)
                    {
                        buttonAdd.Visible = true;
                        buttonDelete.Visible = true;
                        dataListaPersonas.DataSource = paciente.Historial;
                        return;
                    }
                }

                MessageBox.Show("No se ha encontrado el paciente, introduzca un DNI valido");
            }
            else
                MessageBox.Show("El formato del DNI no es un formato valido");
        }

        private void dataListaPersonas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataListaPersonas.Columns[e.ColumnIndex].Name == "MedicoAsignado")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataListaPersonas.Rows.Count)
                {
                    DataGridViewRow row = dataListaPersonas.Rows[e.RowIndex];

                    string nombreMedicoSeleccionado = row.Cells["MedicoAsignado"].Value?.ToString();

                    Paciente paciente = (Paciente)dataListaPersonas.Rows[e.RowIndex].DataBoundItem;
                }
            }
        }

        private void CargarListaEnDataGridView<T>(List<T> lista)
        {
            dataListaPersonas.Columns.Clear();
            dataListaPersonas.DataSource = null;

            if (typeof(T) == typeof(Paciente))
            {
                dataListaPersonas.Columns.Add("NombrePaciente", "Nombre del Paciente");
                dataListaPersonas.Columns.Add("DNI", "DNI");
                dataListaPersonas.Columns.Add("LetraDNI", "LetraDNI");
                dataListaPersonas.Columns.Add("Edad", "Edad");

                DataGridViewComboBoxColumn comboMedicos = new DataGridViewComboBoxColumn();
                comboMedicos.HeaderText = "Médico de Cabecera";
                comboMedicos.Name = "MedicoAsignado";
                comboMedicos.DataSource = personas.OfType<Medico>().ToList();
                comboMedicos.DisplayMember = "Nombre";
                comboMedicos.ValueMember = "Nombre";
                dataListaPersonas.Columns.Add(comboMedicos);

                foreach (Paciente paciente in lista.OfType<Paciente>())
                {
                    int rowIndex = dataListaPersonas.Rows.Add();
                    DataGridViewRow row = dataListaPersonas.Rows[rowIndex];
                    row.Cells["NombrePaciente"].Value = paciente.Nombre;
                    row.Cells["DNI"].Value = paciente.Dni;
                    row.Cells["LetraDNI"].Value = paciente.LetraDni;
                    row.Cells["Edad"].Value = paciente.Edad;

                    if (paciente.MedicoDeCabecera != null)
                        row.Cells["MedicoAsignado"].Value = paciente.MedicoDeCabecera.Nombre;
                    else
                        row.Cells["MedicoAsignado"].Value = null;
                }
            }
            else
                dataListaPersonas.DataSource = lista;

            dataListaPersonas.CellValueChanged += dataListaPersonas_CellValueChanged;
        }

        private void CargarListaEnDataGridView(List<Persona> lista)
        {
            dataListaPersonas.DataSource = null;
            dataListaPersonas.Columns.Clear();
            dataListaPersonas.DataSource = lista;
        }

        private void dataListaPersonas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataListaPersonas.Columns[e.ColumnIndex].Name == "NombrePaciente" ||
                dataListaPersonas.Columns[e.ColumnIndex].Name == "DNI" ||
                dataListaPersonas.Columns[e.ColumnIndex].Name == "LetraDNI" ||
                dataListaPersonas.Columns[e.ColumnIndex].Name == "Edad" ||
                dataListaPersonas.Columns[e.ColumnIndex].Name == "MedicoAsignado")
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dataListaPersonas.Rows.Count)
                {
                    Paciente paciente;
                    if (rowIndex < personas.OfType<Paciente>().Count())
                        paciente = personas.OfType<Paciente>().ToList()[rowIndex];
                    else
                    {
                        paciente = new Paciente();
                        personas.Add(paciente);
                    }

                    paciente.Nombre = dataListaPersonas.Rows[rowIndex].Cells["NombrePaciente"].Value?.ToString() ?? "Valor Predeterminado";
                    paciente.Dni = Convert.ToInt32(dataListaPersonas.Rows[rowIndex].Cells["DNI"].Value ?? 00000000);
                    paciente.LetraDni = Convert.ToChar(dataListaPersonas.Rows[rowIndex].Cells["LetraDNI"].Value ?? 'X');
                    paciente.Edad = Convert.ToInt32(dataListaPersonas.Rows[rowIndex].Cells["Edad"].Value ?? 0);

                    string nombreMedicoSeleccionado = dataListaPersonas.Rows[rowIndex].Cells["MedicoAsignado"].Value?.ToString();
                    paciente.MedicoDeCabecera = personas.OfType<Medico>().FirstOrDefault(m => m.Nombre == nombreMedicoSeleccionado);
                }
            }
        }
    }
}