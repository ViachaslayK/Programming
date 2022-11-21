    internal class Operator_sdviga
    {
       static void Main()
       {
        short val = 1;
        short val1 = 128;
          for(int i = 0;i<8;i++)
          {
             for(int t = 128; t > 0; t = t / 2)
             {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
                
             }
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val1 & t) != 0) Console.Write("1 ");
                if ((val1 & t) == 0) Console.Write("0 ");

            }
            Console.WriteLine();
            val=(short)(val << 1);
            val1 = (short)(val1 >> 1);

        }
        val = 128;
        val1 = 1;
        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val1 & t) != 0) Console.Write("1 ");
                if ((val1 & t) == 0) Console.Write("0 ");
            }

            Console.WriteLine();
            val = (short)(val >> 1);
            val1 = (short)(val1 << 1);
        }

       }
    }
