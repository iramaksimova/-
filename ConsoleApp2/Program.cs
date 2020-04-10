﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monster
    {
        public Monster()
        {
            this.health = 100;
            this.ammo = 100;
            this.name = "Noname";
        }

        public Monster(string name) : this()
        {
            this.name = name;
        }

        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }

        public int Ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);



        }

        string name;
        int health, ammo;
    }
}


