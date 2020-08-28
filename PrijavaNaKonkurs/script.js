
let form = document.getElementById('form');
let inputName = document.getElementById('name');
let btnSubmit = document.querySelector('#submit');
let pResult = document.getElementById('result');

form.addEventListener("submit", event => {
    event.preventDefault();
    //ispis imena i prezimena
    pResult.innerHTML = inputName.value + "<br>";
    //ispis pola korisnika
    let radioButtonGender = document.querySelector("input[name='gender']:checked");
    
    switch (radioButtonGender.value) {
        case "m":
            pResult.innerHTML += '<span style="color: blue">Pol : muski</span>';
            break;
        case "f":
            pResult.innerHTML += '<span style="color: red">Pol : zenski</span>';  
            break;
        case "o":
            pResult.innerHTML += '<span style="color: green">Pol : neopredeljen</span>'; 
            break;
        default:
            pResult.innerHTML += "Doslo je do greske"; 
            break;
    }
    //ispis odabranih tehnologija
    let checkBoxTehChecked = document.querySelectorAll('input[name="tech"]:checked');
    pResult.innerHTML += '<br><ul>';
    checkBoxTehChecked.forEach( element => {
    pResult.innerHTML += `<li>${element.value}</li>`;
    });
    pResult.innerHTML +='</ul>';
    form.reset();

});