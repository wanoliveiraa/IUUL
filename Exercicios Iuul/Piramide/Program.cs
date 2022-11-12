namespace Piramide;
class Program
{
    static void Main(string[] args){
        int num=0;
        Console.WriteLine("Digite um numero maior que 1:");
        num=Convert.ToInt32(Console.ReadLine());
        int z = 0;
        for (int i = 0; i < num; i++){
            for (int j = 0; j < (num - i) + 1; j++) {
                Console.Write(" ");
            }
            for (z = 0; z < i + 1; z++) {
                Console.Write(z + 1 + "");
            }
            for (z = z - 1; z > 0; z--){
                Console.Write(z);
            }
            Console.WriteLine("");

        }

    }
}
