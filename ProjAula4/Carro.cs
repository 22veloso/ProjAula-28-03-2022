using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula4
{
    public class Carro
    {
        #region Propiedades
        public int Id { get; set; }
        public string Marca { get; set; }
        public String Modelo { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public String Cor { get; set; }
        public int velocidade { get; set; }

        public bool StatusCarro { get; set; }
        public bool Buzinar { get; set; }
        public bool Ar { get; set; }
        #endregion

        #region Metodos
        public void Acelerar(int velocidade)
        {
            this.velocidade += velocidade;

        }

        public void Frear(int velocidade)
        {
            this.velocidade -= velocidade;
        }

        public void Ligar()
        {
            this.StatusCarro = true;
        }

        public void Desligar()
        {
        this.StatusCarro = false;
            }
        public void LigarBuzina()
        {
            this.Buzinar = true;
        }
        public void DesligarBuzina()
        { this.Buzinar = false; 
        }
        public void LigarAr()
        {
            if (this.Ar == false)
            {
                if (this.StatusCarro == true)
                    this.Ar = true;
                else
                    Console.WriteLine("o carro esta desligado!");
            }
            else
            {
                Console.WriteLine("o ar esta ligado!");
            }
        }
        public void DesligarAr()
        { this.Ar = false; }
         
        public override string ToString()
        {
            return "Id: " + this.Id +
                   "\nModelo: " + this.Modelo +
                   "\nMarca: " + this.Marca +
                   "\nAno Modelo: " + this.AnoModelo +
                   "\nAno Fabricação: " + this.AnoFabricacao +
                   "\n cor: " + this.Cor +
                   "\n Status Carro: " + this.StatusCarro +
                   "\nVelocidade: " + this.velocidade +
                   "\nBuzina: " + this.Buzinar +
                   "\nAr: " + this.Ar;
        }
        #endregion
    }
}
