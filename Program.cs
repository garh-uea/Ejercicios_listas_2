// Clase que representa una Materia con su nota
public class Materia
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    public Materia(string nombre)
    {
        Nombre = nombre;
        Nota = 0.0;
    }

    public void AsignarNota(double nota)
    {
        Nota = nota;
    }
}

// Clase que representa un Curso con varias materias
public class Curso
{
    public string NombreCurso { get; set; }
    private List<Materia> materias;

    public Curso(string nombreCurso)
    {
        NombreCurso = nombreCurso;
        materias = new List<Materia>();
    }

    public void AgregarMateria(string nombreMateria)
    {
        materias.Add(new Materia(nombreMateria));
    }

    public void RegistrarNotas()
    {
        Console.WriteLine($"\nREGISTRO DE NOTAS PARA EL CURSO: {NombreCurso}\n");

        foreach (var materia in materias)
        {
            Console.Write($"Ingrese la nota para {materia.Nombre}: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                materia.AsignarNota(nota);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Se asigna nota 0 por defecto.");
                materia.AsignarNota(0);
            }
        }
    }

    public void MostrarNotas()
    {
        Console.WriteLine($"\nRESULTADOS FINALES DEL CURSO: {NombreCurso}");
        Console.WriteLine("====================================================");

        foreach (var materia in materias)
        {
            Console.WriteLine($"En {materia.Nombre} has sacado {materia.Nota}");
        }

        Console.WriteLine("====================================================");
    }
}

class Programa
{
    static void Main()
    {
        // Crear el curso con un nombre
        Curso curso = new Curso("Segundo de Bachillerato U. E. Juan XXIII");

        // Agregar materias al curso
        curso.AgregarMateria("Matemáticas");
        curso.AgregarMateria("Física");
        curso.AgregarMateria("Ciencias");
        curso.AgregarMateria("Artística");
        curso.AgregarMateria("Lengua");

        // Registra las notas ingresadas por el usuario
        curso.RegistrarNotas();

        // Muestra los resultados
        curso.MostrarNotas();
    }
}

