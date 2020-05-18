using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6
{
    [Serializable]
    class Empresa
    {
        private string nameEmpresa;
        private string rutEmpresa;
        private List<Division> divisiones = new List<Division>();
        

        public string NameEmpresa { get => nameEmpresa; set => nameEmpresa = value; }
        public string RutEmpresa { get => rutEmpresa; set => rutEmpresa = value; }
        internal List<Division> Divisiones { get => divisiones; set => divisiones = value; }
        

        public Empresa (string nameEmpresa,string rutEmpresa)
        {
            this.nameEmpresa = nameEmpresa;
            this.rutEmpresa = rutEmpresa;
        }
        public void serializarEmpresa()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static void desserializarEmpresa()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Empresa empresa1 = (Empresa)formatter.Deserialize(stream);
            Console.WriteLine("Empresa: "+empresa1.nameEmpresa);
            Console.WriteLine("Rut: "+empresa1.rutEmpresa);
            Console.WriteLine("Division: "+empresa1.divisiones[0].NameDivision);
            stream.Close();
        }
    }
}
