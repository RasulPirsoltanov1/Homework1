function get_data() {
    var cards=document.getElementById('container');
    cards.style.display="block";
    let text = document.getElementById('text');
    let card = document.getElementById('card');
    let h1 = document.getElementsByTagName('h1')
    let card_title = document.querySelectorAll('card-title')
    fetch('https://jsonplaceholder.typicode.com/todos')
        .then(response => response.json())
        .then(json => {
            console.log(json)
            for (let i = 0; i < json.length; i++) {
                const element = json[i];

                card.innerHTML += `<div class="card rounded col-md-3 shadow-lg p-3 mb-5 bg-body rounded" style="width: 18rem; margin:20px; "><div class="card-body" > <h5 class="card-title"> title: ${json[i].title}</h5>
            <h6 class="card-subtitle mb-2 text-muted"> User id: ${json[i]["userId"]}</h6>
            <p class="card-text">Card text: ${json[i].completed}</p>
            <a href="https://jsonplaceholder.typicode.com/todos/${json[i].id}" class="btn btn-primary card-text" style="height:40px;" target="_blank">Details : ${json[i].id}</p>
            </div>`;
            }
        })
}
function hide_data() {
    var cards=document.getElementById('container');
    cards.style.display="none";
}