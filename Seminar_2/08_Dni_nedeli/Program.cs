// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите номер дня недели");
int n = int.Parse(Console.ReadLine());
if ((n < 0) || (n > 7))
{
    Console.WriteLine("Некорректный номер. В неделе 7 дней.");
}
else
{
if (n < 6)
{
    Console.WriteLine("Это не выходной :(");
}
else
{
if (n < 7)
{
    Console.WriteLine("Суббота! Ура, выходной! :)");
}
else
{

    Console.WriteLine("Воскресенье! Ура, выходной! :)");

}}}

