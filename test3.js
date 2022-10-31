let eded = 113;
let checker=false;
let temp = eded;
if (eded != 1 || eded != 0 || eded != 2) {
    for (let i = 1; i < eded; i++) {
        if (temp % i == 0 && i!=1) {
            checker = true;
        }
    }
}
if (checker) {
    console.log("Murekkebdir!");
}
else {
    console.log("sadedir!");
}