/*//Declaraciones:
let lure;
let lures;
let anzuelotip;
let cant;
let armar;
let res;
let frag;
let nuevaCuchara;
let cuanti = "";

let modelo = ["ALIEN","ARROW","BENDY 1","BENDY 2","CHAKE","FAT MINNOW","LURE","SHADOW"]; //que modelo de señuelo es
let triple = ["#24", "#26", "#28","#1"];
let simple = ["1/0", "2/0", "3/0", "#4"];
let anillas = ["#4 Worth", "#5 Worth"];


//RANDOM y WHILE
function random(max) {
    return Math.floor(Math.random()*max);
}

function modelos(){
    let n = 0;
    while (n < modelo.length) {
        n++;
        let mod = modelo[n-1];
        document.write("Modelo: "+ mod +"<br>") +"<br>";  
    }
    document.write("<br>")
}

lures = {
    modelo: modelo[random(modelo.length)],
    anzuelo: triple[random(triple.length)],
    anillas: anillas[random(anillas.length)]
};

var mensaje = "El señuelo duro " + lures.modelo + " lleva anzuelos " + lures.anzuelo + " montandos sobre anillas " + lures.anillas+ " para que nunca pierdas un pique y claves como la re concha de la lora"

alert(mensaje)

/*
//FOR
function opciones() {
    lure = "";
    for (i = 0; i < modelo.length; i++) {
        anz = "Anzuelo: " +triple[random(triple.length)];
        ani = "Anillas : " +anillas[random(anillas.length)] ;     
        lure = "Opción " + (i+1) +":"+ modelo[i];
        
        document.write(lure +" "+ anz +" "+ ani + "<br>" );
    }
}


//OBJETOS

//VER CONSOLA
class chosen1 {
    constructor(modelo,color,trisim,cantidad){
        this.modelo = modelo;
        this.color = color;
        this.trisim = trisim;
        this.cant = cantidad;
        this.info = "Son "+this.cant+" unidades del señuelo "+this.modelo+" con anzuelos "+this.trisim+ " de color "+this.color
    }
    Info(){
        console.log(this.info);
    }
}

let arrow = new chosen1("Arrow","FTG","simples",250);
let fatminnow = new chosen1("Fat Minnow","BCK","triples", 130);
let alien = new chosen1("Alien","YEL","triples", 58);


//CONSTRUCTOR DE OBJETOS

class cuchara {
    constructor (mod,aniTipo,anzTipo,pesoFin){
        this.mod = mod;
        this.aniTipo = aniTipo;
        this.anzTipo = anzTipo;
        this.pesoFin = pesoFin;
        this.final = mod.toUpperCase() +"<br><br>"+ "Anillas: " + aniTipo +"<br>"+ "Anzuelo: " + anzTipo +"<br>"+ "Peso final: " + pesoFin +"<br>"
    }
    
    cucharada(){
       res = document.querySelector(".cuchara"); //Selecciona el <div>
       frag = document.createDocumentFragment(); //Crea el "espacio" donde se creara el elemento
       nuevaCuchara = document.createElement("P"); //Crea las etiquetas <p>
       nuevaCuchara.innerHTML = this.final + "<br>"; //Cambia el texto del elemento nuevo
       frag.appendChild(nuevaCuchara); //Agrega el nuevo elemento
       res.appendChild(frag); //Agrega los elementos nuevos dentro del <div> elegido
    }
}

function newCuchara(){
    units = prompt("Cantidad de nuevos ingresos:")
        
    for (i=0; i<units; i++){
        mod = prompt("Modelo:");
        aniTipo = prompt("Anillas:");
        anzTipo = prompt("Anzuelos:");
        pesoFin = prompt("Peso final:");

        deseo = new cuchara(mod,aniTipo,anzTipo,pesoFin);
        deseo.cucharada();      
    }
}

//EVENTOS

//CREADOR DE CUCHARAS
const boton = document.querySelector(".ingCuchara") 

boton.addEventListener("click",(e)=>{
    newCuchara();
})

function contador(){
    form = document.querySelector(".lureOptions");
    cuanti = form.children[3].lastElementChild.value;
    cuantiAnilla = cuanti *= 2;
    cuantiPale = cuanti;
    cuantiSimple = cuantiAnilla;
    cuantiTriple = cuantiAnilla;
    cuantiCarton = cuanti;
    cuantiBolsa = cuanti;
    form.children[16].innerHTML= form.children[16].innerHTML +" "+ cuantiAnilla;
    form.children[18].innerHTML= "Anillas paleta: NO LLEVA";
    if (form.children[11].innerHTML="Simples no lleva");{
        
    }
    form.children[14].innerHTML= form.children[14].innerHTML +" "+ cuantiTriple;
    form.children[20].innerHTML= "Cartones: " + cuantiCarton;
    form.children[22].innerHTML= "Bolsas: " + cuantiBolsa;
}

//CALCULADOR EMBLISTADO
const btnAlien = document.querySelector(".A")
        btnAlien.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnAlien.title
        form.children[16].innerHTML= "Anillas: Worth #4"
        form.children[18].innerHTML= "Anillas paleta: NO LLEVA"
        form.children[11].innerHTML="Simples no lleva"
        form.children[14].innerHTML="Triples #4"
        contador();
    })
const btnArrow = document.querySelector(".Ar")
        btnArrow.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnArrow.title
        form.children[16].innerHTML= "Anillas: Worth #5"
        form.children[18].innerHTML= "Anillas paleta: NO LLEVA"
        form.children[11].innerHTML="Simples #28"
        form.children[14].innerHTML="Triples #2/0"
        contador();
    })
const btnBendy1 = document.querySelector(".B1")
        btnBendy1.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnBendy1.title
        form.children[16].innerHTML= "Anillas: Worth #5"
        form.children[18].innerHTML= "Anillas paleta: Worth #4"
        form.children[11].innerHTML="Simples #26"
        form.children[14].innerHTML="Triples #1/0"
        contador();
    })
const btnBendy2 = document.querySelector(".B2")
        btnBendy2.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnBendy2.title
        form.children[16].innerHTML= "Anillas: Worth #5"
        form.children[18].innerHTML= "Anillas paleta: Worth #4"
        form.children[11].innerHTML="Simples #26"
        form.children[14].innerHTML="Triples #1/0"
        contador();
    })
const btnChake = document.querySelector(".C")
        btnChake.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnChake.title
        form.children[16].innerHTML= "Anillas: Worth #4"
        form.children[18].innerHTML= "Anillas paleta: NO LLEVA"
        form.children[11].innerHTML="Simples #24"
        form.children[14].innerHTML="Triples #1"
        contador();
    })
const btnFat = document.querySelector(".F")
        btnFat.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnFat.title
        form.children[16].innerHTML= "Anillas: Worth #5"
        form.children[18].innerHTML= "Anillas paleta: NO LLEVA"
        form.children[11].innerHTML="Simples #28"
        form.children[14].innerHTML="Triples #2/0"
        contador();
    })
const btnLure = document.querySelector(".L")
        btnLure.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnLure.title
        contador();
    })
const btnShadow = document.querySelector(".S")
        btnShadow.addEventListener("click",(e)=>{
        form = document.querySelector(".lureOptions")
        form.children[0].innerHTML = "Modelo: " + btnShadow.title
        form.children[16].innerHTML= "Anillas: Worth #5"
        form.children[18].innerHTML= "Anillas paletas: Worth #4"
        form.children[11].innerHTML="Simples #28"
        form.children[14].innerHTML="Triples #1"
        contador();
    })


        







    


//EJECUCION
  
ingreso()
   
arrow.Info();
fatminnow.Info();
alien.Info();

modelos();
opciones();

newCuchara();
*/ 
