namespace BibliotecaNet.Common
{
    public enum PessoaTipoEnum
    {
        Aluno,
        Autor,
        Profissional,
        Outros
    }

    public enum AcervoSituacaoEnum
    {
        Disponivel,
        Emprestado,
        Extraviado,
        EmManutencao
    }

    public enum SituacaoEmprestimo
    {
        Atrasado,
        Devolvido,
        Emprestado
    }
}
