﻿/*
14. Mostrar as potências de 2 variando de 0 a 10. 
*/
int potencia = 0;
for (int i = 0; i <= 10; i++)
{
    potencia = (int) Math.Pow(2, i);
    Console.WriteLine($"2^{i} = {potencia}");
}
