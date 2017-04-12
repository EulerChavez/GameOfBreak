﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameOfBreak.Models.GoB {

    [Table("AspNetUserRoles")]
    public class AspNetUserRoles {

        [Key]
        public string UserId { get; set; }

        public string RoleId { get; set; }

        //public virtual AspNetUsers User { get; set; }

        //public virtual AspNetRoles Role { get; set; }

    }

}