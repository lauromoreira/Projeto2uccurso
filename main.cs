//using System;
//using System.IO.Stream;

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    FileStream arq = new FileStream ("Dados.txt",FileMode.Open,FileAccess.Read);
    
    StreamReader sr = new StreamReader(arq,Encoding.UTF8);
    
    foreach (string prc in Pessoa.ListaPessoa) {
     Console.WriteLine("--" + line);
    }

    sr.Close();
    arq.Close();
  }
}