// Найти произведение двух матриц
void FillArray(int[,] matr )
{
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = new Random().Next(0,10);
     }
    }

}
 void PrintArrye(int[,] matr)
 {
    for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
        Console.Write($"{matr[i, j]} ");
     }
     Console.WriteLine();
 }
 }

 int[,] MultElement(int[,] matr1, int[,] matr2)
{
    int[,] multmatr = new int[matr1.GetLength(0),matr1.GetLength(1)];    
    for(int i = 0; i<multmatr.GetLength(0); i++)
    {  
    for(int j = 0; j<multmatr.GetLength(0); j++)
        {
        for(int k = 0; k<multmatr.GetLength(0); k++)
        {
        multmatr[i,j] = matr1[i,k] * matr2[k,j] +multmatr[i,j];
        }
        } 
    }
    return multmatr;
}

Console.WriteLine("Введите n для квадратной матрицы");
int n= int.Parse(Console.ReadLine());
int[,] mass1 = new int[n,n];
int[,] mass2 = new int[n,n];
FillArray(mass1);
PrintArrye(mass1);
Console.WriteLine("");
FillArray(mass2);
PrintArrye(mass2);
Console.WriteLine("");
PrintArrye(MultElement(mass1, mass2));
