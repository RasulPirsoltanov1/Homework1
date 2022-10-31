let eded=1211,sum=0,qaliq;
let temp=eded;
while(eded > 0){
    qaliq=eded%10;
    sum=qaliq+(sum*10)
    eded=parseInt(eded/10);
    console.log(eded);
}
console.log(sum);
if(sum==temp){
    console.log("bu ededler polindromdur!");
}
else{
    console.log("bu ededler deyil!");
}