﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Grade:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
