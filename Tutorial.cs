class Tutorial : Curso
{
   private static double tempoLimite;

   public Tutorial(string tipo, string duracao) : base(tipo,duracao)
   { }

   static Tutorial() => tempoLimite = 1;


}