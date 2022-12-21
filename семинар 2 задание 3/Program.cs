                                            //Задание 19
/*bool IsPalindrome(string numStr)
{
    for (int i = 0, j = numStr.Length - 1; 
        i < j; 
        i++, j--
        )
    {
        if (numStr[i] != numStr[j])
            return false;
    }

    return true;
}

Console.Write("Введите 5-ти значное число: ");
    var numStr = Console.ReadLine();
    var result = IsPalindrome(numStr) ? "да" : "нет";
Console.WriteLine($"{numStr} -> {result}"); */

                                        //Задание 21

/*const string DelimeterDefault = " ";
float GetDistanceBetweenTwoPoints(
    IReadOnlyList<int> pointA,
    IReadOnlyList<int> pointB
    )
{
    return (float)Math.Sqrt(
           Math.Pow(pointA[0] - pointB[0], 2) +
           Math.Pow(pointA[1] - pointB[1], 2) +
           Math.Pow(pointA[2] - pointB[2], 2)
        );
}
IReadOnlyList<int> GetPointData(string pointName)
{
Console.Write($"Введите значения для точки '{pointName}' через пробел: ");
    return Console.ReadLine()
        .Split(DelimeterDefault)
        .Select(num => int.Parse(num))
        .ToList();
}
void ShowPointData(IReadOnlyList<int> point, string pointName)
    => Console.Write("{0}({1}, {2}, {3})", pointName, point[0], point[1], point[2]);
void ShowResult(
    IReadOnlyList<int> pointA,
    IReadOnlyList<int> pointB,
    float distance)
{
    ShowPointData(pointA, "A");
    Console.Write(";");
    ShowPointData(pointB, "B");
Console.Write(", -> {0:0.00}", distance);
}
    var pointA = GetPointData("A");
    var pointB = GetPointData("B");
    var distance = GetDistanceBetweenTwoPoints(pointA, pointB);
ShowResult(pointA, pointB, distance);*/
                                        
                                        //Задание 23
/*
IReadOnlyList<int> GetCubesN(int N)
{
    var cubes = new List<int>(N) { 1 };
    for (int i = 2; i <= N; i++)
        cubes.Add(
            (int)Math.Pow(i, 3)
        );
    return cubes;
}
Console.Write("Введите число N: ");
    var N = int.Parse(Console.ReadLine());
    var cubes = GetCubesN(N);
Console.WriteLine($"{N} -> {string.Join(", ", cubes)}");
*/