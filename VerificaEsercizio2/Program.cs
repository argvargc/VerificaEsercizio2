string MSG_FREDDO = "Fa molto freddo (Gelo)";
string MSG_FRESCO = "Fa fresco";
string MSG_MITE = "Il clima è mite";
string MSG_CALDO = "Fa molto caldo";

float temperaturaInput  = 0.0f;
temperaturaInput = Convert.ToSingle(Console.ReadLine());

switch (temperaturaInput)
{
    case < 0:
        Console.WriteLine(MSG_FREDDO);
        break;
    case >= 0 and <= 18:
        Console.WriteLine(MSG_FRESCO);
        break;
    case >= 19 and <= 30:
        Console.WriteLine(MSG_MITE);
        break;
    case > 30:
        Console.WriteLine(MSG_CALDO);
        break;
    default:
        Console.WriteLine("Errore. ");
        break;
}