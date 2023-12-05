using Lab13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class Houses
    {
        House[] houses = new House[10];
        public House this[int index]
        {
            get => houses[index];
            set => houses[index] = value;
        }
        public Houses(House[] houses)
        {
            this.houses = houses;
        }
    }
}
