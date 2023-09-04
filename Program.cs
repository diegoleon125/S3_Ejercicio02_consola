Console.WriteLine("Ingrese categoría del hotel:");
Console.WriteLine("(3) 3 estrellas");
Console.WriteLine("(5) 5 estrellas");
int categ = int.Parse(Console.ReadLine());
Console.Write("Ingrese días de estadia: ");
int dias = int.Parse(Console.ReadLine());
float precio = 0.00f;
switch (categ)
{
    case 3:
        if (dias <= 5)
        {
            precio = 100.00f * dias;

        } else if (dias <= 10) {
            precio = 85.00f * dias;
        } else if ((dias >= 11))
        {
            precio = 70.00f * dias;
        }
        break;
    case 5:
        if (dias <= 5)
        {
            precio = 300.00f * dias;

        }
        else if (dias <= 10)
        {
            precio = 270.00f * dias;
        }
        else if ((dias >= 11))
        {
            precio = 250.00f * dias;
        }
        break;
}
precio += dias * 7.00f;
Console.WriteLine("el precio sería: " +precio);