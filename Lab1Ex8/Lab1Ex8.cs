/*Ex 8
Scrieti un program care interschimba valoarea a doua variabile intregi.*/

class Lab1Ex8 {

    static void Main() {

        int primulNumar, alDoileaNumar, temp;

        Console.WriteLine("Introdu prima valuare:");
        primulNumar = int.Parse(Console.ReadLine());
        Console.WriteLine("Introdu a doua valuare:");
        alDoileaNumar = int.Parse(Console.ReadLine());

        Console.WriteLine("Ups programul meu a interschimbat valorile tale:");
        temp = primulNumar;
        primulNumar = alDoileaNumar;
        alDoileaNumar = temp;
        Console.WriteLine(primulNumar + "," + alDoileaNumar);
    }

}


