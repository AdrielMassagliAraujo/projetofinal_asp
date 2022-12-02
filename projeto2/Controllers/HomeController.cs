using projeto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Persona()
        {
            var persona = new persona(); //criando o objeto para a classe
            return View(persona);        //retornar para a view os dados da classe
        }

        [HttpPost]
        public ActionResult Persona(persona persona)
        {
            if (ModelState.IsValid) //validando o estado, ou seja, verificando a requisição
            {
                return View("Resultado", persona); //retorna para a view Resultado
            }
            return View(persona);
        }

        public ActionResult Resultado(persona usuario) //criando a ação para a view resultado
        {
            return View(usuario);
        }
    }
}