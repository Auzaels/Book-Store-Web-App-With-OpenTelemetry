﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Role")]

        [Required(ErrorMessage = "Rol Adı gereklidir")]

        public string RoleName { get; set; }

        public List<string> Users { get; set; } = new();
    }
}