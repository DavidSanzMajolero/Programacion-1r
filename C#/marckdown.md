#PROVES FUNCIONALS
-----
##EX1
*Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.*

```
using System;
namespace Exercicis
{
    public class Ex1
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            AddTwoNumbers(num, num2);
        }
        public static void AddTwoNumbers(int first, int second)
        {
            if (first > 0) Console.WriteLine("El primer numero es natural");
            else if (first <= 0) Console.WriteLine("El primer numero no es natural");
            if (second > 0) Console.WriteLine("El segon numero es natural");
            else if (second <= 0) Console.WriteLine("El segon numero no es natural");
        }
    } 

}
```
*Clases d'equivalencia:*
>**num**:
>: Clase vàlida: *1,5,10,20,40*
>: Clase invàlida: *-1,-5,-10,-20,-40*

>**numDos**:
>: Clase vàlida: *1,5,10,20,40*
>: Clase invàlida: *-1,-5,-10,-20,-40*


>**Valors límit**
>: *-5,0,5*

##EX 2
```
using System;
namespace Exercicis
{
    class Ex2
    {
        public static void Main()
        {
            int numBase, numExp;
            numBase = Convert.ToInt32(Console.ReadLine());
            numExp = Convert.ToInt32(Console.ReadLine());
            Exponent(numBase, numExp);
        }
        public static void Exponent(int numberOne, int numberTwo)
        {
            int mem = 0;
            mem = numberOne;
            if (numberTwo == 0) Console.WriteLine("1");
            else 
            {
                for (int i = 0; i < numberTwo - 1; i++)
                {
                    numberOne *= mem;
                }
                Console.WriteLine(numberOne);
            }
        }
    }
}
```
*Clases d'equivalencia:*
>**numBase**:
>: Clase vàlida: *0,4,45,55,80*
>: Clase invàlida: *-0,-4,-45,-55,-80*

>**numExp**:
>: Clase vàlida: *0,15,20,26,40*
>: Clase invàlida: *-0,-15,-20,-26,-40*

>**Valors límit**
>: *-10,0,10*

##EX11
*Implementa un programa que demani un valor per teclat i retorni el seu factorial.*

```
using System;
namespace Project
{
    public class Ex11
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numTwo = Factorial(num);
            Console.WriteLine(numTwo);
        }
        public static int Factorial(int num)
        {
            int mem = num;
            for (int i = num-1; i > 0; i--) 
            {
                mem *= i;
            }
            return mem;
        }
    }
}

```
*Clases d'equivalencia:*
>**num**:
>: Clase vàlida: *1,5,10,20,40*
>: Clase invàlida: *-1,-5,-10,-20,-40*



>**Valors límit**
>: *0,1,(Infinit)*

#PROVES ESTRUCTURALS
---
##EX1
```
using Project;
namespace ValidationTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 3;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int num = 6;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int num = -5;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
    }
}
```
*Inputs*
> Test 1:
>: num = 3

> Test 2:
>: num = 6

> Test 3:
>: num = -5 

*Sortida*
> Test 1:
>: True

> Test 2:
>: True

> Test 3:
>: False

##EX11
```
using Project;
namespace ValidationTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 3;

            int result = Ex11.Factorial(num);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod2()
        {


        }
        [TestMethod]
        public void TestMethod3()
        {

        }
    }
}
```
*Inputs*
> Test 1:
>: 

> Test 2:
>: 

> Test 3:
>: 

*Sortida*
> Test 1:
>: 

> Test 2:
>: 

> Test 3:
>: 