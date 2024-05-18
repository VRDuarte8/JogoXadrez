﻿try{
    Tabuleiro tab = new(8,8);

    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0,2));
    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(6,3));
    tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7,4));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e){
    System.Console.WriteLine(e.Message);
}

