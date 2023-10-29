using AutoMapper;
using Estudiantes.Bll.Interfaces;
using Estudiantes.Common.Runtime;
using Estudiantes.Entities.Models;
using Estudiantes.Entities.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EstudiantesWebAPI.Controllers
{
    /// <summary>
    /// Contiene los Endpoints del CRUD de Estudiantes
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        /* Para acceder a los métodos de Business logic layer (BLL)*/
        private readonly IEstudianteBll _estudianteBll;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor para inyección de dependencias
        /// </summary>
        /// <param name="estudianteBll"></param>
        /// <param name="mapper"></param>
        public EstudianteController(IEstudianteBll estudianteBll, IMapper mapper)
        {
            _estudianteBll = estudianteBll;
            _mapper = mapper;
        }

        /// <summary>
        /// Endpoint para agregar un nuevo Estudiante
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(Estudiante), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] EstudianteInsertarDto value)
        {
            if (value is null)
                return BadRequest("Estudiante no puede ser null.");

            if (string.IsNullOrEmpty(value.Nombre) || string.IsNullOrEmpty(value.Carrera) || string.IsNullOrEmpty(value.Carnet))
                return BadRequest("Nombre, carrera y carnet son campos obligatorios.");
            
            var response = await _estudianteBll.Create(_mapper.Map<Estudiante>(value));
            if (response is null || !response.IsSuccess)
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocurrio un error al guardar en el archivo.");
            
            return Ok(response);
        }

        /// <summary>
        /// Endpoint para eliminar un Estudiante
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(APIResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Error ID de Estudiante no puede ser menor o igual a cero.");

            var response = await _estudianteBll.Delete(id);
            if (!response.IsSuccess)
                return NotFound("No se encontro un Estudiante con el ID ingresado.");

            return Ok(response);
        }

        /// <summary>
        /// Endpoint para actualizar un Estudiante
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(APIResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put([FromBody] Estudiante value)
        {
            if (value is null)
                return BadRequest("Estudiante no puede ser null.");

            if (value.Id <= 0)
                return BadRequest("Error ID de Estudiante no puede ser menor o igual a cero.");

            if (string.IsNullOrEmpty(value.Nombre) || string.IsNullOrEmpty(value.Carrera) || string.IsNullOrEmpty(value.Carnet))
                return BadRequest("Nombre, carrera y carnet son campos obligatorios.");

            var response = await _estudianteBll.Update(value);
            if (!response.IsSuccess)
                return NotFound("No se encontro un Estudiante con el ID ingresado.");

            return Ok(response);
        }

        /// <summary>
        /// Endpoint para obtener todos los Estudiantes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Estudiante>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            var response = await _estudianteBll.GetAll();
            if (response is null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocurrio un error al leer datos del archivo.");
            
            return Ok(response);
        }

        /// <summary>
        /// Endpoint para obtener un Estudiante
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Estudiante), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("Error ID de Estudiante no puede ser menor o igual a cero.");

            var response = await _estudianteBll.GetById(id);
            if (response is null || response.Id == 0)
                return NotFound("No se encontro un Estudiante con el ID ingresado.");
            return Ok(response);
        }
    }
}