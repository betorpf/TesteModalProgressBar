using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgressBar.Models
{
    public class RetornoProcessamento
    {
        public String IDLote { get; set; }
        public int Pendente { get; set; }
        public int Sucesso { get; set; }
        public int Falha { get; set; }
        public int Total { set; get; }
    }
}