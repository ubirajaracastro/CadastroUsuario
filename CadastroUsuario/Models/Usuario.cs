using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroUsuario.Models
{
    public class Usuario
    {
        [Key]
        public int cod_cliente { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Campo inválido!", MinimumLength = 4)]
        public String nome { get; set; }


        [StringLength(100, ErrorMessage = "Campo inválido!", MinimumLength = 4)]
        public String sobrenome { get; set; }

        public String cpf { get; set; }

        public String telResidencial { get; set; }

        public String telCelular { get; set; }

        public String rg { get; set; }

        public String email { get; set; }

        public Cidade cidade { get; set; }
        public int cod_cidade { get; set; }

        [Column(TypeName = "CHAR")]
        public string Sexo { get; set; }
    }
}