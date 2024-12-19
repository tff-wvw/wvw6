using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nВыберите задание (1-10) или введите 0 для выхода:");
            Console.WriteLine("1. Реализовать динамический массив (Add, Remove, Get)");
            Console.WriteLine("2. Слияние двух динамических массивов");
            Console.WriteLine("3. Удаление дубликатов из динамического массива");
            Console.WriteLine("4. Поиск элемента в динамическом массиве");
            Console.WriteLine("5. Сортировка динамического массива");
            Console.WriteLine("6. Реверс динамического массива");
            Console.WriteLine("7. Копирование динамического массива");
            Console.WriteLine("8. Сравнение двух динамических массивов");
            Console.WriteLine("9. Изменение размера динамического массива");
            Console.WriteLine("10. Поиск максимального и минимального элемента");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 10)
            {
                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Выход из программы.");
                        break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число от 0 до 10.");
            }
        }
    }

    static void Task1()
    {
        Console.WriteLine("Задание 1: Реализовать динамический массив.");
        var array = new DynamicArray<int>();
        Console.WriteLine("Введите элементы массива (через пробел):");
        foreach (var item in Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>())
        {
            array.Add(item);
        }

        Console.WriteLine($"Текущий массив: {array}");
        Console.WriteLine("Введите элемент для удаления:");
        int remove = int.Parse(Console.ReadLine() ?? "0");
        array.Remove(remove);
        Console.WriteLine($"Массив после удаления: {array}");
        Console.WriteLine("Введите индекс для получения элемента:");
        int index = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Элемент по индексу {index}: {array.Get(index)}");
    }

    static void Task2()
    {
        Console.WriteLine("Задание 2: Слияние двух динамических массивов.");
        Console.WriteLine("Введите первый массив:");
        var array1 = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine("Введите второй массив:");
        var array2 = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());

        var merged = array1.Merge(array2);
        Console.WriteLine($"Слияние массивов: {merged}");
    }

    static void Task3()
    {
        Console.WriteLine("Задание 3: Удаление дубликатов.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        array.RemoveDuplicates();
        Console.WriteLine($"Массив без дубликатов: {array}");
    }

    static void Task4()
    {
        Console.WriteLine("Задание 4: Поиск элемента.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine("Введите искомый элемент:");
        int value = int.Parse(Console.ReadLine() ?? "0");
        int index = array.Find(value);
        Console.WriteLine(index == -1 ? "Элемент не найден" : $"Элемент найден на индексе: {index}");
    }

    static void Task5()
    {
        Console.WriteLine("Задание 5: Сортировка массива.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        array.Sort();
        Console.WriteLine($"Отсортированный массив: {array}");
    }

    static void Task6()
    {
        Console.WriteLine("Задание 6: Реверс массива.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        array.Reverse();
        Console.WriteLine($"Реверс массива: {array}");
    }

    static void Task7()
    {
        Console.WriteLine("Задание 7: Копирование массива.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        var copied = array.Copy();
        Console.WriteLine($"Скопированный массив: {copied}");
    }

    static void Task8()
    {
        Console.WriteLine("Задание 8: Сравнение массивов.");
        Console.WriteLine("Введите первый массив:");
        var array1 = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine("Введите второй массив:");
        var array2 = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine(array1.Equals(array2) ? "Массивы равны" : "Массивы не равны");
    }

    static void Task9()
    {
        Console.WriteLine("Задание 9: Изменение размера массива.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine("Введите новый размер:");
        int newSize = int.Parse(Console.ReadLine() ?? "0");
        array.Resize(newSize);
        Console.WriteLine($"Массив после изменения размера: {array}");
    }

    static void Task10()
    {
        Console.WriteLine("Задание 10: Поиск максимального и минимального элемента.");
        Console.WriteLine("Введите массив:");
        var array = new DynamicArray<int>(Console.ReadLine()?.Split().Select(int.Parse) ?? Array.Empty<int>());
        Console.WriteLine($"Максимальный: {array.Max()}, Минимальный: {array.Min()}");
    }
}

class DynamicArray<T>
{
    private List<T> _items;

    public DynamicArray() => _items = new List<T>();

    public DynamicArray(IEnumerable<T> items) => _items = new List<T>(items);

    public void Add(T item) => _items.Add(item);

    public void Remove(T item) => _items.Remove(item);

    public T Get(int index) => _items[index];

    public DynamicArray<T> Merge(DynamicArray<T> other)
        => new DynamicArray<T>(_items.Concat(other._items));

    public void RemoveDuplicates() => _items = _items.Distinct().ToList();

    public int Find(T item) => _items.IndexOf(item);

    public void Sort() => _items.Sort();

    public void Reverse() => _items.Reverse();

    public DynamicArray<T> Copy() => new DynamicArray<T>(_items);

    public void Resize(int newSize)
    {
        if (newSize < _items.Count)
            _items = _items.Take(newSize).ToList();
        else
            _items.AddRange(Enumerable.Repeat(default(T), newSize - _items.Count));
    }

    public T Max() => _items.Max();

    public T Min() => _items.Min();

    public override string ToString() => string.Join(", ", _items);

    public override bool Equals(object obj)
    {
        var other = obj as DynamicArray<T>;
        if (other == null) return false;

        if (_items.Count != other._items.Count) return false;

        for (int i = 0; i < _items.Count; i++)
        {
            if (!EqualityComparer<T>.Default.Equals(_items[i], other._items[i]))
                return false;
        }

        return true;
    }

    public override int GetHashCode() => _items.GetHashCode();
}
