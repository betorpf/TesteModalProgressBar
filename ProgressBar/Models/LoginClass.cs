using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgressBar.Models
{
    public class LoginClass
    {

        [Required(ErrorMessage = "Preencha o Usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Preencha a Senha")]
        [DataType("password")]
        public string Senha { get; set; }



    }
}