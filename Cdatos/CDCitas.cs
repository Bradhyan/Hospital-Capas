using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidad;

namespace Cdatos
{
    public  class CDCitas
    {
        cconexion oconexion = new cconexion();
        SqlCommand ocmd=new SqlCommand();

        public bool Guardar_cita(CECitas ocitas)
        {
            try
            {
                ocmd.CommandType = System.Data.CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "Actualizar cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@id_paciente", ocitas.IdPaciente);
                ocmd.Parameters.Add("@id_medico", ocitas.Id_medico);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompañante", ocitas.Nom_acompañante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;




            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }

        public bool Anular_Cita(CECitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "Cambiar_cita";
                ocmd.Parameters.Add("cod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception (err.Message);           }
        }
    }
}
