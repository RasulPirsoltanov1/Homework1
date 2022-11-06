// See Task-3: Ədədlərdən ibarət olan bir array verilib həmin arraydə olan ən böyük ədədi ekrana yazdıran alqoritm yazın.
int[] arrNum = { -12, 23, 34, -1, -45, 12, 123, -123 };
int max=0;
for (int i = 0; i < arrNum.Length; i++)
{
    if(max < arrNum[i])
    {
        max = arrNum[i];  
    }

}
Console.WriteLine(max);