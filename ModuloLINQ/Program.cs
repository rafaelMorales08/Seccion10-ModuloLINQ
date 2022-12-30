//cpnsultas a bd

using ModuloLINQ;

int[] numeros = Enumerable.Range(1, 5).ToArray();

//Esro es LINQ (SINTAXIS DE METODOS)
var numerosPares = numeros.Where(n=> n %2 == 0).ToList();

Console.WriteLine();

//FORMA 2 : SINTAXIS DE QUERIES

var numerosPares2 = (from n in numeros where n %2 == 0
                    select n).ToList();


Console.WriteLine();


//paso 1: ejecucion diferida

var numerosPares3 = numeros.Where(n =>
{
    Console.WriteLine($"Evaluando si {n} es par");

    return n % 2 == 0;
});


Console.WriteLine();
foreach(var nuumero in numerosPares)
{
    Console.WriteLine($"el numero {nuumero} es par");
}

Console.WriteLine();


//where

//var numerosImpares = numeros.Where(n)



var Personas = new List<Persona>() {

    new Persona { Nombre = "Eduardo", Edad = 30 , FechaIngresoEmpre = new DateTime(2002,1,1), Soltero = true}
};

 var personaMenorde25 = Personas.Where(p => p.Edad== 30 ).ToList();

foreach(var persona in personaMenorde25)
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años");
}

var solteros = Personas.Where(p => p.Soltero).ToList();
foreach (var persona in personaMenorde25)
{
    Console.WriteLine($"{persona.Nombre} ES {persona.Soltero} soltero");
}


var Solteromenoresde25 = Personas.Where(p => p.Nombre == "CARLOS").ToList();