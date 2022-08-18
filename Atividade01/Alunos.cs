using System;
using System.Collections;

namespace Classes;

public class DadosAlunos
{
    public int Matricula = 00000;
    public string Nome = "nome", Tel = "(00) 0 0000-0000";

    public DadosAlunos(string Telefone, int Matricula, string Nome)
    {
        this.Tel = Telefone;
        this.Matricula = Matricula;
        this.Nome = Nome;
    }

    public void setTelefone(string Telefone)
    {
        this.Tel = Telefone;
    }

    public string getTelefone()
    {
        return Tel;
    
    }
    
    public void setMatricula(int Matricula)
    {
        this.Matricula = Matricula;
    }
    
    public int getMatricula()
    {
        return Matricula;
    }
    
    public void setNome(string Nome)
    {
        this.Nome = Nome;
    }
    
    public string getNome()
    {
        return Nome;
    }
    
    public void imp1()
    {
        Console.WriteLine(Nome + ", " + Matricula + ", " + Tel);
    }
}
