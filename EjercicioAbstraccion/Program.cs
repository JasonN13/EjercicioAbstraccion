﻿using EjercicioAbstraccion;

Console.WriteLine("");
Console.WriteLine("Animal Vertebrado");
Vertebrado vertebrado = new Vertebrado();
Console.WriteLine("");
vertebrado.tipo = "pez";
vertebrado.nombre = " pez Gato";
vertebrado.color = "Dorado";
vertebrado.tamano = "Pequeño";
vertebrado.familia = "Pezdorado";
vertebrado.tienepatas = false;
vertebrado.escarnivoro = true;
vertebrado.esherviboro = false;
vertebrado.esdomestico = true;
vertebrado.imprimir();

Console.WriteLine("");
Console.WriteLine("Animal Invertebrano");
Console.WriteLine("");
Invertebrado invertebrado = new Invertebrado();
invertebrado.tipo = "Gusano";
invertebrado.nombre = "Lombris";
invertebrado.color = "Rosado";
invertebrado.tamano = "Pequeño";
invertebrado.familia = "Lombrises de tierra";
invertebrado.tienepatas = false;
invertebrado.numeropatas = 0;
invertebrado.tieneconcha = false;
invertebrado.imprimir();