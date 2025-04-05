class Boxeo: Clases{
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
    public Boxeo() : base("Boxeo") { }

    public Boxeo(string nombre) : base(nombre) {
        nombre = "Boxeo";
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
        Console.WriteLine("2. Instructor Francisco Bravo");
        Console.WriteLine("3. Instructor Jimmy Bravo");
        Console.WriteLine("4. Instructor Daniel Bravo");
        Console.Write("Select an option: ");
        int numero = int.Parse(Console.ReadLine());
        string[] instructor = { "Sergio Bravo", "Francisco Bravo", "Jimmy Bravo", "Daniel Bravo" };
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