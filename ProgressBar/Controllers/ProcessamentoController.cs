using ProgressBar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ProgressBar.Controllers
{
    public class ProcessamentoController : Controller
    {
        // GET: Processamento
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult ObterInformacoesProcessamento(string LoteID)
        {


            RetornoProcessamento proc = new RetornoProcessamento();

            int tempo_agora = DateTime.Now.Second;
            
            proc.Sucesso = tempo_agora;
            proc.Falha = 60 - tempo_agora;

            proc.Pendente = 100 - proc.Sucesso - proc.Falha;

            proc.Total = proc.Pendente + proc.Sucesso + proc.Falha;

            return PartialView(proc);
        }

        public ActionResult Processamento()
        {

            for(int i = 0; i < 200; i++)
            {
                Thread.Sleep(500);
            }

            return View();
        }


    }
}

/*
 * https://www.mindstick.com/Articles/1132/auto-refresh-partial-view-in-asp-dot-net-mvc
 */
