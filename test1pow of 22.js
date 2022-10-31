let a=7;
let checker=true;
if(a==0 || a==1){
    checker=false;
}
while(a>1){
    if(a%2!=0){
        checker=false;
    }
    a=a/2;
}
if(checker){
    console.log("true");
}
else{
    console.log("false");
}