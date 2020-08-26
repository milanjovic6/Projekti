//DOM
    let inputBr1 =document.getElementById("prvibroj");//dohvatamo prvi broj  
    let inputBr2 =document.getElementById("drugibroj");//dohvatamo drugi broj
   // let radios = document.querySelector("input[name='operacija']:checked");//dohvatamo koji radio button je checked
    let form= document.querySelector("form"); // dohvatamo formu dokumneta naseg html
    /* let fieldset =document.querySelectorAll("fieldset");
    let div= document.querySelectorAll("div");
    let span =document.querySelectorAll("span"); */
    let pres=document.getElementById("res"); // dohvatamo paragraf u kome ce stojati rezultat

    // funkcija za racunanje sa parametrima num1 num2 i operacijom    
       let racunaj= (num1,num2,operacija) => {
           //konverzija u numericke podatke
            num1= Number(num1);
            num2= Number(num2);
            //validacija 
            if (Number.isFinite(num1) && Number.isFinite(num2)) {     //provera da li je num1 i num2 broj
            //vrednost koju ima radios +,-,*,/
            let res=0;                                                 // inicijalizacija rezultata
            if (operacija == "+")
            {
                res = num1 + num2;
            }                                       
            else if (operacija == "-") 
            {
                res = num1 - num2;
            }
            else if (operacija == "*") 
            {
                res = num1 * num2;            
            }
            else 
            {
                if (num2 == 0) 
                {
                    alert("Nije dozvoljeno deliti nulom");
                    res = "?";
                } else {
    
                    res = num1 / num2;
                } 
            }            
            pres.innerHTML = `${num1} ${operacija} ${num2} = ${res}`;
            
        }
        else
        {
            alert("Unosi moraju niti numericke vrednosti");
        }
    }
      
//Event na koji se nakon submit-a izvrsava 
    form.addEventListener("submit", event=>{
        event.preventDefault();//sprecava osvezavanje stranice
        let num1 = inputBr1.value; //Brojcana vrednost prvogbroja
        let num2 = inputBr2.value;//Brojcana vrednost drugog broja
        let radios = document.querySelector("input[name='operacija']:checked");
        let radioCheckedValue=radios.value;    
        racunaj(num1,num2,radioCheckedValue);
    });

