
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
    let country;

    if (input === "USA") 
    {
        country = usa;
        DisplayColors(usa);
    }
    else if (input === "Mexico") 
    {
        country = mexico;
        DisplayColors(mexico);
    }
    else if (input === "France") 
    {
        country = france;
        DisplayColors(france);
    }
    else if (input === "Brazil")
    {
        country = brazil;
        DisplayColors(brazil);
    }
    else if (input === "Italy")
    {
        country = italy;
        DisplayColors(italy);
    }
}

function DisplayColors(Country) 
{
    let color1 = document.getElementById("Color1");
    color1.style.backgroundColor = Country.colors[0];

    let color2 = document.getElementById("Color2");
    color2.style.backgroundColor = Country.colors[1];

    let color3 = document.getElementById("Color3");
    color3.style.backgroundColor = Country.colors[2];

    let countryName = document.getElementById("CountryName");
    countryName.innerText = Country.name;

    let officialLanguage = document.getElementById("OfficialLanguage");
    officialLanguage.innerText = Country.language;

    let helloWorld = document.getElementById("HelloWorld");
    helloWorld.innerText = Country.greeting;
}