﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class City: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<District> Districts { get; set; }
    }
}
