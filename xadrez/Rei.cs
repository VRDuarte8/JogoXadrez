class Rei : Peca {

    private PartidaDeXadrez _partida;

    public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor){
        _partida = partida;
    }

    private bool PodeMover(Posicao pos){
        Peca p = Tab.Peca(pos);
        return p == null || p.Cor != Cor;
    }

    private bool TesteTorreParaRoque(Posicao pos){
        Peca p = Tab.Peca(pos);
        return p != null && p is Torre && p.Cor == Cor && p.QteMovimentos == 0;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

        Posicao pos = new Posicao(0,0);

        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha + 1 , Posicao.Coluna + 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
        if(Tab.PosicaoValida(pos) && PodeMover(pos)){
            mat[pos.Linha, pos.Coluna] = true;
        }

        //#jogadaespecial roque
        if(QteMovimentos==0 && !_partida.Xeque){
            //Pequeno
            Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
            if(TesteTorreParaRoque(posT1)){
                Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                if(Tab.Peca(p1) == null && Tab.Peca(p2) == null){
                    mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                }
            }
            //Grande
            Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
            if(TesteTorreParaRoque(posT2)){
                Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                if(Tab.Peca(p1) == null && Tab.Peca(p2) == null && Tab.Peca(p3) == null){
                    mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                }
            }
        }
        return mat;
    }



    public override string ToString()
    {
        return "R";
    }
}