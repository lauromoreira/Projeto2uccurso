using System;

class Exatas : Curso{
  
  protected void visualizarSimilaridade (string tipo, int afinidade){
    string tip = tipo;
    if (afinidade == 1 ){
      Console.WriteLine("Listar Cursos Exatas");
    }
  }
}