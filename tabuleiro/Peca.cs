﻿namespace Xadrez;

abstract class Peca{
    public Peca(Cor cor, Tabuleiro tab){
        posicao = null;
        this.cor = cor;
        this.tab = tab;
        qteMovimentos = 0;

    }

    public Posicao? posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qteMovimentos { get; set; }
    public Tabuleiro tab { get; protected set; }

    public void incrementarQteMovimentos(){
        qteMovimentos++;
    }

    public void decrementarQteMovimentos(){
        qteMovimentos--;
    }

    public bool existeMovimentosPossiveis(){
        bool[,] mat = movimentosPossiveis();
        for(int i = 0; i < tab.linhas; i++){
            for(int j = 0; j < tab.colunas; j++){
                if(mat[i, j]){
                    return true;
                }
            }
        }
        return false;
    }

    public bool movimentoPossivel(Posicao pos){
        return movimentosPossiveis()[pos.linha, pos.coluna];
    }

    public abstract bool[,] movimentosPossiveis();

}