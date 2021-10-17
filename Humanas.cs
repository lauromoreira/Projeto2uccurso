using System;
class Humanas : Curso{
  
  protected void visualizarSimilaridade (string tipo, int afinidade){
    int afi = afinidade;
    string tip = tipo;
    if (afi == 1) {
      Console.WriteLine("Listar Cursos Humanas");
    }
  }
}
