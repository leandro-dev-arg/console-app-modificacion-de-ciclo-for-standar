using System;

namespace U5_programa_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int a,contador;
            contador=0;
            Console.WriteLine("ingrese un numero por favor");
            a=int.Parse(Console.ReadLine());
           
//en este caso uso configuracion de no estandar,ya que si aplico x<a nunca llegara a contar hasta x, sino a x-7,asique arranco con x=1 y que llegue hasta a(x>=a),si la division de a con x me daresto eso entonces el contador suma 1, en este caso el contador cuenta la cantidad de divisores que dan resto 0, para que un numero sea primo, al dividir un numero (a) por 1 y por si mismo me tiene que dar 0
           for (int x = 1; x <=a; x++){
                if (a%x==0){                
                    contador++;
                }
           }
//aca estoy especificando que si el contador (que en ese caso cuenta la cantidad de divisores), es mayor a dos el numero no es primo, ya que los numeros primos solo tiene dos divisores que den resto 0
           if (contador==2){
                Console.WriteLine("el numero es primo");
           }else{
                Console.WriteLine("el numero NO es primo");
           }
            
           
            
                    
                
                    
                    
                
           

        }
    }
}
