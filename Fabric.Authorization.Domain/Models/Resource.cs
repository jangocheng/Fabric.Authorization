﻿using System;
using System.Collections.Generic;

namespace Fabric.Authorization.Domain.Models
{
    public class Resource
    {
        public Resource()
        {
            Resources = new List<Resource>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}