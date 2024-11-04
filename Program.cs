using System.Diagnostics;
using NAudio.Wave;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Drawing;
using System;
using System.IO;
using System.Threading;
using System.Security.Cryptography;

static void cargando()
{
string cargarndo = @"   
   █████████                                                        █████         
  ███░░░░░███                                                      ░░███          
 ███     ░░░   ██████   ████████   ███████  ██████   ████████    ███████   ██████ 
░███          ░░░░░███ ░░███░░███ ███░░███ ░░░░░███ ░░███░░███  ███░░███  ███░░███
░███           ███████  ░███ ░░░ ░███ ░███  ███████  ░███ ░███ ░███ ░███ ░███ ░███
░░███     ███ ███░░███  ░███     ░███ ░███ ███░░███  ░███ ░███ ░███ ░███ ░███ ░███
 ░░█████████ ░░████████ █████    ░░███████░░████████ ████ █████░░████████░░██████ 
  ░░░░░░░░░   ░░░░░░░░ ░░░░░      ░░░░░███ ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░░░  ░░░░░░  
                                  ███ ░███                                        
                                 ░░██████                                         
                                  ░░░░░░                                          ";
string cargando1 = @"   
   █████████                                                        █████            
  ███░░░░░███                                                      ░░███             
 ███     ░░░   ██████   ████████   ███████  ██████   ████████    ███████   ██████    
░███          ░░░░░███ ░░███░░███ ███░░███ ░░░░░███ ░░███░░███  ███░░███  ███░░███   
░███           ███████  ░███ ░░░ ░███ ░███  ███████  ░███ ░███ ░███ ░███ ░███ ░███   
░░███     ███ ███░░███  ░███     ░███ ░███ ███░░███  ░███ ░███ ░███ ░███ ░███ ░███   
 ░░█████████ ░░████████ █████    ░░███████░░████████ ████ █████░░████████░░██████  ██
  ░░░░░░░░░   ░░░░░░░░ ░░░░░      ░░░░░███ ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░░░  ░░░░░░  ░░ 
                                  ███ ░███                                           
                                 ░░██████                                            
                                  ░░░░░░                                             ";
string cargando2 = @"   
   █████████                                                        █████               
  ███░░░░░███                                                      ░░███                
 ███     ░░░   ██████   ████████   ███████  ██████   ████████    ███████   ██████       
░███          ░░░░░███ ░░███░░███ ███░░███ ░░░░░███ ░░███░░███  ███░░███  ███░░███      
░███           ███████  ░███ ░░░ ░███ ░███  ███████  ░███ ░███ ░███ ░███ ░███ ░███      
░░███     ███ ███░░███  ░███     ░███ ░███ ███░░███  ░███ ░███ ░███ ░███ ░███ ░███      
 ░░█████████ ░░████████ █████    ░░███████░░████████ ████ █████░░████████░░██████  ██ ██
  ░░░░░░░░░   ░░░░░░░░ ░░░░░      ░░░░░███ ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░░░  ░░░░░░  ░░ ░░ 
                                  ███ ░███                                              
                                 ░░██████                                               
                                  ░░░░░░                                                ";
string cargando3 = @"   
   █████████                                                        █████                  
  ███░░░░░███                                                      ░░███                   
 ███     ░░░   ██████   ████████   ███████  ██████   ████████    ███████   ██████          
░███          ░░░░░███ ░░███░░███ ███░░███ ░░░░░███ ░░███░░███  ███░░███  ███░░███         
░███           ███████  ░███ ░░░ ░███ ░███  ███████  ░███ ░███ ░███ ░███ ░███ ░███         
░░███     ███ ███░░███  ░███     ░███ ░███ ███░░███  ░███ ░███ ░███ ░███ ░███ ░███         
 ░░█████████ ░░████████ █████    ░░███████░░████████ ████ █████░░████████░░██████  ██ ██ ██
  ░░░░░░░░░   ░░░░░░░░ ░░░░░      ░░░░░███ ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░░░  ░░░░░░  ░░ ░░ ░░ 
                                  ███ ░███                                                 
                                 ░░██████                                                  
                                  ░░░░░░                                                   ";
    

    for (int i = 0; i < 13; i++)
{
        Console.Clear();
        System.Console.WriteLine(cargarndo);
        Thread.Sleep(188);
        Console.Clear();
        System.Console.WriteLine(cargando1);
        Thread.Sleep(188);
        Console.Clear();
        System.Console.WriteLine(cargando2);
        Thread.Sleep(188);
        Console.Clear();
        System.Console.WriteLine(cargando3);
        Thread.Sleep(188);
        Console.Clear();
}
}
static void MostrarAnimacion(string texto)
    {
        Random random = new Random();
        int longitud = texto.Length;

      
        for (int i = 0; i < longitud; i++)
        {
            Console.Write((char)random.Next(33, 126));
        }
        Console.SetCursorPosition(0, Console.CursorTop); 

       
        for (int i = 0; i < longitud; i++)
        {
            Stopwatch retardo = new Stopwatch();
            retardo.Start();
            Console.SetCursorPosition(i, Console.CursorTop);
            Console.Write(texto[i]);
            while (retardo.Elapsed.TotalMilliseconds < 0.1)
            {}
        using (var audioFile = new AudioFileReader(@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\windows-98-click.wav"))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            audioFile.Volume = 1.0f;

            while (outputDevice.PlaybackState == PlaybackState.Playing)
            { }
            retardo.Restart();

        }



        
    }
    }

static void SeleccionarEstudiantes()
{
    
    string estudiantes = @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Datos\estudiantes.txt";
    string registro = @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Datos\registro.txt";
    string verificar = @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Datos\verificacion.txt";

    string[] estudiantesregistro = File.ReadAllLines(verificar)
                                  .Select(line => line.Trim().ToLower())
                                  .ToArray();

string[] estudiantes2 = File.ReadAllLines(estudiantes)
                            .Select(line => line.Trim().ToLower())
                            .ToArray();

var estudiantesdisponibles = estudiantes2.Except(estudiantesregistro).ToArray();


    if (estudiantesdisponibles.Length < 2)
    {
        System.Console.WriteLine("No hay suficientes estudiantes para seleccionar.");
        return;
    }

    DateTime ahora = DateTime.Now;
    Random random = new Random();

    int indice1 = random.Next(estudiantesdisponibles.Length);
    int indice2;
    do
    {
        indice2 = random.Next(estudiantesdisponibles.Length);
    } while (indice1 == indice2);

    string estudiante1 = estudiantesdisponibles[indice1].Trim();
    string estudiante2 = estudiantesdisponibles[indice2].Trim();
    for (int i = 0; i < 15; i++)
    {
        Stopwatch animacion = new Stopwatch();
        animacion.Start();
        int animacion1;
        int animacion2;
        animacion1 = random.Next(estudiantesdisponibles.Length);
        animacion2 = random.Next(estudiantesdisponibles.Length);
        Console.ResetColor();
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine($" ❱❱ Desarrollador en vivo: {estudiantesdisponibles[animacion1]} ❰❰ ");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine($" ❱❱ Facilitador del ejercicio: {estudiantesdisponibles[animacion2]} ❰❰ ");
        Console.ResetColor();
        while (animacion.Elapsed.TotalMilliseconds < 1)
        { }
        animacion.Restart();
        using (var audioFile = new AudioFileReader(@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\8-bit-jump_130bpm_C_minor.wav"))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            audioFile.Volume = 1.0f;

            while (outputDevice.PlaybackState == PlaybackState.Playing)
            { }
        }

    }
    
    using (StreamWriter sw = new StreamWriter(verificar, true))
{
    sw.WriteLine(estudiante1);
    sw.WriteLine(estudiante2);
}

    Console.Clear();
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.Black;
    System.Console.WriteLine("═══════════════════════════════════════════════");
    System.Console.WriteLine($"❱❱ Desarrollador del en vivo: ");
    string estu1 = estudiante1;
    MostrarAnimacion($"{estu1} ");
    System.Console.WriteLine();
    System.Console.WriteLine("═══════════════════════════════════════════════");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    System.Console.WriteLine("═══════════════════════════════════════════════");
    System.Console.WriteLine($" ❱❱ Facilitador del ejercicio: ");
    string estu2 = estudiante2;
    MostrarAnimacion($"{estu2} ");  
    System.Console.WriteLine();  
    System.Console.WriteLine("═══════════════════════════════════════════════");
    Console.ResetColor();
    if (estudiante1 == "michael martinez"){
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine(@"
⣿⣿⣿⣿⣿⣿⣿⣿⡿⡫⣁⡴⣈⡼⣟⣭⣷⣿⡿⠿⡽⡟⠍⡙⢕⣢⣿⡟⣱⣿⣿⣿⣿⣿⠟⠋⡕⢼⣣⣴⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⢿⣩⣾⣿⡿⣿⣿⢿⣿⣿⣿⣿⡿⠛⣙⢄⣽⣿⣿⣿⡃⢹⣿⣿⣾⢫⢿⢇⣿⡟⣼⣿⡇⠯⠈⠰⣶⣾⣶⡄⢻⣿⣿⢎⣮⡹⠗⣠⣵⣶⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⡿⡫⣪⡾⣫⣾⣯⠾⠛⣋⣥⣶⡿⠟⣩⢔⣼⣾⣿⣿⠏⣼⣿⣿⢟⣿⡟⣡⢊⣼⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⣿⡿⣫⣷⣿⣿⣿⣫⢏⡼⣫⣾⣿⣿⣿⣃⢔⠟⣱⣿⣿⡿⣛⣿⣿⣿⣿⣿⣿⣏⡾⣼⡿⣸⣿⣿⠃⣴⠠⢹⣸⡿⣿⣇⡱⡊⣿⣎⣎⢷⡘⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⠟⢞⣾⡟⠾⠿⢋⢥⣺⣯⣷⡿⢋⣴⣯⣾⡿⢟⢛⣻⠏⣼⣿⣿⠏⣾⣿⠟⣵⣿⣿⣿⣿⡿⠿⠟⠛⣛⣉⣥⣴⣶⡿⢟⣿⣿⣿⣿⡟⠑⣡⠯⣺⣿⣿⣿⣿⡿⢋⣴⣾⠿⠟⣫⣾⣿⣿⡟⣼⣿⣿⣿⡙⣽⡟⣵⣿⣿⣥⣦⡏⡇⠈⡏⣷⡹⣿⣦⠑⡜⣿⣯⢫⢭⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⡟⣠⠟⣩⣴⡾⣥⣼⠿⣫⣥⢈⣶⠶⢛⢍⡒⣡⡶⣼⠏⣰⣿⣿⢋⠶⢿⢥⣾⣮⣭⣿⢤⣤⡶⡾⣻⣿⠟⣨⣿⡿⢋⣴⣿⡿⣛⡟⡁⣴⡞⣡⣾⣿⢟⣭⣿⡿⠱⠟⡡⡊⣠⣾⣿⡿⣫⣟⣼⣿⢫⢯⣿⢸⣿⣾⣿⣿⣿⣿⢼⣷⣿⠀⣷⢿⢸⣜⢿⣷⡘⣞⢿⣷⡵⡣⠘⢿⣿⣿⣿⣿⣿⣿⣿⠿⢟⡛⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⡇⡉⣼⣿⡿⣼⡟⢡⣾⡿⢃⢈⡴⠚⠑⣋⣾⢟⠊⡄⢠⣿⡿⢃⡴⡵⣳⣿⢟⣵⡿⣵⡿⠿⠹⣼⣿⠏⣼⡿⢋⣴⣿⡿⣫⣪⢞⣡⠟⣢⣾⣿⠟⣵⡿⠛⣩⠞⣡⠪⢞⣾⣿⠟⢡⢞⠉⢊⣿⠇⡜⣸⡇⢠⣿⣿⣿⢿⣿⡟⣾⢹⣿⢈⣿⢸⠰⢻⡄⣻⣿⣎⢈⠻⣿⣞⢆⢸⣿⡿⢿⣻⣭⣷⣾⣿⣿⣿⣿⣶⣬⡛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣷⣦⣿⣿⢱⡟⣴⣿⠟⢑⣫⣷⠖⣡⣾⡿⡵⢁⡞⢻⣾⡟⢁⣞⣞⡽⣟⣵⡿⣫⠿⢋⡴⢰⣱⣿⠇⣼⠏⣠⣾⣿⢯⣾⢞⢵⣫⣷⢾⡯⠫⢠⡞⣡⢮⠞⣱⠞⣡⣢⣿⡿⠑⡠⣵⢇⣆⣾⡏⣼⠃⣿⠀⣽⡏⣿⡏⣼⣿⢳⡏⢨⡏⢘⣿⡔⢈⣸⣿⠱⡹⣿⢸⣰⡌⢛⣣⣬⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣬⡻⢿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣮⠀⠩⢁⣴⣿⢟⣵⣾⡟⠩⠊⢒⢽⣾⣧⣻⡌⣾⢉⣬⠞⠏⠩⢚⣡⣾⠿⡃⡎⣿⠏⡼⢃⣼⣿⡟⢕⠕⣡⣴⢿⡫⠟⣙⣤⣶⠟⢌⡵⢋⡜⣡⡾⣵⣿⠟⢀⣤⡾⣱⡟⢌⡞⣰⡇⣠⡟⡠⣿⡇⣿⡇⣾⣿⡾⢀⣾⡟⣸⣿⣧⢸⣧⣿⢹⠁⣟⣬⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣙⢿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⢿⣢⣤⣿⢟⡵⠟⣁⣨⢁⣾⡌⣿⠂⢻⣿⡧⣁⠵⣋⡴⢊⡔⠈⠼⡿⣫⣾⠀⣹⣿⣿⢡⡾⣿⣋⣤⣧⠿⠫⢓⡩⣴⣾⡿⣫⠉⢠⣞⡷⢪⣤⣟⣽⣿⠏⣴⣿⢏⣾⡿⠘⡞⢱⡿⣠⣿⠇⡆⣿⡇⣿⢇⣿⣿⠁⣾⣿⢳⣿⠿⢇⣦⠻⣉⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣙⢿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣶⣿⣿⠏⠕⣩⣴⣿⡿⣣⡿⡳⣣⢹⠀⣃⠅⡨⠠⠞⢱⡞⣼⠛⣆⣧⣝⢛⡻⠤⢯⣟⣃⣲⣯⣿⠿⢛⢡⣶⣾⠛⣴⡿⣫⣾⠃⣰⣯⡟⣱⣯⣏⣼⣿⢃⣾⣿⢣⣿⢏⠄⡼⢡⣿⠇⣼⡿⢠⡏⣿⡇⣿⠈⣿⠇⣾⣿⢧⣿⠃⢀⣾⡟⡰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡙⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⡱⠇⣼⣿⣿⢟⡼⠋⣠⠞⠋⠀⠈⣤⣤⢷⢸⡟⣨⡇⠁⣇⢸⣿⣿⣷⣮⢁⠔⡭⠋⠉⡠⣊⡞⣳⣿⣿⣫⣼⢟⣾⣿⠁⡴⣳⢏⣾⣿⣟⡾⢻⣯⣿⣿⡡⢭⢏⡟⢰⢁⡟⡘⢰⣿⡅⣐⡚⣿⡇⣿⢂⡟⣼⣿⢏⣸⠇⣨⣼⡟⡌⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣈⢻⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠗⠝⡫⠞⣩⡔⣂⣮⢠⣶⡇⡐⡰⣶⠊⢸⠇⣿⡧⡗⣼⢾⣬⣭⡝⡡⡣⠚⠔⠀⢘⣼⣿⢳⣿⣿⣷⣿⣵⣿⣿⠃⣼⣵⢯⣿⣿⡟⣜⢡⡟⢹⣿⢱⣿⣿⣾⠃⢢⡟⣠⢇⣿⣿⡇⡯⠇⣽⡇⣿⢸⡽⣻⢟⠘⠈⣰⣿⡟⢸⢷⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⢹⣿⡏⢹⣿⡟⠁⠈⣿⡿⠁⣿⣿⠁⣹⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⢹
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣥⣀⣥⣴⣾⣳⣾⢟⣵⢯⠞⡠⢳⢷⡭⢰⡏⡇⡏⡇⡅⢻⣿⡿⢋⠈⡀⣰⡷⠀⣠⣈⡹⢛⡿⠿⣿⣿⣿⣿⣿⡿⠰⣳⢫⣿⣿⣿⠹⣁⡾⢡⢸⢣⣿⣿⣿⠿⠐⢋⠚⡈⣬⣭⣴⣶⣞⡇⣿⡇⣿⣸⣱⠟⣎⡇⣸⣿⡟⣼⡟⡾⢸⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠈⡿⢀⡾⠋⣠⠆⠀⣿⠁⠈⠉⠁⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⢸
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣫⣴⠿⠕⣡⢮⡾⡘⣦⣿⡸⡇⠀⡅⢡⢥⢐⡋⢦⣶⡿⢯⣽⢧⢡⣿⣺⣟⣶⣾⣥⣜⣢⠫⣉⠿⣿⣾⢏⣿⣿⣿⣿⢰⠻⢣⣿⢈⡬⠝⣀⣲⣤⣴⣟⢞⣽⣿⣿⣿⡿⣿⡿⢸⡗⣿⠉⢣⡇⣿⢠⣿⣿⡹⠟⣼⢷⢸⣿⣿⣿⣿⣿⣿⣿⡿⠀⣶⠀⠀⡼⠁⣀⣠⡄⠠⠇⢠⣾⡟⢀⣾⡿⠋⣹⣿⣿⣿⣿⣿⣿⣿⡟⢸
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣋⣡⣘⣣⣴⡾⣽⣳⢏⡼⠁⠙⣿⡇⢿⠀⠻⡾⣸⣿⣿⡐⠢⠩⠀⠐⠀⠭⢒⣚⠯⢭⣛⡿⣿⣿⣷⣶⢤⡹⡟⣼⣿⣿⣿⣿⣮⣴⡿⠿⣄⣶⣾⣿⣿⡿⢟⣫⠭⠿⠒⠢⠤⠔⠀⠀⠘⣧⣿⠌⣿⠃⡟⣼⣿⣿⣇⠆⡿⣼⢸⣿⣿⣿⣿⣿⣿⣿⣧⣼⣿⣧⣼⣧⣼⣿⣿⣦⣴⣤⣿⣿⣦⣼⡟⣡⣾⣿⣿⣿⣿⣿⣿⣿⣿⡇⣼
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⣿⣿⡿⣽⠃⢡⣾⠁⢞⣧⢹⡇⢸⡇⢧⢷⡉⣿⣿⣿⡃⠜⣿⣿⡇⢻⣷⡂⢸⣤⣈⠙⠂⣿⣿⣿⣧⢠⢸⣿⣿⣿⣿⣿⣿⡟⠁⣹⣿⣿⣿⣿⡿⠐⢋⠁⣤⣖⣘⣻⠇⣼⣿⣿⠃⣹⡏⠸⢃⡏⠀⣻⣿⣿⣟⡀⣇⡏⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠛⢿⠛⢻⡿⠟⠛⠛⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠗⢋⣴⣿⡏⠀⣾⡿⠀⠇⣾⡉⣘⣿⣧⡸⣿⣿⣧⡡⢻⣿⣿⣦⣘⠿⢽⣛⣽⣷⡀⠸⣿⣿⣿⣃⡀⣿⣿⣿⣿⣿⣿⡟⣧⣹⣿⣿⣿⣿⠃⢰⣿⣷⣝⡻⢛⣋⣴⣿⣿⢏⣇⢻⡌⠈⡸⢽⠐⣿⣿⡟⣼⣱⡿⣠⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡄⢠⣶⠀⣴⣿⠀⣠⣶⣶⠂⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣿⣿⣿⠀⢰⣿⠃⡜⠀⢻⡇⢸⣿⣿⣷⣽⣿⣿⣿⣣⡻⢿⣿⣿⣿⣿⣿⣿⡿⢠⣐⢉⢉⡿⢉⣴⣿⣿⣿⣿⣿⣿⣿⣾⣿⡿⠻⢿⡏⢠⣌⢿⣿⣿⣿⣿⣿⣿⡿⣫⣜⣿⢳⢠⢹⡇⣸⣷⣾⢛⡇⢿⡟⣱⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢀⣾⣿⣿⣿⡏⢠⠿⠛⢁⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢠⡜⣣⣾⢁⣃⢹⣿⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣾⣿⣥⣴⣿⣳⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣬⠡⠛⢿⣾⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⠈⡇⢾⣷⣿⣿⡿⢸⣿⡞⡀⣾⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠉⢁⣀⣠⣽⣿⣿⣀⣀⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣻⣵⣾⣿⢇⢈⡜⣅⠹⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢏⣸⣧⢻⣿⣿⣿⡇⣿⡟⡀⡆⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⢊⣬⣾⣿⣷⣤⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣾⣿⣿⣾⣿⣿⡿⠸⠟⠠⢠⢣⢿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⢹⡟⠈⢹⣿⠃⣸⠏⢸⡏⠈⣿⡿⠁⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⡆⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣴⠀⡏⣸⡇⠎⢿⡛⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⡟⢁⠀⠸⠃⣰⡟⢀⡿⠀⡀⠘⠃⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⣽
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣸⣿⠀⠀⣿⣿⢰⣾⡇⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⢠⣾⡀⠀⣴⡿⠁⣾⠁⣼⣷⠀⢠⣿⠛⢙⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⢠⣿⡏⠠⣸⣿⣷⣿⣿⢃⣨⣿⣿⣿⣿⣿⣿⣿⣷⣶⣿⣿⣷⣾⣿⣷⣼⣿⣶⣿⣿⣷⣾⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⡿⣡⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⣾⣿⢁⣵⣿⣿⣿⣿⣿⣆⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣱⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣬⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣴⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠈⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣴⡙⢿⣿⡿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣽⡻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⣼⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⢂⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣡⠀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣯⣝⡻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠟⠋⢁⣾⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⢱⡌⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣡⣾⠃⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⣛⣿⣿⣿⣿⣿⣷⣶⣬⡁⣨⠿⣛⣛⣛⣻⣿⣿⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠐⠌⣿⣆⠹⣿⣿⣿⣿⣿⣏⣙⣻⠿⠿⢿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⢿⣟⣋⣤⣾⣿⣿⣿⡿⢣⣾⣿⢏⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⡴⣩⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⡳⢹⣿⣷⡈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣗⢦⡀⠀⠤⣤⣤⣤⣤⣤⣤⣄⠤⠖⡀⢴⣶⣿⣿⣿⣿⣿⣿⣿⡿⢋⣴⣿⡿⠋⣀⠀⣺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣨⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢰⣌⠊⣿⣿⣿⣆⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣮⣙⠛⠛⠒⠒⠒⠒⠒⡖⢒⣩⣼⣿⣿⣿⣿⣿⣿⣿⡿⢋⣴⣿⣿⣿⠍⣐⡇⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣷⣿⣿⣿⣿⣷⡌⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢋⣴⣿⣿⣿⣿⡏⢀⡳⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣖⢀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣱⣿⣿⣿⣿⣿⣿⡯⢅⡾⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠃⠘⣿⡷⣝⢿⣿⣿⣿⣿⡧⠢⡀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⣰⣿⣿⣿⣿⣿⣿⣭⣾⣿⡇⡆⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠀⠀⠀⠀⣿⣿⣮⡳⡍⠿⣿⣿⣿⣌⠺⢔⣌⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⢂⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⡌⠲⣜⢿⣿⣿⣿⡄⢠⣹⣷⣆⣉⠛⠿⠿⠿⠿⢿⠿⡿⠿⠿⠟⠋⣀⠤⡢⢼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠉⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣷⡐⢔⢌⢿⣿⣿⣿⣄⠐⢿⣿⣿⣿⣿⣷⣶⣶⣦⣦⣴⣤⣦⡔⠲⢌⡱⣴⣿⣿⣿⠟⢋⣩⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠈⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣷⢠⠓⢮⣻⣿⣿⣿⣎⢈⠽⣛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠣⠕⢲⣿⣿⣿⣿⢏⣰⣾⠿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣇⢙⢴⢙⣿⣿⣿⣿⣷⡱⣦⣪⠬⣽⣛⡿⡟⣻⣿⣿⣣⣌⣴⣿⣿⣿⡿⢁⡴⢚⣋⠸⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⡿⠿⠛⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⢝⢆⢻⣿⣿⣿⣿⣧⢩⣫⠭⢟⣻⢒⣼⣿⣿⣯⢅⣾⣿⣿⡿⢋⡀⢦⣼⠯⣭⣶⣾⡿⠟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⠿⠟⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠘⠿⢿⣿⣿⣿⣄⣺⢭⣻⡆⢾⣿⣿⣿⡄⣿⣿⣿⡟⠁⠀⢴⡟⣮⡿⠼⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
    Console.ResetColor();
    }
    if (estudiante2 == "michael martinez")
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine(@"
  ⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢸⢸⢸⢸⡇⢀⢀⢀⢀⢀⢀⢧⣤⣤⣤⣤⣤⣤⣤⣤⡄
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢸⢸⢸⢺⡇⢀⢀⢀⢀⢀⢀⢸⢀⡦⠤⠤⠤⠤⠤⠤⠄
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢸⢸⢾⢸⡇⢀⢀⢀⢀⢀⢀⢸⢀⡇
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣼⢀⢀⢀⢀⣴⠞⢀⢀⢀⣤⣶⣶⣶⠖⢀⢀⢠⡇⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⠸⢀⢸⢾⠸⢸⡇⢀⢀⢀⢀⢀⢀⢸⢀⡇
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣸⡏⡰⠁⢠⣿⡏⢀⡆⣴⣿⣿⣿⠏⠁⢀⢀⣠⣿⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢀⢠⢾⢸⢀⢸⡇⢀⢀⢀⢀⢀⢀⢸⢀⡇
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⡔⣿⡇⡇⢀⣿⣿⠃⢀⣿⣿⣿⢿⠃⣠⡶⠊⣍⣾⡇⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢠⡇⢸⢸⢀⢸⡇⢀⢀⢀⢀⢀⢀⢸⢀⠃
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢰⢀⢀⢀⢸⣇⢀⢀⢀⢸⢃⣿⡇⡇⣼⣿⣿⢀⣸⣿⣿⣏⢇⣾⠏⢀⣼⣿⣿⠁⢀⢀⣀⣀⣤⣤⣤⣄⣀⢀⢀⢀⢀⢸⠂⢀⢸⢸⢀⢸⡇⢀⢀⢀⢀⢀⢀⢸
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⡄⢀⢀⠘⣿⡄⢀⢀⠈⢸⣿⣧⢠⣿⣿⣿⡀⣿⣿⣿⢘⣾⣏⣴⣿⣿⣿⢿⣠⣴⣿⣿⣿⣿⣿⢿⡟⠉⠉⠁⢀⢀⢸⢀⢀⢸⢸⢀⢸⡇⢀⢀⢀⢀⢀⢀⢸
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡀⢀⢿⣦⢀⢀⢻⣿⣆⠉⠢⣼⣿⣿⣸⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣟⣼⣿⣿⣿⣿⡟⢋⣴⠏⢀⢀⢀⢀⢀⢀⢸⢀⢀⢸⠘⢀⢸⡇⢀⢀⢀⢀⢀⢀⢸
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠘⢄⠈⢿⣿⣶⣬⣿⣿⣷⣦⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢋⣴⡿⢵⣲⣶⣦⣤⣄⣀⢀⢸⢀⢀⢸⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⣤⣤⣤⣠⣀⣀⣀⣀⡀
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣀⣀⣌⣐⣛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⠟⢛⠉⠁⢸⢀⢀⢸⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⡧⣂⣀⣠⣤⣀⣀⣀⣀⡀
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣤⡾⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⡟⢸⣿⣿⣿⣿⣿⣿⣿⣟⣽⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⡉⠔⠊⢀⢀⡀⢸⢀⢀⢸⠐⢀⢸⢀⢀⢀⢀⢀⢀⢀⠋⠉⠉⠉⠉⠉⠉⠉⠉⠁
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠔⠁⢀⢀⣤⠶⣚⣻⣿⣿⣿⣿⣿⣿⣿⡽⣿⣿⣿⣟⣼⣿⣇⢸⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣷⣶⣶⣶⡿⡛⢀⢸⢀⠐⢸⢀⢀⠸
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣎⣵⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡻⣜⣿⣿⣿⣿⣿⣿⣾⣿⡟⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢛⣉⣀⣐⡠⢸⢀⢀⢸
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣠⣾⡿⠿⣛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣝⢿⣿⣿⣿⣿⣿⣿⣿⣧⣿⣿⣿⣿⣿⡿⣛⣽⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⢀⢸⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡄
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣾⠛⢁⡴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡫⣺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣍⣓⣤⣀⣀⣀⢸⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡇
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡾⢡⠞⠕⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣽⣾⣿⡿⢟⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠟⣃⣸⢀⢀⢸⢀⢀⣠⡄⢀⢀⢀⢀⢀⢀⢳⠶⠶⠶⠶⠶⠶⠶⠶⠆
⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠈⢀⣬⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣛⠿⠿⠿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡛⠛⠉⢹⢀⢀⣸⢴⠚⢀⡇⢀⢀⢀⢀⢀⢀⢸⢀⠛⠛⠛⠛⠛⠛⠛⠃
⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⠶⢶⡶⠶⠾⢿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣼⣤⣮⣽⠤⠤⣤⣥⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⡄
⠶⠶⡶⣶⠤⠤⠤⠤⠤⢤⢤⡤⠤⠤⠤⠤⠤⣤⣤⠾⢵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢻⠿⠟⠛⠛⠉⠓⠽⠟⠛⠛⢛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣯⣭⣭⣥⣤⠤⣤⣤⣤⣤⣤⣤⣤⢤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⡄
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢻⢸⢀⣿⠟⣍⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠉⢀⢀⠈⠉⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠰⠾⣿⣿⣿⣿⣿⣿⣿⣿⣷⣬⣣⣸⢸⢀⣿⢀⢀⢀⡇⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢸⠃⢰⣾⣿⣿⣿⣿⣿⣿⣿⣿⡛⠁⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠨⣿⣿⣿⣿⣿⣿⣷⡜⠉⠉⢸⢸⢀⣿⢀⢀⢀⡇⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⣴⡿⢿⣿⣿⣿⣿⣿⣿⣿⠅⢀⢀⢀⢀⢀⢀⢀⢀⢀⢰⢀⢀⡆⢀⢱⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢺⣿⣿⡿⠉⠻⠟⠼⢀⢀⢸⢸⢀⣿⢀⢀⢀⡇⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⠉⢠⢡⣿⣿⣿⣿⣿⣿⣿⠏⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢸⢀⢀⣷⢀⢈⣧⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⡀⠈⢿⣿⡇⡸⢢⢀⢀⢀⢀⢸⢸⢀⢸⢀⢀⢀⡇⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇⠘
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⠈⣿⣿⣿⡿⠿⣿⣿⡏⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠛⢦⡀⠉⢠⠞⠁⢀⢀⢀⢀⢀⢀⣀⠤⠒⠋⠁⢀⢀⠘⣿⢠⢹⠸⡀⢀⢀⢀⢸⢸⢀⢸⢀⢀⡇⠁⢀⡇⢸⢀⢀⢀⢸⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⠘⠛⠉⠙⣾⡄⠹⣿⢀⢀⢀⢀⠤⠤⢄⣀⡀⢀⢀⢀⢀⢀⠡⢀⠈⢀⢀⢀⢀⣠⡴⠚⠉⢀⢀⢀⢀⢀⢀⢀⢀⡟⢸⠄⡇⡇⢀⢀⢀⢸⢸⢀⢸⣀⡀⣇⡄⢀⡇⢸⢀⢀⢀⢸⢸⠄⡇⠠⠤⠤⠤⠤⠄
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢹⢙⠄⠹⡀⢀⢀⢀⢀⢀⢀⢀⠈⠉⠓⠲⢦⡀⢀⢀⢀⢀⢀⢠⠚⠁⢀⡀⠤⢐⣒⣠⣤⠔⢀⢀⢀⡇⠸⡆⢸⠁⢀⢀⢀⢸⢸⢀⣼⢀⢀⡇⠁⢀⡇⢸⢀⢀⢀⡯⢀⢀⡇⠈
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⠈⣎⡜⠄⠃⢀⢀⢀⢀⢀⢀⠤⠤⠤⠤⠤⢀⠉⢀⢀⢀⢀⢀⢀⢀⢀⣶⠶⢿⠟⡍⢀⣄⢀⠴⡀⢀⣀⣏⡇⡸⢀⢀⢀⢀⢸⢸⢀⢻⢀⢀⡇⢀⢀⡇⢸⢀⢀⢀⣿⠁⠐⡇⢀⠉⠉⠉⠉⠁
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⣧⢪⢼⠟⡀⢀⢀⠈⢉⣝⠛⢛⣿⡛⠻⣷⡀⠸⢀⢀⢀⢀⢀⢀⠴⠿⠤⠤⠤⠒⠊⠡⢊⡔⠁⢀⡏⡏⢠⠃⢀⢀⢀⢀⢸⢸⢀⣸⢀⢀⡇⡄⢀⡇⢸⢀⢀⢀⣿⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⡇⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡏⣇⠏⡢⢡⢀⢀⠘⠤⡉⠳⠦⠄⠒⠒⡹⠓⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣼⣦⢀⡆⡇⢀⡇⡄⢀⢀⢀⢀⠘⢸⢀⢹⢀⢀⡇⡇⢀⡇⢸⢀⢀⢀⣿⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⠇⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡇⡏⠣⡑⢆⠆⢀⠱⡄⠈⠒⢀⢀⢀⢀⢀⢀⣀⣤⣤⣤⣤⣤⡴⠶⠆⢀⢀⢀⢀⡠⠊⢀⠴⢚⢂⣇⣦⣇⡇⢀⢀⢀⢀⢀⢸⢀⢸⢀⢀⡇⡇⢀⡇⢸⢀⢀⢀⣿⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡇⡇⢀⠙⢌⠘⡐⢄⠛⠳⣄⢀⢀⢀⢀⠉⠙⠛⠿⠿⠿⠟⠁⢀⢀⢀⢀⢀⢀⢀⢀⠔⠁⢀⠸⢸⣿⣿⣿⣿⣦⡀⢀⢀⢸⢸⢀⢸⡀⢀⡇⠃⢀⡇⢸⢀⢀⢀⣿⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡇⡇⢀⢀⠈⣷⣧⠰⡗⠢⡀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠇⣼⣿⣿⣿⣿⣿⣿⣦⣄⢸⢸⢀⢸⢀⠉⡗⢀⢀⡇⢸⢀⢀⢀⠿⢀⢀⡇⢠
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡇⡇⢀⣠⣾⣿⣿⣇⢣⢀⠈⢀⢀⢀⢀⢀⢀⢀⡀⢀⢀⢀⢀⡀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠸⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣼⢀⠸⢀⢀⡇⢀⢀⡇⢸⢀⢀⢀⢀⠈⠂⡇⠐⠒⠒⠒⠒⠂
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢀⡇⣧⣾⣿⣿⣿⣿⣿⡆⢃⢀⢀⢀⢀⢀⢀⢀⢀⠈⠳⡄⢀⠃⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⠆⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣆⢀⢀⡇⢀⢀⡇⢸⢀⢀⢀⢀⢰⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣌⢢⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⢀⣀⣀⠴⠃⢀⣠⠊⣔⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⠈⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡑⣄⢀⢀⣤⣀⣀⣀⡤⠤⠔⠒⠒⢒⡉⠁⢀⢀⢀⠔⢁⡼⣱⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣛⢮⡢⣀⢀⢀⢀⠒⠒⠒⠊⠉⠉⠁⢀⢀⢀⠔⠁⢀⢞⢋⣺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢀⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⠆⠽⣎⠑⠦⣄⢀⢀⢀⢀⢀⢀⢀⢀⡔⠁⢀⣠⣯⣵⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⢀⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣾⣦⣬⣿⣦⣤⣿⣿⣾⣷⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⢀⢀⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⢀⢀⡇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡱⢎⡭⢤⣿⣿⣿⣿⣿⣿⣿⣿⣷⢀⢀⢀⢀⢀⢀⡇⢸⢀⢀⢀⢀⢀⢀⠇
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⢷⣚⣇⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⢀⢀⢀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢀⢀⢀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⢀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⢀⢀⢀⡇⢸
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⢀⡇⢸⢀⢀⢀⢀⢀⢀⡀
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢸⢸⢀⢀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡇⢸⢀⢀⢀⢀⢀⢀⠁
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢀⢸⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣼
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⢀⢀⣸⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄
⢀⢀⡇⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⢀⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄
⢀⢀⠁⢸⢀⢀⢀⢀⢀⢸⢀⢀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄
⢀⢀⢀⢸⢀⢀⢀⢀⢀⢸⢀⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄
⢀⢀⢀⠘⢀⢀⢀⢀⢀⠘⠚⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠂");
    Console.ResetColor();
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Presione dos veces enter para continuar seleccionado, vaya a salir para finalizar");
    Console.ReadKey();

    string verificar3 = $"{estudiante1} {estudiante2}{Environment.NewLine}";
    File.AppendAllText(verificar, verificar3);

    string registro2 = $"Desarrollador en vivo: {estudiante1}, Facilitador del ejercicio: {estudiante2}, Fecha: {ahora}{Environment.NewLine}";
    File.AppendAllText(registro, registro2);
}



static void printslow(string texto)
{
    Random random = new Random();
    Stopwatch lento = new Stopwatch();
    lento.Start();
    using (var waveOut = new WaveOutEvent())
    using (var audioFile = new AudioFileReader(@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Letras sound\sans voice.wav"))
    {
        waveOut.Init(audioFile);
        waveOut.Play();
        foreach (char caracter in texto)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            System.Console.Write(caracter);
            while (lento.Elapsed.TotalMilliseconds < 0.6)
            { }
            lento.Restart();
        }
    }
}

static void printslow1(string texto)
{

    Stopwatch lento = new Stopwatch();
    lento.Start();
    using (var waveOut = new WaveOutEvent())
    using (var audioFile = new AudioFileReader(@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Letras sound\sans voice.wav"))
    {
        waveOut.Init(audioFile);
        waveOut.Play();
        foreach (char caracter in texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(caracter);
            while (lento.Elapsed.TotalMilliseconds < 1)
            { }
            lento.Restart();
        }
    }
}


string[] musicas = new string[]
{
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\We are! [8 bit cover] - One Piece OP 1.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Pokemon Theme 16-bit.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Sonic The Hedgehog 2 - Aquatic Ruin Zone (8-bit Remix).wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Kirby's Adventure (NES) Music - Green Greens.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Dragon Ball Z intro versión 16-bits.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Jujutsu Kaisen opening 2.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Super Mario Bros. Theme Song.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Dragon Ball Super Opening 2 Limit Break X Survivor Version VideoGame 8-bits.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Death Note Opening 1 - The World 8-bit NES Remix and 16-bit SNES Remix.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\Dan Dan Kokoro Hikareteku [8 bit cover] - Dragon Ball GT Opening.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\nanatsu no taizai opening sprite version 8 bits music.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\DAN DA DAN Opening - Otonoke [8bit cover].wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Muscias\The Legend of Zelda - A Link To The Past - Fairy Fountain.wav",
};

string[] rutasonido = new string[]
{
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\8-bit-jump_130bpm_C_minor.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\8-bit-kit-hi-hat-closed-3_C_minor.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\windows-10-sfx-navigation-start.wav",
    @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\windows-98-click.wav",
};

static void ReproducirSonido(string rutasonido)
{
    using (var audioFile = new AudioFileReader(rutasonido))
    using (var outputDevice = new WaveOutEvent())
    {
        outputDevice.Init(audioFile);
        outputDevice.Play();
        audioFile.Volume = 1.0f;

        while (outputDevice.PlaybackState == PlaybackState.Playing)
        {
        }
    }
}

static void ReproducirMusicaAleatoria(string[] musicas)
{
    Random random = new Random();

    while (true)
    {
        int indiceRandom = random.Next(musicas.Length);
        string musicSelected = musicas[indiceRandom];

        using (var waveOut = new WaveOutEvent())
        using (var audioFile = new AudioFileReader(musicSelected))
        {
            audioFile.Volume = 0.1f;

            waveOut.Init(audioFile);
            waveOut.Play();

            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}

static void ResetearColoresEstudiantes()
{
    string rutaArchivo = @"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Datos\estudiantes.xlsx";

    using (var workbook = new XLWorkbook(rutaArchivo))
    {
        var hoja = workbook.Worksheet(1);

        foreach (var fila in hoja.RowsUsed())
        {
            var celdaNombre = fila.Cell(1);
            celdaNombre.Style.Fill.BackgroundColor = XLColor.NoColor;
        }

        workbook.Save();
    }
}

#pragma warning disable CS4014
Task.Run(() => ReproducirMusicaAleatoria(musicas));
string[] menu1 = {@"
 ███████████              ████            █████             
░░███░░░░░███            ░░███           ░░███              
 ░███    ░███  █████ ████ ░███   ██████  ███████    ██████  
 ░██████████  ░░███ ░███  ░███  ███░░███░░░███░    ░░░░░███ 
 ░███░░░░░███  ░███ ░███  ░███ ░███████   ░███      ███████ 
 ░███    ░███  ░███ ░███  ░███ ░███░░░    ░███ ███ ███░░███ 
 █████   █████ ░░████████ █████░░██████   ░░█████ ░░████████
░░░░░   ░░░░░   ░░░░░░░░ ░░░░░  ░░░░░░     ░░░░░   ░░░░░░░░ ", @"
 ███████████            ████                  
░░███░░░░░███          ░░███                  
 ░███    ░███   ██████  ░███   ██████   █████ 
 ░██████████   ███░░███ ░███  ███░░███ ███░░  
 ░███░░░░░███ ░███ ░███ ░███ ░███████ ░░█████ 
 ░███    ░███ ░███ ░███ ░███ ░███░░░   ░░░░███
 █████   █████░░██████  █████░░██████  ██████ 
░░░░░   ░░░░░  ░░░░░░  ░░░░░  ░░░░░░  ░░░░░░  ", @"
 █████   █████  ███           █████                        ███            ████ 
░░███   ░░███  ░░░           ░░███                        ░░░            ░░███ 
 ░███    ░███  ████   █████  ███████    ██████  ████████  ████   ██████   ░███ 
 ░███████████ ░░███  ███░░  ░░░███░    ███░░███░░███░░███░░███  ░░░░░███  ░███ 
 ░███░░░░░███  ░███ ░░█████   ░███    ░███ ░███ ░███ ░░░  ░███   ███████  ░███ 
 ░███    ░███  ░███  ░░░░███  ░███ ███░███ ░███ ░███      ░███  ███░░███  ░███ 
 █████   █████ █████ ██████   ░░█████ ░░██████  █████     █████░░████████ █████
░░░░░   ░░░░░ ░░░░░ ░░░░░░     ░░░░░   ░░░░░░  ░░░░░     ░░░░░  ░░░░░░░░ ░░░░░ ", @"
  █████████            ████   ███           
 ███░░░░░███          ░░███  ░░░            
░███    ░░░   ██████   ░███  ████  ████████ 
░░█████████  ░░░░░███  ░███ ░░███ ░░███░░███
 ░░░░░░░░███  ███████  ░███  ░███  ░███ ░░░ 
 ███    ░███ ███░░███  ░███  ░███  ░███     
░░█████████ ░░████████ █████ █████ █████    
 ░░░░░░░░░   ░░░░░░░░ ░░░░░ ░░░░░ ░░░░░     "};
int opciones1 = 0;

string inicio = @" 
 ███████████             ████                                                          █████                      ████           
░░███░░░░░███           ░░███                                                         ░░███                      ░░███           
 ░███    ░███ █████ ████ ░███   █████   ██████     █████ ████ ████████    ██████      ███████    ██████   ██████  ░███   ██████  
 ░██████████ ░░███ ░███  ░███  ███░░   ███░░███   ░░███ ░███ ░░███░░███  ░░░░░███    ░░░███░    ███░░███ ███░░███ ░███  ░░░░░███ 
 ░███░░░░░░   ░███ ░███  ░███ ░░█████ ░███████     ░███ ░███  ░███ ░███   ███████      ░███    ░███████ ░███ ░░░  ░███   ███████ 
 ░███         ░███ ░███  ░███  ░░░░███░███░░░      ░███ ░███  ░███ ░███  ███░░███      ░███ ███░███░░░  ░███  ███ ░███  ███░░███ 
 █████        ░░████████ █████ ██████ ░░██████     ░░████████ ████ █████░░████████     ░░█████ ░░██████ ░░██████  █████░░████████
░░░░░          ░░░░░░░░ ░░░░░ ░░░░░░   ░░░░░░       ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░░░       ░░░░░   ░░░░░░   ░░░░░░  ░░░░░  ░░░░░░░░ ";

string titulo = @" 
 _____                                                                                                  _____ 
( ___ )                                                                                                ( ___ )  
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |                                                                                                  |   | 
 |   |             ▄████████  ▄██████▄  ████████▄     ▄████████    ▄████████    ▄████████               |   | 
 |   |            ███    ███ ███    ███ ███   ▀███   ███    ███   ███    ███   ███    ███               |   | 
 |   |            ███    █▀  ███    ███ ███    ███   ███    █▀    ███    ███   ███    █▀                |   | 
 |   |            ███        ███    ███ ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███                      |   | 
 |   |            ███        ███    ███ ███    ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████               |   | 
 |   |            ███    █▄  ███    ███ ███    ███   ███    █▄  ▀███████████          ███               |   | 
 |   |            ███    ███ ███    ███ ███   ▄███   ███    ███   ███    ███    ▄█    ███               |   | 
 |   |            ████████▀   ▀██████▀  ████████▀    ██████████   ███    ███  ▄████████▀                |   | 
 |   |                                                            ███    ███                            |   | 
 |   |     ▄████████    ▄█    █▄     ▄██████▄   ▄█     █▄  ██████████   ▄██████▄   ▄█     █▄  ███▄▄▄▄   |   | 
 |   |    ███    ███   ███    ███   ███    ███ ███     ███ ███   ▀███ ███    ███ ███     ███ ███▀▀▀██▄  |   | 
 |   |    ███    █▀    ███    ███   ███    ███ ███     ███ ███    ███ ███    ███ ███     ███ ███   ███  |   | 
 |   |    ███         ▄███▄▄▄▄███▄▄ ███    ███ ███     ███ ███    ███ ███    ███ ███     ███ ███   ███  |   | 
 |   |  ▀███████████ ▀▀███▀▀▀▀███▀  ███    ███ ███     ███ ███    ███ ███    ███ ███     ███ ███   ███  |   | 
 |   |           ███   ███    ███   ███    ███ ███     ███ ███    ███ ███    ███ ███     ███ ███   ███  |   | 
 |   |     ▄█    ███   ███    ███   ███    ███ ███ ▄█▄ ███ ███   ▄███ ███    ███ ███ ▄█▄ ███ ███   ███  |   | 
 |   |   ▄████████▀    ███    █▀     ▀██████▀   ▀███▀███▀  ████████▀   ▀██████▀   ▀███▀███▀   ▀█   █▀   |   | 
 |   |                                                                                                  |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                                                                (_____)";

printslow(titulo);
Console.ResetColor();
Thread.Sleep(200);
System.Console.WriteLine();
System.Console.WriteLine();
printslow1(inicio);
Console.ReadKey();
Console.Clear();
Console.ResetColor();
 string optslct = @"
                                                                     
 █████████ █████████ █████████ █████████ █████████ █████████ █████████
░░░░░░░░░ ░░░░░░░░░ ░░░░░░░░░ ░░░░░░░░░ ░░░░░░░░░ ░░░░░░░░░ ░░░░░░░░░ ";
void DibujarMenu()
{


    for (int i = 0; i < menu1.Length; i++)
    {

            Console.Clear();
        if (i == opciones1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine(menu1[i] + optslct);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(@"" + menu1[i] + @"
            
            
            
            
            
");
        }


    }

}



while (true)
{
    Console.Clear();
    DibujarMenu();

    ConsoleKey key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.W && opciones1 > 0)
    {
        ReproducirSonido(rutasonido[2]);
        opciones1--;
    }
    else if (key == ConsoleKey.S && opciones1 < menu1.Length - 1)
    {
        ReproducirSonido(rutasonido[2]);
        opciones1++;
    }
    else if (key == ConsoleKey.Enter)
    {
        Console.WriteLine();
        Console.WriteLine("Has elegido " + menu1[opciones1]);
        ReproducirSonido(rutasonido[3]);

        if (opciones1 == 0)
        {
            cargando();
            Thread.Sleep(750);
            SeleccionarEstudiantes();
        }
        else if (opciones1 == 1)
        {

            Console.WriteLine("Opción 'Roles' seleccionada.");
            Thread.Sleep(1000);
        }
        else if (opciones1 == 2)
        {
            
            

            ResetearColoresEstudiantes();
            Console.WriteLine("Colores de todos los estudiantes han sido restablecidos.");
            Thread.Sleep(1000);
        }
        else if (opciones1 == 3)
        {
            break;
        }
    }
}
    

