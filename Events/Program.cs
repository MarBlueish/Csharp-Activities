namespace Events;

class Publicador
{
    //Etapa 1.1- Criar um delegate cujo nome seja
    //"nomedoevento"+EventHandler
    public delegate void TrabalhoFeitoEventHandler(object sender, EventArgs args);
    
    //Etapa 1.2 - Criar um evento baseado no delegate
    public event TrabalhoFeitoEventHandler TrabalhoFeito;

    public void ProcessaumTrabalho()
    {
        Console.WriteLine("Publicador: Um trabalho foi concluido");
        //Etapa 1.3- Dispara o evento
        OnTrabalhoFeito();
    }
    // o padrao do c# standard requer que o metodo seja definido como protected virtual.
    // o nome tambem precisa coicidir com o nome do evento e tera que ter o prefixo
    //com on.*/
    protected virtual void OnTrabalhoFeito()
    {
        if (TrabalhoFeito != null)
            TrabalhoFeito(this, EventArgs.Empty);
        
    }
}
//etapa 2- criar um subscritor
class Subscriber
{
    public void OnTrabalhoFeitoEventHandler(object sender, EventArgs args)
    {
        Console.WriteLine("O subscritor foi notificado");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Evento Exemplo");
        //criar instancia do Editor e do assinante
        Publicador remetente = new Publicador();
        Subscriber receptor = new Subscriber();
        //define o tratamento do evento, aqui subscrevemos o subcritor as notificações do publicado
        remetente.TrabalhoFeito += receptor.OnTrabalhoFeitoEventHandler;
        
        //define o tratamento do evento, aqui deixamos de subscrever o subscritor as notificações do publicado
        //rementente.Trabalhofeito += receptor.OnTrabalhoFeitoEventHandler;
        
        //Invoca
        remetente.ProcessaumTrabalho();
        Console.ReadKey();

    }
}