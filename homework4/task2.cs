//Task - 2: Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.
int[] arrayNum = { 12, 34, 5, -23, -4, 4 };
int positiveCounter=0,negativeCounter=0;
for (int i = 0; i < arrayNum.Length; i++)
{
    if (arrayNum[i] > 0)
    {
        positiveCounter++;
    }
    else if (arrayNum[i] < 0)
    {
        negativeCounter++;
    }
}

Console.WriteLine("count of positive nums = "+positiveCounter+"\n"+ "count of negative nums = "+negativeCounter);