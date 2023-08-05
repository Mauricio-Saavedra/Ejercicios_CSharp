using System;

// Datos que se guardaran en la matriz:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Variables que respaldan al entrada de datos:
int maxPets = 8;
string? readResult; // ^
string menuSelection = "";

// ^Cuando se usa en una declaración de variable como esta, el carácter ? define una variable de tipo que acepta valores NULL.

// Matriz que almacena datos en tiempo de ejecución, estos datos no persisten si el programa finaliza
string[,] ourAnimals = new string[maxPets, 6];
/* ^
La variable final es una matriz de cadenas bidimensional denominada ourAnimals.
Puesto que no está inicializando la matriz, use el operador new. El número de filas se define mediante maxPets,
que se ha inicializado en ocho. El número de características que está almacenando es seis,
las variables de cadena que ha examinado anteriormente.
*/

// Creamos unos datos iniciales para almacenar
for (int i = 0; i < maxPets; i++)   //-> Se crea el bucle 'for' que aumenta en 1 hasta 6.
{
    switch (i)      //-> Cada vez que 'i' pasa por el switch se verifica un caso...
    {
        case 0:
            animalSpecies = "perro";
            animalID = "p1";
            animalAge = "2";
            animalPhysicalDescription = "tamaño mediano, color crema, hembra, golden retriever, peso 30kg aprox, domesticado.";
            animalPersonalityDescription = "ama las caricias en la barriga, le gusta perseguir su cola, dar muchos besos.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "perro";
            animalID = "p2";
            animalAge = "9";
            animalPhysicalDescription = "grande, marron, macho, pitbull, pesa 25kg aprox, domesticado.";
            animalPersonalityDescription = "ama las caricias en sus orejitas cuando te recibe en la puerta, o a cualqueir hora, ama comer salchichas y los abrazos.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "gato";
            animalID = "g3";
            animalAge = "1";
            animalPhysicalDescription = "mediano, hembra, pesa 8kg aprox, domesticada.";
            animalPersonalityDescription = "amigable, cariñoso, le gusta el jamón y dormir bajo el sol.";
            animalNickname = "wero";
            break;

        case 3:
            animalSpecies = "gato";
            animalID = "g4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
            /* ^
            Recuerde que la ejecución de una sección switch no puede "pasar" a la siguiente sección switch.
            La instrucción break se usa para garantizar que no se produzca una "caída".
            */
    }

    //-> Acá es cuando los datos se añaden según el paso de 'i' + el indice de la matiz
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Especie: " + animalSpecies;
    ourAnimals[i, 2] = "Edad: " + animalAge;
    ourAnimals[i, 3] = "Mote: " + animalNickname;
    ourAnimals[i, 4] = "Description física: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Carácter: " + animalPersonalityDescription;
}

do  //-> Ahora se crea un bucle 'do while', que se acaba hasta que el usuario ingresa 'exit'.
{
    // Muestra en pantalla las opciones del menu:
    //-> Cada vez que se ejecuta empieza por limpiar la consola 
    Console.Clear();
    Console.WriteLine("Bienvenido a FindPets, elige una opción de nuestro menú principal:");
    Console.WriteLine(" 1. Lista todos los animales con su información.");
    Console.WriteLine(" 2. Añade un candidato a mascora a nuestra matriz.");
    Console.WriteLine(" 3. Corrobora que la edad y el estado físico de nuestros candidatos este completo.");
    Console.WriteLine(" 4. Corrobora que sus motes y personalidad esten completos.");
    Console.WriteLine(" 5. Edita la edad de un candidato.");
    Console.WriteLine(" 6. Edita la personalidad de un candidato.");
    Console.WriteLine(" 7. Muestra todos los gatos con una caracteristica espeifica.");
    Console.WriteLine(" 8. Muestra todos los perros con una caracteristica espeifica.");
    Console.WriteLine();
    Console.WriteLine("Ingresa el número de tu selección (o escribe 'exit' para salir).)");

    //-> Se lee lo que el usuario ingresa a la terminal
    readResult = Console.ReadLine();
    //-> SI el usuario ingresa algo diferente de un NULO (o sea, cualquier cosa).
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTA: Se podría poner un 'do while' alrededor de la <selección> de menú (la variable 'menuSelection')
        //  para asegurarnos de que haya una entrada de datos valida, pero aquí se usa una condicional 'IF' que
        //  Solo procesa una entrada de datos valida^ 

        /*
        ^: Claro, porque ya estamos en un bucle (y al inicio de éste), entonces si se mete un valor erroneo
            solo se debe de repetir el bucle y ya, pero si el usuario ingresa un valor que pase la condicional
            ahora se convierte en minusculas lo ingresado y pasamos al switch.
        */
    }

    // Usamos un switch-case para procesar la opción seleccionada.
    switch (menuSelection)
    {
        case "1":
            // Listamos toda la información de nuestras mascotas
            //El Bucle for sumará hasta un maximo de 8->maxPets, recorriendo ésta misa matriz.
            for (int i = 0; i < maxPets; i++)   
            {
                if (ourAnimals[i, 0] != "ID #: ")   // Si nuestra matriz->ourAnimals es diferente de "ID #:", ésto porque ID 0 y (i=0) no deben encontrarse, supongo.
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                        /*
                        i == ID de la mascota, osea selecciona una fila.
                        j == Columnas de la fila seleccionada.
                        */
                    }
                }
            }
            Console.WriteLine("\n\rPresiona 'Enter' para continuar");
            readResult = Console.ReadLine();

            break;  // Continua el Swith hasta el caso 8

        case "2":
            // Añadiendo un nuevo animalito a la matriz:
            string anotherPet = "y";    // Se declara la variable 'anotherPet' = 'y'
            int petCount = 0;          // declaramos una variable numérica 'petCount' = 0
            for (int i = 0; i < maxPets; i++)  // Iniciamos un for que se recorrerá 8 veces
            {
                if (ourAnimals[i, 0] != "ID #: ") //Hacemos un checking de el ID
                {
                    petCount += 1;                 //Sumamos 1 a la variable 'petCount'
                }
            }

        //Si 'petCount' es menor que 'maxPets', supongo que para que no haya más registros, porque en el ejemplo tenemos cupo Límitado para las mascotas.
            if (petCount < maxPets)     
            {
                Console.WriteLine($">>> Actualmente tenemos {petCount} mascotas en adopción. Nosotros podemos cuidar {(maxPets - petCount)} más.");
            }

            //Iniciamos un bucle While para que el usuario ingrese a la(s) mascota(s).
            //Mientras que 'anotherPets' == 'y' && 'petCount' sea menor que nuestra capacidad maxima
            while (anotherPet == "y" && petCount < maxPets) 
            {
                bool validEntry = false;    //Se define un booleano con false.

                //Obtenemos la especie de la mascota - El string 'animalSpecies' es un campo requerido.
                do  //Bucle 'do while' para verificar que se haya introducido la especie, no avanzará mientras la entrada de especie no sea True.
                {
                    Console.WriteLine("\n\rIngresa 'perro' o 'gato' para comenzar una nueva entrada");
                    readResult = Console.ReadLine().ToLower();
                    if (readResult != null) //Si la entrada del usuario no es nula pasamos al siguiente stage:
                    {
                        animalSpecies = readResult.ToLower();   //Se guarda lo ingresado en su variable en minusculas.
                    //Si 'animalSpecies' no es un gato o un perro entonces 
                        if (animalSpecies != "perro" && animalSpecies != "gato")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
// zzzzzzzz
                // Construimos el animal con su id - por ejemplo C1 =cat1, D2 =dog2
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                /*
                Substring es un método en C# que se utiliza para obtener una subcadena de una cadena existente.
                Substring(0, 1) retorna el primer carácter (o sea, el carácter en el índice 0) de animalSpecies.
                Por ejemplo, si animalSpecies es "Perro", entonces animalSpecies.Substring(0, 1) retornará "P".
                */

                // get the pet's age. can be ? at initial entry.
                // Obtenemos del usuario la edad del animalito, al principio puede ser '?' == null.
                do
                {
                    int petAge;
                    Console.WriteLine("Ingresa la edad de la mascota, puedes poner '?' si no la sabes en este momento.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

            //Este y los tres bucles siguientes estaran dentro 'hasta que el resultado no sea nulo' por eso si el usuario no llena el campo por desconocimiento,
            // el bucle lo llena por él con un 'tbd' que es == a 'to be determined'.
                // Iniciamos otro bucle 'do while' para la descripción física del animalito, también puede ser un null.
                do
                {
                    Console.WriteLine("Ingresa la descripción física de la mascota (genero, tamaño, color, peso, si esta domesticado, etc.)");
                    readResult = Console.ReadLine().ToLower();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // Otro más para la personalidad del animalito - animalPersonalityDescription puede ser nulo.
                do
                {
                    Console.WriteLine("Ingresa la descripción del caracter del animalito (que le gusta y disgusta, trucos, nivel de energía)");
                    readResult = Console.ReadLine().ToLower();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // Otro más para el mote, también puede ser bulo.
                do
                {
                    Console.WriteLine("Ingresa un Mote para la mascota:");
                    readResult = Console.ReadLine().ToLower();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // Almacenamos la información in la matriz ourAnimals (base cero)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Especie: " + animalSpecies;
                ourAnimals[petCount, 2] = "Edad: " + animalAge;
                ourAnimals[petCount, 3] = "Mote: " + animalNickname;
                ourAnimals[petCount, 4] = "Description física: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Carácter: " + animalPersonalityDescription;

                // Incrementamos petCount en uno para dejar registro de cuantos más podemos tener en el albergue.
                petCount = petCount + 1;

                // Revisando el limite de maxPet
                if (petCount < maxPets)
                {
                    // Añadir otro registro?
                    Console.WriteLine("Quieres añadir otra mascota al registro (y/n)");
                    do  //Éste bucle solo puede acabar con un 'y' o un 'n' cómo respuestas validas.
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("Actualmente hemos alcanzado nuestro límite de mascotas que podemos cuidar.");
                Console.WriteLine("Presiona 'Enter' para continuar.");
                readResult = Console.ReadLine();
            }

            break;

//Cómo en los casos 3 y 4 sólo es corroborar, lo único que tienes que hacer (según yo) es hacer un recorrido por las matrices y verificar que los datos no sean: ?, nulo o tbd.
        case "3":   // Asegurate de que las edades y el estado físico de los animalitos este completo
            for (int i = 0; i < maxPets; i++)   // Éste primer bucle recorre las filas, aka, cada máscota.
            {
            // Si nuestra matriz->ourAnimals en el indice 2 es nulo entonces pasamos al siguiente stage:
                if (ourAnimals[i,2] == "Edad: ?")
                {
                    Console.WriteLine($"La mascota <{ourAnimals[i,0]}> No tiene datos de edad.");
                }
                if (ourAnimals[i, 4].Length < 24 && ourAnimals[i, 0].Length >= 7)
                {
                    Console.WriteLine($"La mascota <{ourAnimals[i, 0]}> No tiene descripción de su estado físico.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Presiona 'Enter' para  continuar.");
            readResult = Console.ReadLine();
            break;

        case "4":   // Asegurate de que los motes y el caracter de los animalitos este completo
            for (int i = 0; i < maxPets; i++)   // Éste primer bucle recorre las filas, aka, cada máscota.
            {
                if (ourAnimals[i,3] != null && ourAnimals[i,3].Length < 10 && ourAnimals[i, 0].Length >= 7)
                {
                    Console.WriteLine($"La mascota <{ourAnimals[i,0]}> No tiene Mote.");
                }
                if (ourAnimals[i, 5].Length < 14 && ourAnimals[i, 0].Length >= 7)
                {
                    Console.WriteLine($"La mascota <{ourAnimals[i, 0]}> No tiene descripción de su Caracter");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":   // Editar la edad
            // Información de la edad -> ourAnimals[i, 2] = "Edad: " + animalAge;
            bool seguirEditandoEdad = true;
            string continuar = "";
            string candidatoID = "";
            string newEdad = "";

            do
            {
                //Primero voy a pedirle a usuario que ingrese el ID del animal a editar la edad:
                Console.WriteLine("Ingresa el 'ID #: ', del canditato al cual se le editara la edad: '");
                candidatoID = "ID #: " + Console.ReadLine().ToLower();

                for (int i = 0; i < maxPets; i++ )
                {
                    if (ourAnimals[i,0] == candidatoID)
                    {
                        string valorCompleto = ourAnimals[i,3];
                        string valorSinPrefijo = valorCompleto.Substring(6); // 6 es la longitud de "Mote: "
                        Console.WriteLine($"Favor de indicar la edad correcta de {valorSinPrefijo}: ");
                        newEdad = "Edad: " + Console.ReadLine().ToLower();
                        ourAnimals[i,2] = newEdad;
                    }
                }

                Console.WriteLine("¿Quieres editar la edad de otro candidato? (y/n)");
                continuar = Console.ReadLine().ToLower();
                if (continuar == "n")
                {
                    seguirEditandoEdad = false;
                }
            } while (seguirEditandoEdad);   //Mientras la variable sea true.

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":   // Editar la personalidad
            // Información de la personalidad -> ourAnimals[i, 5] = "Carácter: " + animalPersonalityDescription;
            bool seguirEditandoCaracter = true;
            string continuarinCatacter = "";
            string candidatoIDinCaracter = "";
            string newCaracter = "";

            do
            {
                //Primero voy a pedirle a usuario que ingrese el ID del animal a editar la edad:
                Console.WriteLine("Ingresa el 'ID #: ', del canditato al cual se le editara el carácter: '");
                candidatoIDinCaracter = "ID #: " + Console.ReadLine().ToLower();

                for (int i = 0; i < maxPets; i++ )
                {
                    if (ourAnimals[i,0] == candidatoIDinCaracter)
                    {
                        string valorCompletoDos = ourAnimals[i,3];
                        string valorSinPrefijoDos = valorCompletoDos.Substring(6); // 6 es la longitud de "Mote: "
                        Console.WriteLine($"Favor de indicar la edad correcta de {valorSinPrefijoDos}: ");
                        newCaracter = "Carácter: " + Console.ReadLine().ToLower();
                        ourAnimals[i,2] = newCaracter;
                    }
                }

                Console.WriteLine("¿Quieres editar el carácter de otro candidato? (y/n)");
                continuarinCatacter = Console.ReadLine().ToLower();
                if (continuarinCatacter == "n")
                {
                    seguirEditandoCaracter = false;
                }
            } while (seguirEditandoCaracter);   //Mientras la variable sea true.

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":   // Gatos con caracteristica física especifica
            // Información de la caracteristica física: ourAnimals[i, 4] = "Description física: " + animalPhysicalDescription;
            bool seguirBuscandoGato = true;
            string continuarBusquedainGato = "";
            string cacteristicaGato = "";

            do
            {
                //Primero voy a pedirle a usuario que ingrese el ID del animal a editar la edad:
                Console.WriteLine("Ingresa La caracteristica que quieres en tu gato: '");
                cacteristicaGato = Console.ReadLine().ToLower();

                for (int i = 0; i < maxPets; i++ )
                {
                    if (ourAnimals[i,4].Contains(cacteristicaGato) && ourAnimals[i,0].Contains("ID #: c"))
                    {
                        string valorCompletoDos = ourAnimals[i,3];
                        string valorSinPrefijoDos = valorCompletoDos.Substring(6); // 6 es la longitud de "Mote: "
                        Console.WriteLine($"El gato {ourAnimals[i,0]}, con el Mote <{valorSinPrefijoDos}> coincide con tu criterio.");
                    }
                }

                Console.WriteLine("¿Quieres buscar en otro candidato? (y/n)");
                continuarBusquedainGato = Console.ReadLine().ToLower();
                if (continuarBusquedainGato == "n")
                {
                    seguirBuscandoGato = false;
                }
            } while (seguirBuscandoGato);   //Mientras la variable sea true.

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":   // Perros con caracteristica física especifica
            // Información de la caracteristica física: ourAnimals[i, 4] = "Description física: " + animalPhysicalDescription;
            bool seguirBuscandoPerro = true;
            string continuarBusquedainPerro = "";
            string cacteristicaPerro = "";

            do
            {
                //Primero voy a pedirle a usuario que ingrese el ID del animal a editar la edad:
                Console.WriteLine("Ingresa La caracteristica que quieres en tu perro: '");
                cacteristicaPerro = Console.ReadLine().ToLower();

                for (int i = 0; i < maxPets; i++ )
                {
                    if (ourAnimals[i,4].Contains(cacteristicaPerro) && ourAnimals[i,0].Contains("ID #: d"))
                    {
                        string valorCompletoDos = ourAnimals[i,3];
                        string valorSinPrefijoDos = valorCompletoDos.Substring(6); // 6 es la longitud de "Mote: "
                        Console.WriteLine($"El perro {ourAnimals[i,0]}, con el Mote <{valorSinPrefijoDos}> coincide con tu criterio.");
                    }
                }

                Console.WriteLine("¿Quieres buscar en otro candidato? (y/n)");
                continuarBusquedainPerro = Console.ReadLine().ToLower();
                if (continuarBusquedainPerro == "n")
                {
                    seguirBuscandoPerro = false;
                }
            } while (seguirBuscandoPerro);   //Mientras la variable sea true.

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
