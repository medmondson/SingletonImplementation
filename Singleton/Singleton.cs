using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {
        }

        //Time
        public readonly DateTime _timeCreated = DateTime.Now;

        //Ninject kernel
        public readonly IKernel kernel = new StandardKernel();
    }
}