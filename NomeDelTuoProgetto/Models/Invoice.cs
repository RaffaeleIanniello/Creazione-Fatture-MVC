using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomeDelTuoProgetto.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string NumeroFattura { get; set; }
        public DateTime DataEmissione { get; set; }
        public decimal Importo { get; set; }
    }
}