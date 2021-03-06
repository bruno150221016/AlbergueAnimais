﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlbergueAnimal.Models
{
    /// <summary>
    /// A Class that represents a adoption process in the system.
    /// It contains the identification of the Dog being adopted as well as the Client adoption it
    /// </summary>
    public class Adocao
    {


        //   /// <summary>
        //   /// Property that holds the Adoption Process' id.
        //   /// </summary>
        //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //   [Display(Name = "Número Processo")]
        //   public int AdocaoId { get; set; }

        //   /// <summary>
        //   /// Property that holds the Client Id
        //   /// </summary>
        //   [Display(Name = "Nome Utilizador")]
        //   public string UtilizadorNome { get; set; }

        //   [ForeignKey("UserName")]
        //   [Display(Name = "Utilizador")]
        //   [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        //   public Utilizador Utilizador { get; set; }

        //   /// <summary>
        //   /// Property that holds the Animal Id
        //   /// </summary>
        //   // public int AnimalId { get; set; }

        //   public int nomeAnimal { get; set; }

        //   /// <summary>
        //   /// Property that holds the Animal
        //   /// </summary>
        //   [Key]
        //   [ForeignKey("Nome")]
        //   [Display(Name = "Animal")]
        //   [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        //   public Animal Animal { get; set; }

        //   /// <summary>
        //   /// Property that holds the DateTime when the adoption process was created.
        //   /// </summary
        //   [Display(Name = "Criado em")]
        //   [DataType(DataType.Date)]
        //   public DateTime CreationDate { get; set; }

        //   /// <summary>
        //   /// Property that holds the DateTime when the adoption process was last updated/editd
        //   /// </summary>
        //   [Display(Name = "Atualizado em")]
        //   [DataType(DataType.Date)]
        //   public DateTime LastUpdated { get; set; }

        //   /// <summary>
        //   /// Property that holds the DateTime when the adoption process was Finished or Canceled
        //   /// </summary>
        //   [Display(Name = "Terminado em")]
        //   [DataType(DataType.Date)]
        //   public DateTime EndDate { get; set; }

        //   /// <summary>
        //   /// Property that holds the current status of the adoption process.
        //   /// </summary>
        //   //[Display(Name = "Estado")]
        //   //public ProcessStatus AdoptionProcessStatus { get; set; }

        //   [Display(Name = "Estado")]
        //   public int EstadoAdocaoId { get; set; }

        //   //[ForeignKey("estado")]
        //   [Display(Name = "Estado")]
        //   public EstadoAdocao EstadoAdocao { get; set; }



        //   /// <summary>
        //   /// Property that holds the Adoption Process' Notes
        //   /// </summary>
        //   //  public List<ProcessNote> Notes { get; set; }


        //   /// <summary>
        //   /// Represents the Duration of the Adoption Process. 
        //   /// </summary>
        //   /// <value>Returns the Duration, or null if the process is still on-going </value>
        //   //public TimeSpan? Duration
        //   //{
        //   //    get
        //   //    {
        //   //        if (EndDate == null)
        //   //        {
        //   //            return null;
        //   //        }
        //   //        return EndDate - CreationDate;
        //   //    }
        //   //}

        ////   public virtual Animal Animal { get; set; }
        ///
        [Key]
        public int AdocaoId { get; set; }

        [Display(Name = "Animal")]
        public int AnimalId { get; set; }

        [Display(Name = "Utilizador")]
        public string UserId { get; set; }

        [Display(Name = "Estado da Adoção")]
        public int EstadoAdocaoId { get; set; }

        /// <summary>Propriedade CreationDate representa a data de inicio do processo de adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Display(Name = "Data De Início")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        /// <summary>Propriedade LastUpdated representa a data da ultima atualização do processo de adoção.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Display(Name = "Última Atualização")]
        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }

        /// <summary>Propriedade LastUpdated representa a data da ultima atualização do processo de adoção.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [Display(Name = "Data de Fim")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Arquivado")]
        public bool Arquivado { get; set; }

        [ForeignKey("AnimalId")]
        public virtual Animal Animal { get; set; }

        [ForeignKey("UserId")]
        public virtual Utilizador Utilizador { get; set; }
        // public virtual IdentityUser Identity { get; set; }
        [Display(Name = "Estado Da Adoção")]
        [ForeignKey("EstadoAdocaoId")]
        public virtual EstadoAdocao EstadoAdocao { get; set; }
    }
}

