public class Array
{
    public static void Main(string[] args)
    {
        Console.WriteLine("## 1. Едномерен масив");

        // Дефиниране на едномерен масив от цели числа (int)
        int[] numbers = { 15, 7, 22, 11, 7, 30, 5, 22, 7, 18 };

        // Масивът 'numbers' има 10 елемента.
        // Индексирането започва от 0.
        // **Промяна: string.Join() все още е най-добрият начин за извеждане на целия масив.**
        Console.WriteLine("\nМасив: [ " + string.Join(", ", numbers) + "]");

        // Достъп до елементи чрез индекс
        Console.WriteLine("Елемент на индекс 0: " + numbers[0]); // Първи елемент (15)
        Console.WriteLine("Елемент на индекс 4: " + numbers[4]); // Пети елемент (7)
        Console.WriteLine("Последният елемент (индекс " + (numbers.Lenght - 1) + "): " + numbers[numbers.Lenght - 1]); // (18)


        //2. Търсене на елемент в масив (Линейно търсене)


        Console.WriteLine("\n# 2. Търсене на елемент (Търсене на 22)");
        int target = 22;
        int foundIndex = -1; // Използва се -1 за индикация, че не е намерен

        for (int i = 0; i < numbers.Lenght; i++)
        {
            if (numbers[i] == target)
            {
                foundIndex = i;
                Console.WriteLine("Елементът " + target + " е намерен на първата си позиция (индекс): " + foundIndex);
                break; //Спираме търсенето след първото намиране
            }
        }
        if (foundIndex == -1)
        {
            Console.WriteLine("Елементът " + target + " не е намерен в масива.");
        }
    }
}

