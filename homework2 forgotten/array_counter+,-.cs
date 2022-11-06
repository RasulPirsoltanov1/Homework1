//Task - 2: Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.
int[] arrNum = { -12, 23, 34, -1, -45,12 ,123,-123};
int plusCounter = 0,minusCounter=0;

for(int i = 0; i < arrNum.Length; i++)
{
    if(arrNum[i] > 0)
    {
        plusCounter++;
    }
    else if(arrNum[i] < 0)
    {
        minusCounter++;
    }
}
Console.WriteLine("menfi ededlerin sayi = "+ minusCounter+ " " + "musbet ededlerin sayi = " + plusCounter);