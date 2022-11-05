// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
 void PaskalArray(int[,] matr )
{
    matr[0,0] = 1;
 for ( int i=1; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<i+1; j++)
     {
        if (j == 0 || j == i)
        matr[i,j] = 1;
        else
        matr[i, j] = matr[i-1, j-1]+matr[i-1, j];
     }
    }

}

 
 void PrintArrye(int[,] matr)
 {
    for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
        if (matr[i, j]!=0)
        {
        Console.Write($"{matr[i, j]} ");
        }
     }
     Console.WriteLine();
 }
 }


Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
int[,] mass = new int [n,n];
PaskalArray(mass);
PrintArrye(mass);
 