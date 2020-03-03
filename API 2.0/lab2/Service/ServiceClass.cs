public interface ITesteServico
{
    string Teste();
}

public class TesteServico : ITesteServico
{
    public string Teste()
    {
        return "Teste DI";
    }
}