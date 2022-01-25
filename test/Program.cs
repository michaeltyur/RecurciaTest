using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Steps steps = new Steps();
            //Console.WriteLine();
            HalfDivider halfDivider = new HalfDivider();        
            Console.ReadLine();
        }



    }
    enum OperationEmum
    {
        APPEND = 1,
        MOVE,
        DELETE,
        SELECT,
        CUT,
        PASTE,
        UNDO,
        REDO,
        SWITCH
    }
}

