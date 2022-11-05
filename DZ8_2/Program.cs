// В двумерном массиве целых чисел. Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
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

int[,]  DeletElement(int[,] matr)
{ 
int indexI = 0;
int indexJ = 0;
int[,] delmatr = new int[matr.GetLength(0)-1,matr.GetLength(1)-1] ;
int min = matr[0,0];
     for(int i = 0; i<matr.GetLength(0); i++)
    { 
      for(int j = 0; j<matr.GetLength(1); j++)
      {
         if (matr[i,j] < min)
        {
         min = matr[i,j];
         indexI = i;
         indexJ = j;
        }
      }
    }  

   int ii = 0; 
   
   for(int i = 0; i<matr.GetLength(0); i++)
    {   
      int jj = 0;
      if(i == indexI )
         continue;

      for(int j = 0; j< matr.GetLength(1); j++) 
      {
         if(j == indexJ )
            continue;

         delmatr[ii,jj] = matr[i,j];
        
       ++jj;  
         
      }
     ++ii;
    } 
   return delmatr;
}

Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k");
int k= int.Parse(Console.ReadLine());
int[,] mass = new int[n,k];
FillArray(mass);
PrintArrye(mass);
Console.WriteLine("");
PrintArrye(DeletElement(mass));

