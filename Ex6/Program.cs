/* как округлить число

*/

// double num = 0.12345;
// Console.WriteLine($"{num:f4}");

// double num = 12.845;
// num = Math.Floor(num); // вниз округляет до целого числа
// Console.WriteLine($"{num}");

double num = 12.845;
num = Math.Ceiling(num); // вверх округляет до целого числа
Console.WriteLine($"{num}");

