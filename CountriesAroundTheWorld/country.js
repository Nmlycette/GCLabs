
class Country 
{
    constructor(name, language, greeting, colors) 
    {
        this.name = name;
        this.language = language;
        this.greeting = greeting;
        this.colors = colors;
    }
}

let usa = new Country("USA", "American English", "Hello World!", ["red", "white", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let france = new Country("France", "French", "Bonjour le monde", ["blue", "white", "red"])
let brazil = new Country("Brazil", "Portugese", "Olá Mundo", ["green", "red"])
let italy = new Country("Italy", "Italian", "Ciao mondo", ["white", "red", "green"])


function SwitchCountry() 
{
    let input = document.getElementById("CountryList").value;
    let countryNameNode = document.getElementById("CountryName");
    let OfficialLanguageNode = document.getElementById("OfficialLanguage");
    let HelloWorld = document.getElementById("HelloWorld");
    let colorNode1 = document.getElementById("Color1");
    let colorNode2 = document.getElementById("Color2");
    let colorNode3 = document.getElementById("Color3");
    let country = usa;

    if (input === "USA")
    {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico")
    {
        country = mexico;
    }
    else if (input === "France")
    {
        country = france;
    }
    else if (input === "Brazil")
    {
        country = brazil;
    }
    else if (input === "Italy")
    {
        country = italy;
    }
    countryNameNode.innerText = country.name;
    OfficialLanguageNode.innerText = country.lang;
    HelloWorld.innerText = country.greeting;
    colorNode1.style.backgroundColor = country.colors[0];
    colorNode2.style.backgroundColor = country.colors[1];
    colorNode3.style.backgroundColor = country.colors[2];
}
