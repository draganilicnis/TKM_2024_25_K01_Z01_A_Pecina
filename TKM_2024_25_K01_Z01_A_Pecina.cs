using System;

class TKM_2024_25_K01_Z01_A_Pecina_Ver_00
{
    static void Main()
    {
        string[] sNL = Console.ReadLine().Split();
        int N = int.Parse(sNL[0]);
        int L = int.Parse(sNL[1]);

        string[] sH = Console.ReadLine().Split();

        int i = 0;
        int prvi = -1;

        while(i < N && prvi <0)
        {
            int h = int.Parse(sH[i]);
            i++;
            if (h <= L) prvi = i;
        }

        Console.WriteLine(prvi);
    }
}
