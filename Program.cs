using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula__08_ListadeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            /*
             -------------ARRAYS E LISTAS
            Tanto um como ouutro servem para guardar um conjunto de dados
            dentro de uma mesma variável em #C
            
            Os arrays são limitados. 
            É preciso definir um tamanho limite ao criar um novo array, exemplo:
            string[]





               */
            List<string> nomes = new List<string>();

            nomes.Add("MILY");
            nomes.Add("Carolina");
            nomes.Add("Cecília");
            
            Console.WriteLine("A PRMIEIRA POSIÇÃO É "+nomes[0]);
            Console.WriteLine("A SEGUNDA POSIÇÃO É " + nomes[1]);
            Console.WriteLine("A TERCEIRA POSIÇÃO É " + nomes[2]);

            nomes.Remove("Carolina");
            //nomes.RemoveAt(1);
           
            int QUANTIDADE = nomes.Count;
            Console.WriteLine($"Existem {QUANTIDADE} itens dentro da lista");





            Console.ReadKey();
        }

        void Arrays()
        {

            string[] nomes = new string[3];
            Console.WriteLine("Digite um nome pra posição");
            nomes[0] = Console.ReadLine();

            int[] idades = { 19, 20, 18, 19, 31, 25 };
            
            nomes[0] = "Emily";
            nomes[2] = "Camila";
            nomes[1] = "Kethy";



            Console.WriteLine("O nome da primeira posição é" + nomes[0]);
            Console.WriteLine("O nome da segunda posição é" + nomes[0]);
            Console.WriteLine("O nome da terceira posição é" + nomes[0]);


            Console.ReadKey();


             }


        void atividade()
        {

            string nome;
            int numero;
           
            Console.WriteLine("Digite uma opção");
            numero = int.Parse(Console.ReadLine());


            if= (numero-- - 1;
            {

                numero = 



            }
            else
            {


                Console.WriteLine($"Digite o {nome} que deseja cadastrar");



            }



        }



        void contéudo novo()
        {
          //Retições (loop)
          while (1 > 0)
            {



            }





        }

















    }
}
