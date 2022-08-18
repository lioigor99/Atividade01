using System;

namespace Classes;
public class Telefone
{
    private int DDD = 0, prefixo = 0, sufixo = 0;

    public Telefone(int DDD, int prefixo, int sufixo)
    {
        this.DDD = DDD;
        this.prefixo = prefixo;
        this.sufixo = sufixo;
    }
    public void setDDD(int DDD)
    {
        this.DDD = DDD;
    }
    public int getDDD()
    {
        return DDD;
    }
    public void setprefixo(int prefixo)
    {
        this.prefixo = prefixo;
    }
    public int getprefixo()
    {
        return prefixo;
    }
    public void setsufixo(int sufixo)
    {
        this.sufixo = sufixo;
    }
    public int getsufixo()
    {
        return sufixo;
    }
    public void imp()
    {
        Console.WriteLine("(" + DDD + ")" + prefixo + "-" + sufixo); 
    }
}