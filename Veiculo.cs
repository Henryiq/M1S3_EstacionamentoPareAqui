using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_EstacionamentoPareAqui
{
    public class Veiculo
    {
        public int Id { get; set; }
        public int Velocidade { get; set; }
        public string Cor { get; set; }
        public int Km { get; set; }
        public string TipoVeiculo { get; set; }
        public Veiculo(int id, int velocidade, string cor, int km, string tipoVeiculo)
        {
            Id = id;
            Velocidade = velocidade;
            Cor = cor;
            Km = km;
            TipoVeiculo = tipoVeiculo;
        }
        public Veiculo(int id, int velocidade, string cor, int km)
        {
            Id = id;
            Velocidade = velocidade;
            Cor = cor;
            Km = km;
        }
        public Veiculo(int id, int velocidade, string cor)
        {
            Id = id;
            Velocidade = velocidade;
            Cor = cor;
        }
        public Veiculo(int id, int velocidade)
        {
            Id = id;
            Velocidade = velocidade;
        }
        public Veiculo(int id)
        {
            Id = id;
        }
        public Veiculo()
        {
        }

        public void Acelerar()
        {

        }
        public void Parar()
        {

        }
        public void ImprimirVeiculo()
        {

        }
    }
}