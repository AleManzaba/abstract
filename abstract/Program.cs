// Clase abstracta Animal
public abstract class Animal
{
    // Método abstracto para hacer un sonido
    public abstract void HacerSonido();

    // Método no abstracto para dormir (comportamiento común para todos los animales)
    public void Dormir()
    {
        Console.WriteLine("zzz");
    }
}

// Clase concreta Perro
public class Perro : Animal
{
    // Implementación del método HacerSonido para Perro
    public override void HacerSonido()
    {
        Console.WriteLine("¡Guau!");
    }
}

// Clase concreta Gato
public class Gato : Animal
{
    // Implementación del método HacerSonido para Gato
    public override void HacerSonido()
    {
        Console.WriteLine("¡Miau!");
    }
}

// Clase concreta Pato
public class Duck : Animal
{
    // Implementación del método HacerSonido para Pato
    public override void HacerSonido()
    {
        Console.WriteLine("¡Cuac!");
    }
}

// Clase concreta Ave
public class Bird : Animal
{
    // Implementación del método HacerSonido para Ave
    public override void HacerSonido()
    {
        Console.WriteLine("¡Chirp!");
    }
}

// Ejemplo de uso
class Program
{
    // Método para crear una instancia de una clase de animal según el nombre dado por el usuario
    public static Animal CreateAnimal(string name)
    {
        switch (name.ToLower())
        {
            case "perro":
                return new Perro();
            case "gato":
                return new Gato();
            case "pato":
                return new Duck();
            case "bird":
                return new Bird();
            default:
                throw new ArgumentException("No se encontró una clase de animal válida para: " + name);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre de un animal: Perro, Gato, Pato o Ave");
        string animalName = Console.ReadLine();

        Animal animal = CreateAnimal(animalName);
        animal.HacerSonido();
        animal.Dormir();
    }
}