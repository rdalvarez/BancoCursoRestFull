﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{

    //Entidad Base para que todas las entidades que creamos hereden de esta
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public required string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public required string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
