using CrudMvc.Models.Contexto;
using CrudMvc.Models.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvc.Controllers
{
    public class EscolasController : Controller
    {
        private readonly Contexto _contexto;
        public EscolasController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Listar()
        {
            var lista = _contexto.Escola.Include(e => e.Fotos).ToList();
            CarregarTipoEscola();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var escola = new Escola();
            CarregarTipoEscola();
            return View(escola);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Escola escola, List<IFormFile> Fotos)
        {
            if (ModelState.IsValid)
            {
                foreach (var foto in Fotos)
                {
                    if (foto != null && foto.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            await foto.CopyToAsync(ms);
                            var fotoEntity = new Foto
                            {
                                ImageData = ms.ToArray()
                            };
                            escola.Fotos.Add(fotoEntity);
                        }
                    }
                }
                _contexto.Escola.Add(escola);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Listar));
            }
            CarregarTipoEscola();
            return View(escola);
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            var escola = _contexto.Escola.Find(Id);
            CarregarTipoEscola();
            return View(escola);
        }

        [HttpPost]
        public IActionResult Editar(Escola escola)
        {
            if (ModelState.IsValid)
            {
                _contexto.Escola.Update(escola);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Listar));
            }
            else
            {
                CarregarTipoEscola();
                return View(escola);
            }
        }

        [HttpGet]
        public IActionResult Remover(int Id)
        {
            var escola = _contexto.Escola.Find(Id);
            CarregarTipoEscola();
            return View(escola);
        }

        [HttpPost]
        public IActionResult Remover(Escola _escola)
        {
            var escola = _contexto.Escola.Find(_escola.Id);
            if (escola != null)
            {
                _contexto.Escola.Remove(escola);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Listar));
            }
            return View(escola);
        }

        [HttpGet]
        public IActionResult Detalhes(int Id)
        {
            var escola = _contexto.Escola.Find(Id);
            CarregarTipoEscola();
            return View(escola);
        }

        [HttpGet]
        public void CarregarTipoEscola()
        {
            var itensTipoEscola = new List<SelectListItem>
            {
                new() { Value = "1", Text = "Municipal" },
                new() { Value = "2", Text = "Estadual" },
                new() { Value = "3", Text = "Federal" }
            };

            ViewBag.TipoEscola = itensTipoEscola;
        }

        [HttpGet]
        public JsonResult BuscarFotos(int escolaId)
        {
            var fotos = _contexto.Foto
                                .Where(f => f.EscolaId == escolaId)
                                .Select(f => new { f.ImageData })
                                .ToList();
            return Json(fotos);
        }
    }
}
