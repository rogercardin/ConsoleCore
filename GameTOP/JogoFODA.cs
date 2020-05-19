namespace  GameTOP
{
    
    public class jogoFoda
    {
        private  readonly Jogador _jogador;
            public jogoFoda(Jogador jogador)
            {
            _jogador = jogador;
           
            }

      
        public void IniciarJogo()
        {
            _jogador.Corre();
            _jogador.Chuta();
            _jogador.Passa();
        }
    }
}


