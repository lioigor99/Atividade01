using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;

public class ListaAlunos
{
    ArrayList alunos = new ArrayList();

    public void AdicionaAluno(string a)
    {
        alunos.Add(a);
    }


    public void RemoveAluno(string a)
    {
        alunos.Remove(a);
    }
    public void imp2()
    {
        for (int i = 0; i < alunos.Count; i++)
            Console.WriteLine(alunos[i]);
    }
}
