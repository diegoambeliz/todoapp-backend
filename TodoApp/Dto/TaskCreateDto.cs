﻿using System.ComponentModel.DataAnnotations;

namespace TodoApp.Dto
{
    public class TaskCreateDto
    {
        [Required]
        [MaxLength(250, ErrorMessage = "The {0} field must be less than 250 characters.")]
        public string description { get; set; } = string.Empty;
        [Required]
        public string status { get; set; } = string.Empty;
        [Required]
        public DateTime deadline { get; set; } = DateTime.MinValue;
    }
}
