using ProgressBar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgressBar.Controllers
{
    public class Teste02Controller : Controller
    {
        // GET: Teste02
        public ActionResult Index()
        {
            Lote lote = new Lote();
            lote.IDLote = "3001-3795";
            lote.IDLote = "Lote Principal";

            return View(lote);
        }

        [HttpPost]
        public ActionResult Processamento()
        {

            for (int i = 0; i < 200; i++)
            {
                System.Threading.Thread.Sleep(500);
            }

            return View();
        }

        [HttpGet]
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

        [HttpPost]
        public ActionResult ModalLoginPartial()
        {
            return PartialView("_ModalLogin");
        }

    }
}