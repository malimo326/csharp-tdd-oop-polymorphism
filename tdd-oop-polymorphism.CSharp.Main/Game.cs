﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : Interface1
    {
        public string Name { get; set; }
        public int price { get; set; }

        public Game(string name, int price)
        {
            this.Name = name;
            this.price = price;
        }

       
    }
}
