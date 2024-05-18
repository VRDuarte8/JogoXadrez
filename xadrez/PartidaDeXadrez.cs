class PartidaDeXadrez{
    public Tabuleiro Tab { get; private set; }
    private int _turno;
    private Cor _jogadorAtual;
    public bool Terminada { get; private set; }

    public PartidaDeXadrez(){
        Tab = new Tabuleiro(8,8);
        _turno = 1;
        _jogadorAtual = Cor.Branca;
        Terminada = false;
        ColocarPecas();
    }
    
    public void ExecutaMovimento(Posicao origem, Posicao destino){
        Peca? p = Tab.RetirarPeca(origem);
        p.IncrementarQteMovimentos();
        Peca? pecaCapturada = Tab.RetirarPeca(destino);
        Tab.ColocarPeca(p, destino);
    }

    private void ColocarPecas(){
        Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a',1).ToPosicao());
        Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('b',1).ToPosicao());
        Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('c',1).ToPosicao());
        Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d',1).ToPosicao());
        Tab.ColocarPeca(new Rainha(Tab, Cor.Preta), new PosicaoXadrez('e',1).ToPosicao());
        Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('f',1).ToPosicao());
        Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('g',1).ToPosicao());
        Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h',1).ToPosicao());

        Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a',8).ToPosicao());
        Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('b',8).ToPosicao());
        Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('c',8).ToPosicao());
        Tab.ColocarPeca(new Rainha(Tab, Cor.Branca), new PosicaoXadrez('d',8).ToPosicao());
        Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e',8).ToPosicao());
        Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('f',8).ToPosicao());
        Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('g',8).ToPosicao());
        Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h',8).ToPosicao());
    }
}