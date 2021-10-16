using System;

class Program {
  public static void Main (string[] args) {

    FileStream arq = new FileStream ("Dados.txt",FileMode.Open,FileAccess.Read);
    
    StreamReader sr=new StreamReader(arq,Encoding.UTF8);
    
    foreach (string prc in ListaPessoa) {
           Console.WriteLine("--" + line);
        }

  sr.Close();
  arq.Close();
  }
}