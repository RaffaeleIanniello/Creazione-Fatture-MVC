using NomeDelTuoProgetto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NomeDelTuoProgetto.Controllers
{
    public class InvoiceController : Controller
    {
        
        public static List<Invoice> invoices = new List<Invoice>();

        public ActionResult Index()
        {
           
            decimal totalAmount = 0;
            foreach (var invoice in invoices)
            {
                totalAmount += invoice.Importo;
            }
            ViewBag.TotalAmount = totalAmount;

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Invoice invoice)
        {
            
            invoices.Add(invoice);

            return RedirectToAction("PartialView");
        }

        public new ActionResult PartialView()
        {
            return View(invoices);
        }
    }
}