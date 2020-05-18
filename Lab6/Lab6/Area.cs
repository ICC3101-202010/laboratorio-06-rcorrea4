using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Area: Division
    {
        public Area(string nameDivision):base(nameDivision)
        {
            this.NameDivision = NameDivision;
        }
    }
}
