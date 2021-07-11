using System;

namespace Api.Models
{
    public class InfectadoDto
    {
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string Strain { get; set;}
        //ideias de funcionalidade: adicionar strain ou severidade da doença em escala de 1 a 5 a ser elaborada
    }
}