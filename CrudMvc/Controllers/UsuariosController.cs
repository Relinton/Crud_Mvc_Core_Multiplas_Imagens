using CrudMvc.Models.Contexto;
using CrudMvc.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CrudMvc.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto _contexto;
        public UsuariosController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Listar()
        {
            var lista = _contexto.Usuario.ToList();
            CarregarTipoUsuario();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var usuario = new Usuario();
            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                _contexto.SaveChanges();

                return RedirectToAction(nameof(Listar));
            }
            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Listar));
            }
            else
            {
                CarregarTipoUsuario();
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Remover(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Remover(Usuario _usuario)
        {
            var usuario = _contexto.Usuario.Find(_usuario.Id);
            if (usuario != null)
            {
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Listar));
            }
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Detalhes(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregarTipoUsuario();
            return View(usuario);
        }

        [HttpGet]
        public void CarregarTipoUsuario()
        {
            var itensTipoUsuario = new List<SelectListItem>
            {
                new() { Value = "1", Text = "Administrador" },
                new() { Value = "2", Text = "Técnico" },
                new() { Value = "3", Text = "Usuário Normal" }
            };

            ViewBag.TipoUsuario = itensTipoUsuario;
        }
    }
}
