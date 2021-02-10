using System;
using System.Collections;

namespace Question2
{
    class Program
    {
        //Question 2
        static void Main(string[] args)
        {
            //a.Create a new list “newlist” as shown above.
            ArrayList arraylist = new ArrayList() { 11,"csharp",300," ",4.5f," "};

            //b. Access all individual item
            Console.WriteLine("------Access all individual item in ArrayList------\n");
            foreach (object obj in arraylist)
                Console.WriteLine(obj + "");

            //c.Update the second element to “updatedcsharp”
            arraylist[1] = "updatedcsharp";
            Console.WriteLine("------update in ArrayList------\n");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj + "");
            }

            //d.Insert new integer element at index 1.
            arraylist.Insert(1, 12);
            Console.WriteLine("------Insert new integer element at index 1.  in ArrayList------\n");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj + "");
            }

            //e.Remove the second null element.
            arraylist.RemoveAt(6);
            Console.WriteLine("------Insert new integer element at index 1.  in ArrayList------\n");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj + "");
            }

            //f. Check whether an element “csharp” exists in the array list or not
            Console.WriteLine("------ Check whether an element “csharp” exists in the array list or not------\n");
            if (arraylist.Contains("csharp"))
                Console.WriteLine("csharp exist in arraylist");
            else 
                Console.WriteLine("csharp not exist in arraylist");
            Console.ReadLine();
           
        }
    }
}
