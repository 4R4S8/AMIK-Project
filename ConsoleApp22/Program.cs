Console.Write("Enter X: ");
int xt = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int yt = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z: ");
int zt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Enter X\': ");
int xpt = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y\': ");
int ypt = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z\': ");
int zpt = Convert.ToInt32(Console.ReadLine());

//صورت بزرگ تر از مخرج کسر اول
int bap = (xt * zt) + yt;
//صورت بزرگ تر از مخرج کسر دوم
int bap2 = (xpt * zpt) + ypt;

//مقدار تکرار
Console.Write("Enter Counting: ");
int x = Convert.ToInt32(Console.ReadLine());

//int[] array1= new int[x];
//int[] array2 = new int[x];
Console.WriteLine();
Console.Write("{0}/{1}", bap, zt);
for (int i = 0; i < x; i++)
{
    Console.Write(" < ");
    Console.Write(bap += bap2);
    Console.Write("/");
    Console.Write(zt += zpt);
}
Console.WriteLine(" < {0}/{1} ", bap2, zpt);


