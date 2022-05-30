using exemploLampadasOO;

int p1;
String m1;
Console.WriteLine("Olá mundo!!! Aqui, vamos cadastrar lampadas com o objetivo nenhum");
Console.WriteLine("Digite a potencia da lampada: ");
p1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a marca da lampada");
m1 = Console.ReadLine();
Lampada l = new Lampada(p1, m1);
l.ligar();
l.desligar();

/*
Console.WriteLine("A potencia da lampada é : "+l.potencia+" da marca: "+l.marca);
Lampada l2 = new Lampada(4, "ELG");
Console.WriteLine("A potencia da lampada é : " + l2.potencia + " da marca: " + l2.marca);
Lampada l3 = new Lampada(10, "HAVIC");
Console.WriteLine("A potencia da lampada é : " + l3.potencia + " da marca: " + l3.marca);
l2.ligar();
l2.desligar();
l3.ligar();
l3.desligar();
*/