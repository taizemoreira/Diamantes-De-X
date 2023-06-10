/**************************************************************
*  Nome do projeto: Diamante de X
*  Descrição: Dado um número ímpar, exiba um diamante desenhado com a letra ‘x’.
*  Autor: Taize Moreira
*  Ano: 2023
**************************************************************/
using System;

namespace DiamanteDeX
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input de Dados
            //solicitar inserção do numero ímpar
            Console.WriteLine("Digite um número ímpar:");            
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            //verifica se o numero é par
            while (tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("Erro: o número digitado não é ímpar.");
      
                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            #region Parte Superior
            int quantidadeEspacosEmBranco = (tamanhoDiamante - 1) / 2, quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;           
            int quantidadeDeX = 1;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacosEmBranco; i++)                
                    Console.WriteLine(" ");                
                for (int i = 0; i < quantidadeDeX; i++)
                    Console.Write("x");

                quantidadeEspacosEmBranco -= 1;
                quantidadeDeX += 2;

                Console.WriteLine();
            }
            #endregion

            # region Desenhando a linha do meio do diamante 
            for (int i = 0; i < tamanhoDiamante; i++)
                Console.Write("x");

            Console.WriteLine();

            #endregion

            #region Parte de baixo do diamante
            quantidadeEspacosEmBranco = 1;
            quantidadeDeX = quantidadeDeX - 2;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacosEmBranco; i++)
                    Console.Write(" ");
                for (int i = 0; i < quantidadeDeX; i++)
                    Console.Write("x");

                quantidadeEspacosEmBranco +=  1;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }
            #endregion         
            
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(); 
        }
    }
}