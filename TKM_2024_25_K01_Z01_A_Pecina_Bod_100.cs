// https://arena.petlja.org/sr-Latn-RS/competition/2024-2025-kv1-testiranje#tab_137811
// https://algora.petlja.org/t/2024-2025/9035
// 

using System;
using System.Collections.Generic;
class TKM_2024_25_K01_Z01_A_Pecina_Bod_100
{
    static void Main()
    {
        string[] sNL = Console.ReadLine().Split();
        int N = int.Parse(sNL[0]);
        int L = int.Parse(sNL[1]);

        string[] sH = Console.ReadLine().Split();
        int i = 0;
        int prvi = -1;

        //while (i < N && prvi < 0)
        //{
        //    int h = int.Parse(sH[i]);
        //    i++;
        //    if (h <= L) prvi = i;
        //}
        //Console.WriteLine(prvi);

        List<int> a = new List<int>(N);
        for (int j = 0; j < N; j++) a.Add(int.Parse(sH[j]));    // a[j] = int.Parse(sH[j]);
        prvi = a.FindIndex(x => x <= L);
        if (prvi >= 0) prvi++;
        Console.WriteLine(prvi);
    }
}
