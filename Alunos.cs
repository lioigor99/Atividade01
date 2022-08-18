using System;

class Alunos
{
    private int Matricula = 0;
    private char Nome = "nome",Telefone = "(00) 0 0000-0000";

    public Alunos(char Telefone, int Matricula, char Nome)
    {
        this.Telefone = Telefone;
        this.Matricula = Matricula;
        this.Nome = Nome;
    }

    public void setTelefone(char Telefone)
    {
        this.Telefone = Telefone;
    }
    public int getTelefone()
    {
        return Telefone;
    }
    public void setMatricula(int Matricula)
    {
        this.Matricula = Matricula;
    }
    public int getMatricula()
    {
        return Matricula;
    }
    public void setNome(char Nome)
    {
        this.Nome = Nome;
    }
    public int getNome()
    {
        return Nome;
    }
    public void imp()
    {
        Console.WriteLine(Nome+", "+Matricula+", "+Telefone);
    }
    public static void Main()
    {
        Alunos A1 = new Alunos("(31) 9 9510-2056", 131199, "Igor Lio");
        A1.imp();
    }
}
