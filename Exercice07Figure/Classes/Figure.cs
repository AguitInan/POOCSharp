using Exercice07Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        private Point _origine;

        internal Point Origine { get => _origine; set => _origine = value; }
    }
}



