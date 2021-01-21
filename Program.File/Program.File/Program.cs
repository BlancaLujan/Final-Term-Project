using System;
using Program.File.MyClasses;
using Program.File.DTOS;

namespace Program.File
{
    class Program
    {
        static void Main()
        {

            ConcatenationOfStrings("my first sting", "my second string");
        }

        static void ConcatenationOfStrings(string parameter1, string parameter2)

        {

            string result = parameter1 + " " + parameter2;


            Console.WriteLine(result);


            Comment comment = new Comment();
            
            comment.Comments = "This is a comment";

            Console.WriteLine("The value of my first property is:" + comment.Comments);




            ImageDTOS Image = new ImageDTOS();
            Image.ImageNumber = ("This is image number 1");
            Console.WriteLine("The value of my first property is;" + Image.ImageNumber);

        }
    }
}
