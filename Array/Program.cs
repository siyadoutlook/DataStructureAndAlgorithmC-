//Array declaration and initialization
int[] a1; //declaration
a1 = new int[5]; //Initialization

int[] a2 = new int[2];
int[] a3 = new int[3] { 1, 2, 3 };

int[] a4 = { 1, 32 };

foreach (int i in a1)
{
    Console.Write($"{i} ", i);
}
Console.WriteLine();

foreach (int i in a3)
{
    Console.Write($"{i} ", i);
}
Console.WriteLine();



Array myArray = new int[5];
Array myArray2 = Array.CreateInstance(typeof(int), 5);
myArray2.SetValue(1, 0);

//one based instance. 
Array oneBasedArray = Array.CreateInstance(typeof(int), new[] {5}, new[] { 1 }); //Non zero arrays are not CLS complaint 
oneBasedArray.SetValue(2, 1);
oneBasedArray.SetValue(23, 2);
oneBasedArray.SetValue(24, 3);
oneBasedArray.SetValue(25, 4);
oneBasedArray.SetValue(27, 5);


Console.Write($"Starting index {oneBasedArray.GetLowerBound(0)}");
Console.WriteLine("\nMulti dimensional arrays");

// Multi dimentional arrays
int[,] ma = new int[2, 3] { { 1, 2, 3 }, { 2, 3, 5 } };
int[,] ma1 = { { 1, 2, 3 }, { 2, 3, 5 } };

for(int i= 0; i < ma1.GetLength(0);i++)
{
    for(int j=0;j< ma1.GetLength(1);j++)
    {
        Console.Write($"{ma1[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nJagged arrays");

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[1];
jaggedArray[1] = new int[2];
jaggedArray[2] = new int[3];


Console.WriteLine("Enter the values for jagged arrays\n");

for(int i=0;i<jaggedArray.Length;i++)
{
    for(int j=0;j< jaggedArray[i].Length;j++)
    {
        jaggedArray[i][j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nEnter the values for jagged arrays\n");
for (int i=0;i<jaggedArray.Length;i++)
{
    for(int j = 0; j < jaggedArray[i].Length;j++)
    {
        Console.Write($"{jaggedArray[i][j]}\t");
    }
    Console.WriteLine();
}