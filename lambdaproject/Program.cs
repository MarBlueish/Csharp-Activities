// Assuming 'indexador' is an array or a collection in your context
// Replace 'TipoDoElemento' with the actual type of elements in 'indexador'

TipoDoElemento[] indexador = new TipoDoElemento[] { /* initialize your array here */ };

List<double> notas = new List<double>() { indexador[0].Nota, indexador[1].Nota, indexador[2].Nota };

Func<List<double>, List<double>> filtrarNotasAltas = lista =>
{
    List<double> notasAltas = new List<double>();

    foreach (var item in lista)
    {
        if (item > 8.0f)
        {
            notasAltas.Add(item);
        }
    }

    return notasAltas;
};

List<double> notasAltas = filtrarNotasAltas(notas);

Console.WriteLine("Resposta: ");
Console.WriteLine("Notas Altas:");
foreach (double nota in notasAltas)
{
    Console.Write("{" + nota + "]");
}
