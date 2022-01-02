// O programa clica a cada 2 minutos na posição que o mouse estiver



using AutoClickTimer;

Console.WriteLine("O programa clica a cada 2 minutos na posição que o mouse estiver...");


while (true)
{
    Console.WriteLine("Aguarde 2 minutos!");

    Thread.Sleep(120000);

    MouseUtils mouse = new MouseUtils();

    mouse.click();

    Console.WriteLine("Clicado!");
}