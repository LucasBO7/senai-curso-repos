using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }


        [TempData]
        public string? Message { get; set; }

        Context context = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.LoggedUserName = HttpContext.Session.GetString("UserName");
            return View();
        }


        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = context.Jogador.FirstOrDefault(j => j.Email == email && j.Senha == senha)!;

            // Lógica da sessão

            // Se encontrar o jogador
            if (jogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome); // Insere um valor string preso à uma chave, na Session HTTP
                return LocalRedirect("~/");
            }
            Message = "Dados inválidos, tente novamente";
            return LocalRedirect("~/Login/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}