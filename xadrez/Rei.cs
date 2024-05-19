class Rei : Peca {
    public Rei(Tabuleiro tab, Cor cor) : base(tab, cor){
    }

    private bool PodeMover(Posicao pos){
        Peca p = Tab.Peca(pos);
        return p == null || p.Cor != Cor;
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
        return mat;
    }



    public override string ToString()
    {
        return "R";
    }
}