// 2 - Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın
let n,r,sum=0,temp;    
n = 1331;
temp=n;  
while (n > 0) {
    r = n % 10;
    sum = (sum * 10) + r;
    n = parseInt(n / 10);
}
if (temp == sum) {
    console.log("polindromdur");
}
else {
    console.log("polindrom deyil");

}