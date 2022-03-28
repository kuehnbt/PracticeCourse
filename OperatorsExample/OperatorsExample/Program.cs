
   class Program
    {
        static void Main()
        {
        //Arithmetical Operators
        System.Console.WriteLine("Arithmetical Operators:");
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; //Output:13
        decimal d = a - b; //Output:7
        decimal e = a * b; //Output:30
        decimal f = a / b; //Output:3.333333
        decimal g = a % b; //Output:1

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        System.Console.WriteLine();  //Adds Blank Line


        //Assignment Operators
        System.Console.WriteLine("Assignment Operators:");
        a += 20M;
        System.Console.WriteLine(a); //Output:30
        a -= 20M;
        System.Console.WriteLine(a); //Output:10
        a *= 3M;
        System.Console.WriteLine(a); //Output:30
        a /= 3M;
        System.Console.WriteLine(a); //Output:10
        a %= 3M;
        System.Console.WriteLine(a); //Output:1
        System.Console.WriteLine();  //Adds Blank Line


        //Increment/Decrement Operators
        System.Console.WriteLine("Increment/Decrement Operators:");
        a = 10M;
        System.Console.WriteLine(++a); //Output:11
        System.Console.WriteLine(a++); //Output:11
        System.Console.WriteLine(a); //Output:12
        System.Console.WriteLine(--a); //Output:11
        System.Console.WriteLine(a--); //Output:11
        System.Console.WriteLine(a); //Output:10
        System.Console.WriteLine();  //Adds Blank Line

        //Comparison Operator
        System.Console.WriteLine("Comparison Operator:");
        bool b1 = a == 10;
        System.Console.WriteLine(b1); //Output: True
        bool b2 = a != 10;
        System.Console.WriteLine(b2); //Output: False
        bool b3 = a < 10;
        System.Console.WriteLine(b3); //Output: False
        bool b4 = a > 10;
        System.Console.WriteLine(b4); //Output: False
        bool b5 = a <= 10;
        System.Console.WriteLine(b5); //Output: True
        bool b6 = a >= 10;
        System.Console.WriteLine(b6); //Output: True
        System.Console.WriteLine();  //Adds Blank Line


        //Logical Operator
        System.Console.WriteLine("Logical Operator:");
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7); //Output: False
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8); //Output: False
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9); //Output: True
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10); //Output: True
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11); //Output: False
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12); //Output: True
        System.Console.WriteLine();  //Adds Blank Line


        //Concatenation Operator
        System.Console.WriteLine("Concatenation Operator:");
        string name = "Bob";
        int age = 20;
        string message = "Hello " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);
        System.Console.WriteLine();  //Adds Blank Line


        //Ternary Operator
        System.Console.WriteLine("Ternary Operator:");
        //Check if under 13, if yes Respond "Child"
        //Next Check if age between 13 and 19, if so respond Teenager
        //Otherwise respond Adult
        //Note: age is pulled from Concatenation variable assignment above.
        string title = (age<13)?"Child":(age>=13&&age<=19)?"Teenager":"Adult";
        System.Console.WriteLine(title);
        System.Console.WriteLine();  //Adds Blank Line


        //Operator Precedence
        System.Console.WriteLine("Operator Precedence:");
        //Multiplies 4 and 30.  Then divides that result by 10. Then Adds 10. Result should be 22 in this example.
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z); //Output: 22
        System.Console.WriteLine();  //Adds Blank Line

        System.Console.ReadKey();
    }
    }
