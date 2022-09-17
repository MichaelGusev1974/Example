// Испытание "Орел или решка"
//В этой задаче вы подбрасываете монетку, чтобы отобразить либо headsили tails. Это идеальный сценарий для условного оператора.

Random coin = new Random();
int result = coin.Next(1,3);
Console.WriteLine((result == 1) ? "heads" : "tails");
