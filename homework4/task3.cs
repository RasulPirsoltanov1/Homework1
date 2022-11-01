//Task-3: Ədədlərdən ibarət olan bir array verilib həmin arraydə olan ən böyük ədədi ekrana yazdıran alqoritm yazın.
int[] numArray = { 12, 34, 432, 5, 23,-2323 };
float maxNum = 0;
for (int i = 0; i < numArray.Length; i++)
{
    if (maxNum < numArray[i])
    {
        maxNum = numArray[i];
    }
}
Console.WriteLine(maxNum);