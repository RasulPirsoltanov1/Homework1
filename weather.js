
// - Havanın temperaturu verilir. Əgər temperatur 15 - dən kiçikdirsə ekrana yazılsın "Hava soyuqdur", 15 - dən böyükdürsə ekrana yazılsın "Hava istidir".
let weatherTemprature=24;


if(weatherTemprature<15){
    console.log('Hava Soyuqdur');
}
else if(weatherTemprature>15){
    console.log('Hava Istidir');
}
else{
    console.log('error!');
}