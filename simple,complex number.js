let a = 12;
let checker = false;
let sum=0;
for (let i = 1; i < a; i++) {
    if (a % i == 0 && i != 1) {
        checker = true;
        sum=sum+i;
        console.log(i);
    }
}
console.log(checker)
if (checker) {
    console.log('murekkebdir : cemi ='+sum)
}
else {
    console.log('Sadedir')
}