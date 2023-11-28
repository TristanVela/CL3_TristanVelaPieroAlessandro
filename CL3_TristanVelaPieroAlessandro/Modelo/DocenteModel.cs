using CL3_TristanVelaPieroAlessandro.DataAccess;
using System;

namespace CL3_TristanVelaPieroAlessandro.Modelo
{
    public class DocenteModel
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos{ get; set; }
        public string CentroEstudios { get; set; }
        public int AñosExperiencia { get; set; }
        public int AñosDocencia { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GradoAcademico { get; set; }
    }
}
