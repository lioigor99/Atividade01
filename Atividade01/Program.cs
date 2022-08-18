using Classes;
using System;
using System.Collections;


Telefone t1 = new Telefone(31, 3319, 9500);
t1.imp();
Telefone t2 = new Telefone(31, 99510, 2056);
t2.imp();
DadosAlunos A1 = new DadosAlunos("(31) 9 9510-2056", 131199, "Igor Lio");
A1.imp1();
ListaAlunos L1 = new ListaAlunos();
L1.AdicionaAluno("Igor Miranda Lio Santos");
L1.AdicionaAluno("Marco Tullio Lio Santos");
L1.RemoveAluno("Marco Tullio Lio Santos");
L1.AdicionaAluno("Nayara Miranda Lio Santos");
L1.impLista();