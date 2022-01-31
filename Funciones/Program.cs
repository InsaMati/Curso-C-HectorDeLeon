// See https://aka.ms/new-console-template for more information

int a = 1;
int b = 2;

Show();

Console.WriteLine(Sum(a, b));

// 3 tipos de funciones

static int Sum(int a, int b) {

    return a + b;
}

static void Show() {

    Console.WriteLine("Texto que se imprime desde una funcion");

}