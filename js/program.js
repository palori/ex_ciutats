// JavaScript source code
var CITIES = new Array("BArcelona", "Madrid", "Valencia", "Cadis", "Malaga", "Santander");

fase1();
fase2();
fase3();
fase4();

function title(title)
{
    console.log(`\n\n---\n${title}:\n`);
}

function printCities(cities)
{
    //console.log(`\nNom de les ${cities.le} cities:`);
    for (i = 0; i < cities.length; i++)
    {
        console.log(`    ${i+1}. ${cities[i]}`);
    }
}

function fase1()
{
    title("fase1");
    
    var cities = CITIES;
    printCities(cities);
}

function fase2()
{
    title("fase2");

    var cities = CITIES;
    cities.sort(); // Sort the string array
    printCities(cities);
}

function replace_a(cities)
{
    var citiesModified = cities;
    console.log("replace");
    for (i = 0; i < citiesModified.length; i++)
    {
        citiesModified[i] = cities[i].replace(/a/gi,"4");
        // this is robust: case sensitive
    }
    return citiesModified;
}

function fase3()
{
    title("fase3");

    var cities = CITIES;
    cities.sort(); // Sort the string array
    citiesModified = replace_a(cities);
    printCities(citiesModified);
}

function reverseString(str)
{
    var splitString = str.split("");
    var reverseArray = splitString.reverse();
    var joinArray = reverseArray.join("");
    return joinArray;

    // could be in one line:
    // return str.split("").reverse().join("");
}

function fase4()
{
    title("fase4");
    var cities = CITIES;
    cities.sort(); // Sort the string array

    // Done a bit different than in C#.
    // (Considering that a string is an "array" of characters)

    // Reverse
    var citiesReverse = new Array(cities.length);
    for (i = 0; i < citiesReverse.length; i++)
    {
        citiesReverse[i] = reverseString(cities[i]);
    }

    // print like a mirror: Barcelona - anolecraB
    console.log("\nNom de les ciutats invertits:");
    for (i = 0; i < citiesReverse.length; i++)
    {
        console.log(`    ${cities[i]} - ${citiesReverse[i]}`);
    }
}