namespace Classessss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Messages messages = new Messages();
            // string name = messages.name;
            // Console.WriteLine(name);
            // int age = messages.age;


            //string name1 =  Console.ReadLine();
            // int age1 = Convert.ToInt32(Console.ReadLine()); 


            // Messages message1 = new Messages(name1,age1);
            // Console.WriteLine(message1.name);
            // Console.WriteLine(message1.age);

            //Diamond pattern = new Diamond();
            //pattern.pattern(5);

            Modifiers modifier = new Modifiers();
            modifier.add(1, 2, 3, 4, 5);

            int a ;

            modifier.ChangeValue(out a);

            Console.WriteLine(a);
            
        }
    }
}
