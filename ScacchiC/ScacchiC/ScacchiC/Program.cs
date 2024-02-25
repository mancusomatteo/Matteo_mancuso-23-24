// See https://aka.ms/new-console-template for more information
using ScacchiC;

Scacchiera scacchiera  = new Scacchiera();
Pedina cavallo = new Cavallo(Pedina.Colore.Black, 5, 0, scacchiera);
Pedina torre = new Torre(Pedina.Colore.Black, 3, 1, scacchiera);
Pedina regina = new Regina(Pedina.Colore.Black, 3, 3, scacchiera);
scacchiera.posizionaPedina(5, 0, cavallo);
scacchiera.posizionaPedina(3, 1, torre);
scacchiera.posizionaPedina(3, 3, regina);
scacchiera.visualizza();        
//regina.muovi(4,5);
//scacchiera.visualizza();

