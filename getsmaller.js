// Task 3:
// - Verilmiş üç ədəddən ən kiçiyini tapan alqoritm qurun.
let num1=12;
let num2=122;
let num3=12;
let biggestNumber=0;

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
    console.log('error!')
}
console.log(biggestNumber+" => en boyuk ededdir");