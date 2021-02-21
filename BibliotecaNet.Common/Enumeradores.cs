namespace BibliotecaNet.Common
{
    public enum PessoaTipoEnum
    {
        Aluno = 1,
        Autor = 2,
        Profissional = 3,
        Outros = 4
    }

    public enum AcervoSituacaoEnum
    {
        Disponivel = 1,
        Emprestado = 2,
        Extraviado = 3,
        EmManutencao = 4
    }

    public enum SituacaoEmprestimo
    {
        Atrasado = 1,
        Devolvido = 2,
        Emprestado = 3
    }
}
