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
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
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
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            
            Jogador jogadorPesquisado = context.Jogador.First(e => e.IdJogador == id);
            ViewBag.Jogador = jogadorPesquisado;
            ViewBag.Equipe = context.Equipe.ToList();

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            // Passa os valores das propriedades do form para um objeto
            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            // Procura a equipe que será modificada
            Jogador jogadorPesquisado = context.Jogador.First(j => j.IdJogador == novoJogador.IdJogador);

            // Passa os valores do jogador criado para o jogador já existente
            jogadorPesquisado.Nome = novoJogador.Nome;
            jogadorPesquisado.Email = novoJogador.Email;
            jogadorPesquisado.Senha = novoJogador.Senha;
            jogadorPesquisado.IdEquipe = novoJogador.IdEquipe;
            // jogadorPesquisado = novoJogador;

            context.Jogador.Update(jogadorPesquisado);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}