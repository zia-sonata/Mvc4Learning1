using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc4App1.Models
{
    public class Interview
    {
        public int Id { get; set; }

        [Required]
        public string Company { get; set; }

        [DataType(DataType.MultilineText)]
        public string Questions { get; set; }

        public int Status { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public DateTime Date { get; set; }
    }
}