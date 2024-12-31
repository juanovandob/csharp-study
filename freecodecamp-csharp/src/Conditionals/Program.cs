/* EXERCISE 1 OF 2 
Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Para calcular la puntuación, evaluará los valores obtenidos. Si la puntuación es mayor que un total arbitrario, se mostrará un mensaje de éxito al usuario. Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al usuario.

Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.*/

//Random random = new Random(); after this line is the new way to declare a random object
Console.WriteLine("-------- EXERCISE 1 --------");

Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3; ;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//extra points for triples
if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled triples! +6 points!");
    total += 6;
    Console.WriteLine($"Your total including the bonus: {total}");
}//extra points for doubles
else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("You rolled doubles! +2 points!");
    total += 2;
    Console.WriteLine($"Your total including the bonus: {total}");
}

/*OTHER VERSION -- BUT NOT THE BEST ALGORITHM TO USE
if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    if (roll1 == roll2 && roll2 == roll3)
    {
        Console.WriteLine("You rolled triples! +6 points!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 points!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}
*/

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

/*EXERCISE 2 OF 2
Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.*/
Console.WriteLine("\n-------- EXERCISE 2 --------");
//old way --> Random random = new Random();
Random random = new(); //new way to declare a random object
int dasyUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine($"Days until expiration: {dasyUntilExpiration}");

if (dasyUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (dasyUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
else if (dasyUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {dasyUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
else if (dasyUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now.");
}