using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionLINQ
{
    internal class Kund
    {
        public Kund(string name, string description) 
        { 
            this.Name = name;
            this.Description = description;
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}
