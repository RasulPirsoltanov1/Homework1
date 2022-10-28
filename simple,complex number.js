let a=12;
let checker=false;
for(let i=1;i<a;i++){
    if(a%i==0 && i!=1){
        checker = true;
    }
}
console.log(checker)
if(checker){
    console.log('murekkebdir')
}
else{
    console.log('Sadedir')

}