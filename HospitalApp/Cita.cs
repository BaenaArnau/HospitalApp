using System;

namespace HospitalApp
{
    public class Cita
    {
        protected Paciente paciente;
        protected Medico medico;
        protected DateTime fecha;
        protected string diagnostico;
        protected string tratamiento;
        protected string notas;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Diagnostico 
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }

        public string Notas 
        {
            get { return notas; }
            set { notas = value; }
        }

        public Cita()
        {
        }

        public Cita(Paciente paciente, Medico medico, DateTime fecha)
        {
            this.paciente = paciente;
            this.medico = medico;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return $"El paciente {paciente.Nombre} tiene una cita con el doctor {medico.Nombre} a las {fecha.ToString()}";
        }
    }
}