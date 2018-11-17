﻿using System.ComponentModel.DataAnnotations;

namespace WebApiSample.DataAccess.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }


        [Required]
        public string PassWord { get; set; }

    }
}
