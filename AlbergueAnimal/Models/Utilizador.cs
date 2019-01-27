﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbergueAnimal.Models
{
    public class Utilizador : IdentityUser
    {
        /// <summary>Propriedade Nome representa o nome do utilizador.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required]
        [PersonalData]
        public string Nome { get; set; }

        /// <summary>Propriedade DBO representa a data de nascimento do utilizador.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required]
        [PersonalData]
        public DateTime DBO { get; set; }

        /// <summary>Propriedade Morada representa a morada do utilizador.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required]
        [PersonalData]
        public string Morada { get; set; }

        /// <summary>Propriedade Genero representa o género do utilizador.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required]
        [PersonalData]
        public string Genero { get; set; }



        public string UserEmail { get; set; }

        /// <summary>Propriedade FicheiroFoto representa a imagem a do utilizador.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>



        [ScaffoldColumn(false)]
        public byte[] imageContent { get; set; }

        [StringLength(256)]
       [ScaffoldColumn(false)]
        public String imageMimeType { get; set; }

        [StringLength(100, ErrorMessage = "O nome do ficheiro não pode ser mostrado")]
        [Display(Name = "Nome do Ficheiro")]
       [ScaffoldColumn(false)]
        public String imageFileName { get; set; }


        public string Cargo { get; set; }


        public virtual List<Adocao> Adocao { get; set; }




  }
}
