//Task - 1: 
//Ədədlərdən ibarət olan, verilmiş arrayin ədədi ortasını tapın.

int[] arrNum = { 12, 43, 12, 342, 43 };
int sum = 0;


for(int i=0; i < arrNum.Length; i++)
{
    sum=sum+arrNum[i];
}
Console.WriteLine(sum/arrNum.Length);