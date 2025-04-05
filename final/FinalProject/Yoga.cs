class Yoga : Clases
{

    private string _nameProfesor;
    private string _opcionHorario;

    public string NameProfesor
    {
        get => _nameProfesor;
        set => _nameProfesor = value;
    }

    public string Opcion
    {
        get => _opcionHorario;
        set => _opcionHorario = value;
    }

    public Yoga() : base("Yoga") { }

    public Yoga(string nombre) : base(nombre)
    {
        nombre = "Yoga";
    }

    public override void ChooseSchedule()
    {
        Console.Clear();
        Console.WriteLine("Choose the time for the Yoga class:");
        Console.WriteLine("1. Monday 10:00 AM - 11:00 AM");
        Console.WriteLine("2. Wednesday 6:00 PM - 7:00 PM");
        Console.WriteLine("3. Friday 5:00 PM - 6:00 PM");
        Console.Write("Select an option: ");
        int numero = int.Parse(Console.ReadLine());
        string[] horario = { "Monday 10:00 AM - 11:00 AM", "Wednesday 6:00 PM - 7:00 PM", "Friday 5:00 PM - 6:00 PM" };
        Opcion = horario[numero - 1];
        Console.WriteLine("You have selected: " + Opcion);
        Console.WriteLine("Press enter to continue...");
    }

    public override void ChooseInstructor()
    {
        Console.Clear();
        Console.WriteLine("Choose an instructor for the Yoga class:");
        Console.WriteLine("1. Instructor Sergio Bravo");
        Console.WriteLine("2. Instructor Luis Chompol");
        Console.WriteLine("3. Instructor Ernesto Garcia");
        Console.WriteLine("4. Instructor Maria Lopez");
        Console.Write("Select an option: ");
        int numero = int.Parse(Console.ReadLine());
        string[] instructor = { "Instructor Sergio Bravo", "Instructor Luis Chompol", "Instructor Ernesto Garcia", "Instructor Maria Lopez" };
        NameProfesor = instructor[numero - 1];
        Console.WriteLine("You have selected: " + NameProfesor);
        Console.WriteLine("Press enter to continue...");
    }

    public override void showDetails()
    {
        Console.Clear();
        Console.WriteLine("**********************************************");
        Console.WriteLine("*           Your registration details        *");
        Console.WriteLine("**********************************************");
        Console.WriteLine("Class: " + GetNombreClass());
        Console.WriteLine("Instructor: " + NameProfesor);
        Console.WriteLine("Schedule: " + Opcion);

        Console.WriteLine("\nYour class registration has been successfully saved..");
    }
}