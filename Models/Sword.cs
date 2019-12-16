using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Sword : IWeapon
    {
        public string Kill()
        {
            return "The sword cuts the enemy";
        }
    }
}