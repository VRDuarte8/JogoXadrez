try{
    PartidaDeXadrez partida = new();
    while (!partida.Terminada){
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        System.Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

        System.Console.WriteLine();
        System.Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
        partida.ExecutaMovimento(origem, destino);
    }
}
catch (TabuleiroException e){
    System.Console.WriteLine(e.Message);
}

