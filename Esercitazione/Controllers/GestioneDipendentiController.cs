using Esercitazione.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esercitazione.Controllers
{
    public class GestioneDipendentiController : Controller
    {
        // GET: GestioneDipendenti
        public ActionResult Index()
        {
            var dipendenti = FakeDB.Dipendenti ?? new List<Dipendente>();
            return View(dipendenti);
        }

        public ActionResult AggiungiDipendente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AggiungiDipendente(Dipendente dipendente)
        {
            FakeDB.Dipendenti.Add(dipendente);
            return RedirectToAction("Index");
        }

        public ActionResult RegistraPagamento()
        {
            var dipendenti = FakeDB.Dipendenti;
            var dipendentiSelectList = dipendenti.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Nome + " " + d.Cognome
            }).ToList();

            ViewBag.Dipendenti = dipendentiSelectList;
            return View();
        }

        [HttpPost]
        public ActionResult RegistraPagamento(Pagamento pagamento)
        {
            FakeDB.Pagamenti.Add(pagamento);
            return RedirectToAction("Pagamenti");
        }

        public ActionResult Pagamenti()
        {
            return View(FakeDB.Pagamenti);
        }

    }
}