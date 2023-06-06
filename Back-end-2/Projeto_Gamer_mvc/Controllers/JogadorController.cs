using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer_mvc.Infra;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        // Contexto / objeto de comunicação com o banco de dados
        Context context = new Context();

        // Listagem de Jogadores
        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = context.Jogador.ToList();
            ViewBag.Equipe = context.Equipe.ToList();

            return View();
        }


        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"]!);

            context.Jogador.Add(novoJogador);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Remover")]
        public IActionResult Remover(int id)
        {
            Jogador jogadorPesquisado = context.Jogador.First(j => j.IdJogador == id);
            context.Remove(jogadorPesquisado);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar")]
        public IActionResult Editar(int id)
        {
            
            
            return;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}