using System.Drawing;

class Progmram
{
    static void Main()
    {
        Passwords passwords = new Passwords(3);
        Logins logins = new Logins(3);

        void LateRegistration(string login, string password)
        {
            logins.AddData(logins.GetLength(),login);
            passwords.AddData(passwords.GetLength(), password);
            Console.WriteLine($"Пользователь с логином {login} и паролем {password} зарегистрирован");
        }

        LateRegistration("args", "seven");
        LateRegistration("lemon", "six");
    }
}
public class Massiv<T>
{
    public T[] array;
    public int length;

    public Massiv(int size)
    {
        array = new T[size];
        length = size;
    }
    public void AddData(int index, T element)
    {
        if (index >= 0 && index < length)
        {
            array[index] = element;
        }
        else
        {
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    public void RemoveData(int index)
    {
        if (index < 0 || index >= length)
        {
            Console.WriteLine("Недопустимый индекс.");
        }

        for (int i = index; i < length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        length--;
    }

    public T GetData(int index)
    {
        if (index >= 0 && index < length)
        {
            return array[index];
        }
        Console.WriteLine("Недопустимый индекс.");
        return default(T);

    }

    public int GetLength()
    {
        return length;
    }
}
public class Logins : Massiv<string>
{
    public Logins(int length) : base(length)
    {

    }
}

public class Passwords : Massiv<string>
{
    public Passwords(int length) : base(length)
    {

    }
}