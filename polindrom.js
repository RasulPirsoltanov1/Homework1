// 2 - Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın
let n,r,sum=0,temp;    
n = 121;
temp=n;  
while (n > 0) {
    r = n % 10;
    sum = (sum * 10) + r;
    n = (n-r) / 10;
}
if (temp == sum) {
    console.log("polindromdur");
}
else {
    console.log("polindrom deyil");
}