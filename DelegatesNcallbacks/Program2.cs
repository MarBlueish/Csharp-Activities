namespace DelegatesNcallbacks;

class Program2
{
    //1.1 funçao pronta a ser chamada com os mesmos parametros do ponto 2.1
    static void myCallBackCao(int i)
    {
        Console.WriteLine("Ladrar" +i);
    }
    
    //1.2 Outra funçao pronta a ser chamada pelo mesmo delegate que apresenta os mesmos parametros
    static void myCallBackGato(int i)
    {
        Console.WriteLine("Miar" + i);
    }
    
    static void Main2(string[] args)
    {
        //1.3 criaçao do objeto da classe Meutrabalho onde esta disponivel o delegate
        meuTrabalho myObj = new meuTrabalho();
       
        //1.4 fazer chamada da instancia com o callback correspondente
        myObj.FazerSom(myCallBackCao);
        myObj.FazerSom(myCallBackGato);

    }
}

class meuTrabalho
{
    //2.1 Delegate serve como uma especie de assinatura ou indicação de como irá ser a função enviada por um
    //parametro, neste caso fico a saber que as funções que chegam chamadas através deste delegate apenas
    //poderão ter um int como parametro
    //mycallbackcao e mycallbackgato seguem esses parametros
    public delegate void myCallBackPointer(int i);
    
    //2.2 funcao que ira receber os delegates como parametro, reparar que o tipo de parametro é igual ao delegate
    //criado na linha anterior
    public void FazerSom(myCallBackPointer NewObj)
    {
        for (int i = 0; i < 10; i++)
        {
            //2.3 aqui estamos a chamar indiretamente a função mycallbackcao e mycallbackgato, dependendo
            //do delegate, enviado a quando da chamada desta função no main
            NewObj(i);
        }
    }
    
}