﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Veiculos")]
    class Veiculo
    {
        public Veiculo()
        {
            StatusVeiculo = "Disponivel";//Sempre que um veiculo é cadastrado ele já é setado como Disponivel
            CriadoEm = DateTime.Now;
        }
        public string NomeMarca { get; set; }
        public string NomeModelo { get; set; }
        public double ValorDia { get; set; }
        public string Placa { get; set; }
        public int Renavan { get; set; }
        public string TipoVeiculo { get; set; }
        public string TipoCombustivel { get; set; }
        public string Cor { get; set; }
        public string StatusVeiculo { get; set; }//Se esta ocupado ou disponivel
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome da marca: {NomeMarca} | Nome do Modelo: {NomeModelo} " +
                $"Valor por Dia: {ValorDia} | Placa do veiculo: {Placa} " +
                $"Numero do renavan: {Renavan} | Tipo de veiculo: {TipoVeiculo} " +
                $"Tipo de Combustivel: {TipoCombustivel} | Cor: {Cor} " +
                $"| Criado em: {CriadoEm}";
        }
    }
}

