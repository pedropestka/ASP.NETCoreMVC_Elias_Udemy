﻿using Site01.Database;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Validation
{
    public class UnicoNomePalavraAttribute : ValidationAttribute
    {
        public object DabaseContext { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra;

            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));

            // verificar se já existe no banco de dados um registro:
            // - verificar se o nome já existe
            // - verificar se o id é o mesmo no banco

            var palavraBanco = _db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if (palavraBanco == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("O palavra '" + palavra.Nome + "' já existe no banco!");
            }

        }
    }
}
