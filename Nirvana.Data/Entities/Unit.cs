using Nirvana.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nirvana.Data.Entities
{
    public class Unit : IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double IncreaseAmount { get; set; }
    }
}
