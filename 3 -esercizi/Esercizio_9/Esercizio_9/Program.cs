using Esercizio_9;
using System;
using System.Xml.Linq;

class program
{
    static void Main(string[] args)
    {

        List<Prodotto> prodottiLista = new List<Prodotto>
        { 
            new Prodotto { ProdottoId = 1, ProdottoNome = "Latte", CategoriaId = 101 },
            new Prodotto { ProdottoId = 2, ProdottoNome = "Pane", CategoriaId = 124 },
            new Prodotto { ProdottoId = 2, ProdottoNome = "Torta", CategoriaId = 240 },
        };

        List<Categoria> categorieList = new List<Categoria>
        {
            new Categoria {CategoriaID = 101, CategoriaNome = "Prodotti Freschi"},
            new Categoria {CategoriaID = 124, CategoriaNome = "Panificeria"},
        };
     
        var JoinLista = from prodotto in prodottiLista
                        join categoria in categorieList on prodotto.CategoriaId equals categoria.CategoriaID
                        select new { prodotto.ProdottoId, prodotto.ProdottoNome, prodotto.CategoriaId, categoria.CategoriaNome };

        Console.WriteLine("La lista della spesa\n");
        foreach(var u in JoinLista)
        {
            Console.WriteLine($"Prodotto: {u.ProdottoNome} \nCategoria: {u.CategoriaNome}\n");
        }
    }


}

