using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukolc_
{
    class Entity
    {
        public string Name { get; set; }

        public Entity(string name)
        {
            Name = name;
        }
    }

    class Enemy : Entity
    {
        public int BaseDamage { get; set; }
        public int Hp { get; set; }

        public Enemy(string name, int baseDamage, int hp) : base(name)
        {
            BaseDamage = baseDamage;
            Hp = hp;
        }

        public void Attack(Enemy enemy)
        {
            enemy.Hp -= this.BaseDamage;
            Console.WriteLine($"{this.Name} zautocil {enemy.Name}, nyni {enemy.Name} ma {enemy.Hp} Hp");
        }

        public override string ToString()
        {
            return $"{Name} BaseDamage: {BaseDamage} Hp: {Hp}";
        }
    }

}
