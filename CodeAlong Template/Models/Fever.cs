﻿using System.ComponentModel.DataAnnotations;

namespace fever.Models
{
    public class Fever
    {
        [Required(ErrorMessage = "Please enter tempure level")]
        public float CheckFever { get; set; }
        public string Unit { get; set; }
        public bool Ishypothermia { get; set; }
    }
}