using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosSantosCustomsDB.Model
{
    class Autos
    {
        public Autos() { }

        public Autos(int idauto, string? marca, string? modelo, int ano, int dispisponible)
        {
            this.idauto = idauto;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.disponible = disponible;
        }
        public int idauto { get; set; }
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public int ano { get; set; }
        public int disponible { get; set; }


    }
}
