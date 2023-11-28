using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CL3_TristanVelaPieroAlessandro.DataAccess
{
    [Table("Docente")]
    public class DocenteEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GradoAcademico { get; set; }
        public string CentroEstudios { get; set; }
        public int AñosExperiencia { get; set; }
        public int AñosDocencia { get; set; }
    }


}