using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System Cdatos;

namespace CEntidad
{
    public class CECitas
    {
        private String cod_cita;
        private DateTime fecha;
        private DateTime hora;
        private String idPaciente;
        private String id_medico;
        private int valor;
        private String diagnostico;
        private String nom_acompañante;
        private byte activo;

        public string Cod_cita { get => cod_cita; set => cod_cita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Id_medico { get => id_medico; set => id_medico = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nom_acompañante { get => nom_acompañante; set => nom_acompañante = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
