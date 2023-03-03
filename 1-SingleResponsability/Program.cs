using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
ExportHelperGeneric<Student> exportHelperGeneric = new();
// Se exporta informacion a archico csv enviando un objeto especifico
exportHelper.ExportStudent(studentRepository.GetAll());
//Exporta la informacion a archivo csv enviando cual quier tipo de objeto
exportHelperGeneric.ExportToCSV(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");