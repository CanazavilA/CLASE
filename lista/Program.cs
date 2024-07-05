using System;

namespace miLibreria{

    class miClass{

        static void Main(){

            //asi funciona el VECTOR

            //declaracion de VECTOR
/*
            int[] vec = new int[2];

            vec[0] = 10;
            vec[1] = 15;

            Console.WriteLine("vamos con la clase de lista");
            Console.WriteLine(vec[0]);
            Console.WriteLine(vec[1]);
*/
            // Asi funciona la lista

            //Declaracion de lista
            List<int> miLista = new List<int>();

            
            miLista.Add(10);
            miLista.Add(15);
            miLista.Add(21);
            miLista.Add(3);
            miLista.Add(300);

             miLista.RemoveAt(3);

              miLista.Remove(300);

            Console.WriteLine("tamaño de lista:{0}", miLista.Count);

            Console.WriteLine("Recorriendo lista de foreach");

            foreach (var Elemento in miLista){
                Console.WriteLine("Elemento:{0}", Elemento);

                

                 List<string> Alumnos = new List<string>();

            
            Alumnos.Add("juan");
            Alumnos.Add("maria");

            Console.WriteLine("Cantidad de alumnos:{0}",Alumnos.Count);

            Console.WriteLine("Recorriendo lista de foreach");

            foreach (var clase in Alumnos){
                Console.WriteLine("clase:{0}", clase);


            }


        }
    }
}
}