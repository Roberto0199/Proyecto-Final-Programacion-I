using Proyecto_Final_Programacion_I.Clases;


        // Crear objetos de las clases PickUp, Sedan y SUV
        PickUp pickUp = new PickUp();
        Sedan sedan = new Sedan();
        SUV suv = new SUV();

        // Asignar valores a las propiedades de los objetos
        pickUp.Marca = "Ford";
        pickUp.Modelo = "Ranger";
        pickUp.Color = "Rojo";
        pickUp.Anio = 2022;
        pickUp.Placa = "ABC123";
        pickUp.Tipo = "PickUp";
        pickUp.CargaMaxima = 1000;
        pickUp.TieneCaja = true;

        sedan.Marca = "Toyota";
        sedan.Modelo = "Corolla";
        sedan.Color = "Gris";
        sedan.Anio = 2021;
        sedan.Placa = "DEF456";
        sedan.Tipo = "Sedan";
        sedan.NumeroPuertas = 4;
        sedan.TieneMaletero = true;

        suv.Marca = "Jeep";
        suv.Modelo = "Grand Cherokee";
        suv.Color = "Negro";
        suv.Anio = 2023;
        suv.Placa = "GHI789";
        suv.Tipo = "SUV";
        suv.TerceraFilaAsientos = true;
        suv.TraccionIntegral = true;

// Llamar a los métodos de los objetos

        pickUp.Encender();
        pickUp.Acelerar(50);
        pickUp.Bocina();
        pickUp.Frenar(20);
        pickUp.ActivarTraccion4x4();

        sedan.Encender();
        sedan.Acelerar(40);
        sedan.Bocina();
        sedan.Frenar(15);
        sedan.AbrirMaletero();

        suv.Encender();
        suv.Acelerar(60);
        suv.Bocina();
        suv.Frenar(25);
        suv.ActivarModoOffRoad();

        // Esperar a que el usuario presione una tecla para salir
        Console.ReadKey();





