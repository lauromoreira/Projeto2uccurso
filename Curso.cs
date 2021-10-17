using System.Collections.Generic;
using System;

class Curso {
  private string tipo;
  private string duracao;
  protected double valor;
  private string vagas;
  protected double valorCarrinho;
  private int afinidade;

//contrutor
public Curso(string ti, string dur){
  tipo = ti;
  duracao = dur;
}

public Curso (string ti,string dur,double val,string vag){
tipo = ti;
duracao = dur;
valor = val;
vagas = vag;

}

public curso (){
  
}
//gets e sets
  public string GetTipo(){
   return tipo;
   }
  public void SetTipo(string ti){
     tipo = ti;
   }

  public string GetDuracao(){
     return duracao;
     }
  public void SetDuracao(string dur){
     duracao = dur;
     }
  public double GetValor(){
     return valor;
  }
  public void SetValor(double val){
     valor = val;
   }
    public string GetVagas(){
   return vagas;
   }
  public void SetVagas(string vag){
     vagas = vag;
   }
  //metodos
  

  public void adicionarCarrinho(int dinheiro) {
    valorCarrinho = dinheiro + valorCarrinho;
  }
}