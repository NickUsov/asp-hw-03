using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication8.Models;

namespace WebApplication8.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Bazuka>().WithConstructorArgument("weapon", new Bazuka());
            Bind<IWeapon>().To<Sword>().WithConstructorArgument("weapon", new Sword());
        }
    }
}