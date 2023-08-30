// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;
namespace atividades{

    public class atividade1{
        public static void Main(string[] args){

    		Console.WriteLine("Digite Um Numero:");
		    int numero = Int32.Parse(Console.ReadLine());
		    Console.WriteLine("O Numero Informado é: " + numero);
        }
    }
}

// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

using System;
namespace atividades{

	public class atividades2{
    	public static void Main(string[] args){	
			Console.WriteLine("Informe o Seu Nome:");
			string nome = Console.ReadLine();
		
			Console.WriteLine("Informe o Seu Sobrenome:");
			string ultimoNome = Console.ReadLine();
		
			Console.WriteLine("Seu Nome é "+ nome +" "+ ultimoNome);
	
    	}
	}
}


// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

using System;
namespace atividades{
	
	public class atividades3{
    	public static void Main(string[] args){
		
			Console.WriteLine("Informe o Ano em que você nasceu: ");
			int ano = Convert.ToInt32(Console.ReadLine());	
			
			int idadeAtual= DateTime.Now.ano;
			
			int idade = idadeAtual - ano;
			
			Console.WriteLine("Vocẽ tem "+ idade +"Anos");
		}
	}
}

// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.
using System;
namespace atividades{

	public class atividades4{
        public static void Main(string[] args){

		    Console.WriteLine("Informe Um Numero:");
		    int numero = Convert.ToInt32(Console.ReadLine());
		    for(int i = 0;i<=10;i++){
		    Console.WriteLine(numero +" X "+ i + " = "+ numero*i);
            
            }
        }
    }
}


// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.
using System;
namespace atividades{

	public class atividades5{
        public static void Main(string[] args){

            Console.WriteLine("Informe Um Numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0){
                Console.WriteLine("O Numero digitado é par");
            }else{
                Console.WriteLine("O Numero digitado é Impar");
            }
        }
    }
}


// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.
using System;
namespace atividades{

	public class atividades6{
        public static void Main(string[] args){
            Console.WriteLine("Informe o primeiro numero: ");
            int num01 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo numero: ");
            int num02= Convert.ToInt32(Console.ReadLine());
            
            if(num01 == num02){
                int triplo = (num01+num02) * 3;
                Console.WriteLine(triplo);
            }else{
                Console.WriteLine(num01+num02);
		    }	
        }
    }
}