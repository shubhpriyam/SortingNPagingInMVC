﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SortingNPagingInMVC.Models
{
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(20)")]
        [Display(Name = "Department Code")]
        public string Alias { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "Department Description")]
        public string DepartmentName { get; set; }

    }
}
