using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD___CARVAJAL.Contexts;
using CRUD___CARVAJAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD___CARVAJAL.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly AppDbContext context;

        public UsuarioController(AppDbContext context )
        {
            this.context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return context.Usuario.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            var usuario = context.Usuario.FirstOrDefault(usuario => usuario.Id == id);
            return usuario;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
                    return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Usuario usuario)
        {
               
            if(usuario.Id == id)
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
                                  
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var usuario = context.Usuario.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario != null)
            {
                context.Usuario.Remove(usuario);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
