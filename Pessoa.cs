using System.Collections.Generic;
using System;

class Pessoa {
  private string nome;
  private string idade;
  private string matPref;
  private List<Pessoa>listaPessoas = new List<Pessoa>();
 
//contrutor
public Pessoa (string n,string i,string mPref){
nome = n;
idade = i;
maPref = mPref;
}
//gets e sets
  public string GetNome(){
   return nome;
   }
  public void SetNome(string n){
     nome = n;
   }

  public string GetIdade(){
     return idade;
     }
  public void SetIdade(string i){
     idade = i;
     }
  public int GetMatPref(){
   return matPref;
   }
  public void SetMatPref(double mPref){
     matPref = mPref;
   }
   }