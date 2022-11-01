//Task - 1: 
//Ədədlərdən ibarət olan, verilmiş arrayin ədədi ortasını tapın

int[] numArray = {12,34,23,12,54 };
int sum = 0;
for(int i = 0; i < numArray.Length; i++)
{
    sum=sum+numArray[i];
}
Console.WriteLine(sum/numArray.Length);