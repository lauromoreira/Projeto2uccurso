using System.Collections.Generic;
using System;

class Negocio {
  private string venda;
  private string dataEncerramento;
  private List<Curso>cursosTotais = new List<Curso>();

//construtor
public Negocio (string venda,string dataEnc){
ven = venda;
dataEnc = dataEncerramento;
}
//metodos
public void AdicionarCurso(Curso c){
    cursosTotais.Add(c);
  }

 public double checarVagas(){
   double matriculados = 0;
   foreach(Curso c in cursoTotais){
     matriculados = c.vagas + matriculados;
   }
   return matriculados;
 }
 double af = 0;
 string x1 = 0;
 double x2 = 0;
 public void CalcularSimilaridade(){
   foreach (string linha in cursoTotais) {
    x1=sr.ReadLine();
    x2=srReadLine();
    
    x1 = (lines[3])-(lines[6]);
    x2 = (lines[6])-(lines[9]);
    af = x1 + x1 ^0,5;
    return af;
 //distribuir preferencias  
 //HXY significando a diferença de valor de honestidade entre os candidatos X e Y.
 //EXY será a diferença de valor de experiência entre os mesmos.
// d(x,y) = ^h²xy + e²xy
//(b3-b2)^2+(c3-c2)^2+(d3-d2)^2)^0,5
 }
}
}
