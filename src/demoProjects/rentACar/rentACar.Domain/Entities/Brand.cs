﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Domain.Entities
{
    public class Brand : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brand()
        {

        }
        //Ortak alanların aynı base üzerinden çalıştırılabilmesi
        public Brand(int id , string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}
