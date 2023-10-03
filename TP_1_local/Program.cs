while (true)
{
	Console.Write("Введите первое число: ");
	double num1;
	if (!double.TryParse(Console.ReadLine(), out num1))
	{
		Console.WriteLine("Ошибка! Некорректные данные");
		continue;
	}

	Console.Write("Введите оператор (+, -, *, /): ");
	char operation = Console.ReadLine().Trim()[0];

	Console.Write("Введите второе число: ");
	double num2;
	if (!double.TryParse(Console.ReadLine(), out num2))
	{
		Console.WriteLine("Ошибка! Некорректные данные");
		continue;
	}

	double result = 0;

	switch (operation)
	{
		case '+':
			result = num1 + num2;
			break;
		case '-':
			result = num1 - num2;
			break;
		case '*':
			result = num1 * num2;
			break;
		case '^':
			result = Math.Pow(num1, num2);
			break;
		case '/':
			if (num2 != 0)
				result = num1 / num2;
			else
				Console.WriteLine("Ошибка! Деление на ноль");
			break;
		default:
			Console.WriteLine("Оперетор указан неверно. Введите +, -, *, ^ или /");
			continue;
	}

	Console.WriteLine($"Результат: {result}");
	Console.WriteLine("------");
}
