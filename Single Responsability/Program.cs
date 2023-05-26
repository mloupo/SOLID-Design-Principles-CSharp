using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelperCsv exportHelperCsv = new();
exportHelperCsv.ExportStudents(studentRepository.GetAll());
studentRepository.GetAll();
Console.WriteLine("Proceso Completado");