﻿using AlbergueAnimal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbergueAnimal.Models
{
    /// <summary>
    /// Classe que representa um animal para ser adotado.
    /// </summary>
    /// <remarks>
    /// Representada através dos atributos AnimalId, RacaId, Nome, Genero, Cor, DataNascimento, DataEntrada e DataVacina.
    /// </remarks>
    public class Animal
    {
        // vai ser chave primária
        public int AnimalId { get; set; }

        // vai ser chave estrangeira
        /// <summary>Propriedade RacaID representa a raça do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Vai buscar o nome da raça ao model Raca.</value>
        [Display(Name = "Raça")]
        public int RacaId { get; set; }

        /// <summary>Propriedade Nome representa o nome do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados e deverá conter no maximo 15 caracteres.</value>
        [Required(ErrorMessage = "O Nome é obrigatório"), StringLength(15)]
        public String Nome { get; set; }

        /// <summary>Propriedade Genero representa o género do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Display(Name = "Género")]
        [Required(ErrorMessage = "O Genero é obrigatório")]
        public String Genero { get; set; }

        /// <summary>Propriedade Cor representa a cor do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Display(Name = "Cor")]
        [Required(ErrorMessage = "A Cor é obrigatória")]
        public String Cor { get; set; }

        /// <summary>Propriedade DataNascimento representa a data de nascimento do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [Display(Name = "Data De Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        /// <summary>Propriedade DataEntrada representa a data de entrada do animal no canil.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "A data de entrada é obrigatória")]
        [Display(Name = "Data De Entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }

        /// <summary>Propriedade DataVacina representa a data da ultima vacina do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "A data da última vacina é obrigatória")]
        [Display(Name = "Data Da Última Vacina")]
        [DataType(DataType.Date)]
        public DateTime DataVacina { get; set; }

        /// <summary>Propriedade imageContent representa o conteudo da imagem do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [ScaffoldColumn(false)]
        public byte[] imageContent { get; set; }

        /// <summary>Propriedade imageMimeType representa o tipo da imagem do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [StringLength(256)]
        [ScaffoldColumn(false)]
        public String imageMimeType { get; set; }

        /// <summary>Propriedade imageFileName representa o nome da imagem do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [StringLength(100, ErrorMessage = "O nome do ficheiro não pode ser mostrado")]
        [Display(Name = "Nome do Ficheiro")]
        [ScaffoldColumn(false)]
        public String imageFileName { get; set; }

        /// <summary>Propriedade Arquivado representa se a ficha de um animal está ou não arquivada.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [Display(Name = "Arquivado")]
        public bool Arquivado { get; set; }

        //propriedade navigacional
        /// <summary>Propriedade Raca representa a raça do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Vai buscar o nome da raça ao model Raca.</value>
        [Display(Name = "Raça")]
        public virtual Raca Raca { get; set; } //o que aparece na página


        public virtual List<Adocao> Adocao { get; set; }

        /// <summary>Propriedade visualizacoes representa o numero de visualizacoes do animal para adoção.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [Display(Name = "Vizualizações")]
        public  int  visualizacoes { get; set; }


    }
}
