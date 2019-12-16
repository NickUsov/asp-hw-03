using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Warrior
    {
        IWeapon weapon = null;
        public Warrior(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public string Shoot()
        {
            return this.weapon.Kill();
        }
    }
}