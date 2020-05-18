using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable]
    class Departamento: Division
    {
        public Departamento(string nameDivision) : base(nameDivision)
        {
            this.NameDivision = NameDivision;
        }
    }
}
