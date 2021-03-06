﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Calendar.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DataMember(Name = "id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }

        public abstract override string ToString();
    }
}
