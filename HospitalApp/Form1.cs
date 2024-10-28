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
                    buttonAdd.Visible = false;
                    buttonDelete.Visible = false;
                    buttonBuscar.Visible = false;
                    label1.Visible = false;
                    textDNIPaciente.Visible = false;
                    dataListaPersonas.DataSource = personas;
                    break;
                case 1:
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = true;
                    buttonBuscar.Visible = false;
                    label1.Visible = false;
                    textDNIPaciente.Visible = false;
                    dataListaPersonas.DataSource = personas.OfType<Paciente>().ToList();
                    break;
                case 2:
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = false;
                    buttonBuscar.Visible = false;
                    label1.Visible = false;
                    textDNIPaciente.Visible = false; 
                    dataListaPersonas.DataSource = personas.OfType<Medico>().ToList();
                    break;
                case 3:
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = false;
                    buttonBuscar.Visible = false;
                    label1.Visible = false;
                    textDNIPaciente.Visible = false;
                    dataListaPersonas.DataSource = personas.OfType<Administrativo>().ToList();
                    break;
                case 4:
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = true;
                    buttonBuscar.Visible = true;
                    label1.Visible = true;
                    textDNIPaciente.Visible = true;
                    dataListaPersonas.DataSource = null;
                    break;
            }
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
                dataListaPersonas.DataSource = personas.OfType<Paciente>().ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    personas.Add(new Paciente());
                    dataListaPersonas.DataSource = null;
                    dataListaPersonas.DataSource = personas.OfType<Paciente>().ToList();
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
    }
}
