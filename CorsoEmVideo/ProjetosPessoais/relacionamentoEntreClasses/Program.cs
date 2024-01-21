Lutador[] listaLutadores = new Lutador [6];
listaLutadores[0] = new Lutador("Pretty Boy", "França", 31, 1.75f, 68.9f, 11, 2, 1);
listaLutadores[1] = new Lutador("Putscript", "Brasil", 29, 1.68f, 57.8f, 14, 2, 3);
listaLutadores[2] = new Lutador("Snapshadow", "EUA", 35, 1.65f, 80.9f, 12, 2, 1);
listaLutadores[3] = new Lutador("Dead Code", "Austrália", 28, 1.93f, 81.6f, 13, 0, 2);
listaLutadores[4] = new Lutador("Ufocobol", "Brasil", 37, 1.7f, 119.3f, 5, 4, 3);
listaLutadores[5] = new Lutador("Nerdart", "EUA", 30, 1.81f, 105.7f, 12, 2, 4);
//listaLutadores[0].Status();

Luta luta2 = new Luta();
luta2.MarcarLuta(listaLutadores[3], listaLutadores[2]);
luta2.Lutar();



