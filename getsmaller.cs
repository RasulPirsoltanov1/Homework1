// Task 3:
// - Verilmiş üç ədəddən ən kiçiyini tapan alqoritm qurun.
int num1=12;
int num2=122;
int num3=12;
int biggestNumber=0;

if(num1>num2 && num1>num3){
    biggestNumber=num1;
}
else if(num2>num1 && num2>num3){
    biggestNumber=num2;
}
else if(num3>num1 && num3>num2){
    biggestNumber=num3;
}
else{
    Console.WriteLine("error!")
}
Console.WriteLine(biggestNumber+" => en boyuk ededdir");