using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        // Instância do objeto da classe Context: acessa o banco de dados
        Context context = new Context();

        [Route("Listar")] // https://localhost/Equipe/Listar
        public IActionResult Index()
        {
            // "mochila" que contém a lista das equipes
            // podemos usar essa "mochila" na view de equipe
            ViewBag.Equipe = context.Equipe.ToList();

            // retorna a view da equipe
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            // vem como string, o que precisamos é uma imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            context.Equipe.Add(novaEquipe);
            context.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}