using System;
using CodeLouisvilleLibrary;

namespace CodeLouAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleAppBase.Prompt4YesNo("Does this make sense? ");
            if (doesThisMakeSense)
                Console.WriteLine("I've got this!!!"); // previously, it was CodeLouisvilleProjectBase, so VS raised an error
                                                       // saying prompt4YesNo doesn't exist b/c of it, so it is now CodeLouisvilleAppBase instead
            else
                Console.WriteLine("Blame John");
        }
    }
}
