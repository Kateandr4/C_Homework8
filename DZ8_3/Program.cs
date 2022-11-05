// Сформировать трехмерный массив не повторяющимися двузначными 
//числами показать его построчно на экран выводя индексы 
//соответствующего элемента
void FillArray(int[, ,] matr )
{
    int[] tempmatr = new int[90];
     tempmatr[0] = 0;
for ( int i=0; i<tempmatr.Length; i++)
tempmatr[i] = i+10;

for (int i = tempmatr.Length-1; i >= 1; i--)
        {
            int j = new Random().Next(i + 1);
            int tmp = tempmatr[j];
            tempmatr[j] = tempmatr[i];
            tempmatr[i] = tmp;
        }
int x=0;
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
        for ( int k=0; k<matr.GetLength(2); k++)
        {
           matr[i, j, k] = tempmatr[x];
           x++;
        }
     }
    }

}
 void PrintArrye(int[, ,] matr)
 {
    for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
         for ( int k=0; k<matr.GetLength(2); k++)
        {
        Console.Write($"{matr[i, j, k]+ " ["+ i+ j+k+"]"} ");
        }
       Console.WriteLine();
     }
     Console.WriteLine();
 }
 }

int[, ,] mass = new int[3,5,4];
FillArray(mass);
PrintArrye(mass);


