class Bispo : Peca {
    public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor){
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
        return mat;
    }

    public override string ToString()
    {
        return "B";
    }
}