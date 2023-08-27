

//https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem?isFullScreen=true challenge


internal class Program
{
    private static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = JumpingOnClouds(c, k);

        Console.WriteLine(result);
        
    }

    private static int JumpingOnClouds(int[] c, int k)
    {
        int result = 100;
        int i = 0;
        while (i!=-1)
        {
            i += k;
            if (i >= c.Count())
            {
                i = i % c.Count();
            }
            if (c[i] == 1)
            {
                result -= 2;
            }
            if (i==0)
            {
                i = -1;
            }
            result -= 1;
        }
        


        return result;
    }
}

//Sample Input
//8 2                  => n = 8, k = 2
//0 0 1 0 0 1 1 0      => c = [0, 0, 1, 0, 0, 1, 1, 0]

//Sample Output
//92