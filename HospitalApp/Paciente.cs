using System.Collections.Generic;

namespace HospitalApp
{
    public class Paciente : Persona
    {
        protected Medico medicoDeCabecera;
        protected List<Cita> historial;

        public List<Cita> Historial 
        {
            get { return historial; }
            set { historial = value; }
        }

        public Medico MedicoDeCabecera
        {
            get { return medicoDeCabecera; }
            set
            {
                if (medicoDeCabecera != null)
                    medicoDeCabecera.ListaPacientes.Remove(this);

                medicoDeCabecera = value;

                if (medicoDeCabecera != null)
                    medicoDeCabecera.ListaPacientes.Add(this);
            }
        }

        public Paciente()
        {
            MedicoDeCabecera = new Medico();
            Historial = new List<Cita>();
        }

        public Paciente(string nombre, int edad, int dni, char letraDni, List<Cita> historial) : base(nombre, edad, dni, letraDni)
        {
            this.Historial = historial;
        }

        public Paciente(Persona persona, List<Cita> historial) : base(persona.Nombre, persona.Edad, persona.Dni, persona.LetraDni)
        {
            this.Historial = historial;
        }

        public override string ToString()
        {
            return $@"{base.ToString()}: 
{historial.ToString()}";
        }
    }
}