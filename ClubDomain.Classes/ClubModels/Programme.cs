﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDomain.Classes.ClubModels
{
    public class Programme
    {
        [Key]
        [Column(Order =1)]
        public string Code { get; set; }
        [Key]
        [Column(Order = 2)]
        public string year { get; set; }
        public string Desription { get; set; }

        public virtual ICollection<Student> ProgrammeStudents { get; set; } 

        
    }
}
