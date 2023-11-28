using AutoMapper;
using CL3_TristanVelaPieroAlessandro.DataAccess;
using CL3_TristanVelaPieroAlessandro.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CL3_TristanVelaPieroAlessandro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        IMapper _mapper;
        DocenteContext _context;
       
        public DocenteController(DocenteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [Route("")]
        public IList<DocenteEntity> GetAllDocentes()
        {
            var origen = _context.Docente.ToList();
            var destino = _mapper.Map<IList<DocenteEntity>>(origen);
            return destino;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var docente = _context.Docente.Find(id);

            if (docente == null)
            {
                return NotFound();
            }

            var docenteModel = _mapper.Map<DocenteModel>(docente);
            return Ok(docenteModel);
        }


        [HttpPost]
        [Route("")]
        public void SaveDocentes(DocenteModel origen)
        {
            var destino = _mapper.Map<DocenteEntity>(origen);
            _context.Docente.Add(destino);
            _context.SaveChanges();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult EditDocente(int id, DocenteModel docenteUpdate)
        {
            var docenteEdit = _context.Docente.FirstOrDefault(c => c.Id == id);
            if (docenteEdit == null)
            {
                return NotFound();
            }
            docenteEdit.Nombres = docenteUpdate.Nombres;
            docenteEdit.Apellidos = docenteUpdate.Apellidos;
            docenteEdit.DNI = docenteUpdate.DNI;
            docenteEdit.FechaNacimiento = docenteUpdate.FechaNacimiento;
            docenteEdit.GradoAcademico = docenteUpdate.GradoAcademico;
            docenteEdit.CentroEstudios = docenteUpdate.CentroEstudios;
            docenteEdit.AñosExperiencia = docenteUpdate.AñosExperiencia;
            docenteEdit.AñosDocencia = docenteUpdate.AñosDocencia;
            _context.Docente.Update(docenteEdit);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteDocente(int id)
        {
            var docente = _context.Docente.Find(id);

            if (docente == null)
            {
                return NotFound(); 
            }

            _context.Docente.Remove(docente);
            _context.SaveChanges();

            return Ok(); 
        }

    }
}
