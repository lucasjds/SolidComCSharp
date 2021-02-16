﻿using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
  public interface ILeilaoDao
  {
    IEnumerable<Categoria> BuscarCategoria();

    IEnumerable<Leilao> BuscarLeiloes();

    Leilao BuscaPorId(int id);

    void Incluir(Leilao leilao);


    void Alterar(Leilao leilao);

    void Excluir(Leilao leilao);
  }
}
