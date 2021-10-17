using System.Collections.Generic;
using System;

class Pessoa {
  private string nome;
  private int idade;
  private string matPref;
  public List<Pessoa> ListaPessoa = new List<Pessoa>();
 
 
//contrutor
public Pessoa (string n,int i,string mPref){
nome = n;
idade = i;
matPref = mPref;
}
//gets e sets
  public string GetNome(){
   return nome;
   }
  public void SetNome(string n){
     nome = n;
   }

  public int GetIdade(){
     return idade;
     }
  public void SetIdade(int i){
     idade = i;
     }
  public int GetMatPref(){
   return matPref;
   }
  public void SetMatPref(double mPref){
     matPref = mPref;
   }
  }