using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");