try{
    PartidaDeXadrez partida = new();
    while (!partida.Terminada){
        try{
            Console.Clear();
            Tela.ImprimirPartida(partida);

            System.Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

            System.Console.WriteLine();
            System.Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);
            partida.RealizaJogada(origem, destino);
        }
        catch(TabuleiroException e){
            System.Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
}
catch (TabuleiroException e){
    System.Console.WriteLine(e.Message);
}

