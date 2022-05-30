/*a = 4, b = 5, c = 9, d = 1;


((a!=0) && b == 5)                                      true

4 != 0 -> verdade
e
5 == 5 -> verdade

(a > 3 || d == 1)                                       true

4 > 3 -> verdade
ou
1 == 1 -> verdade

!((a > 3 || d < 3) && (b < c && b > c))                 true      

4 > 3 -> verdade
ou 
1 < 3 -> verdade
e
5 < 9 -> verdade
e
5 > 9 -> false
false

(não)false -> verdade 

(b != 0 || a > 4) || (d < 3 && c >= 8)                  true

5 !=0 -> verdade    falso
ou
4  > 4 -> falso

((ou))

1 < 3 -> verdade     verdade
e
9 >= 8 -> verdade

((a > d || a < d) || a == 4) || (!(b == 5 && b > c))    true

se a == d -> seria falso
*/

int a = 4, b = 5, c = 9, d = 1;

Console.WriteLine((a != 0) && b == 5);
Console.WriteLine(a > 3 || d == 1);
Console.WriteLine(!((a > 3 || d < 3) && (b < c && b > c)));
Console.WriteLine((b != 0 || a > 4) || (d < 3 && c >= 8));
Console.WriteLine(((a > d || a < d) || a == 4) || (!(b == 5 && b > c)));