int c = 0;

void tambah(int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(8, 2);
kurang(5, 2);
tambah(10, 3);
kali(11, 5);
bagi(5, 22);
