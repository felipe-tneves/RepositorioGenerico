﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mvc_Repositorio.Dominio.Entidades
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Informe o login do usuário.")]
        [Display(Name = "Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe o email do usuário.")]
        public string Email { get; set; }
    }
}