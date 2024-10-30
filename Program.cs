using System.Diagnostics;
using System.Media;
using NAudio.Wave;
using System.Threading.Tasks;

static void printslow(string texto)
{        
    

    Random random = new Random();

    Stopwatch lento = new Stopwatch();
    lento.Start();
    foreach (char caracter in texto)
    {
        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
        System.Console.Write(caracter);
        while (lento.Elapsed.TotalMilliseconds < 0.6)
        { }
        lento.Restart();
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
    
};

string[] rutasonido = new string[]
{@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\8-bit-jump_130bpm_C_minor.wav",
@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\8-bit-kit-hi-hat-closed-3_C_minor.wav",
@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\windows-10-sfx-navigation-start.wav",
@"C:\Users\micha\OneDrive\Escritorio\Codigos\Competencia\Efectos\windows-98-click.wav"};
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
                 audioFile.Volume = 0.3f;

                waveOut.Init(audioFile);
                waveOut.Play();

                while (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100); 
                }
            }
        }
    }

//ReproducirMusicaAleatoria(musicas);
 Task.Run(() => ReproducirMusicaAleatoria(musicas));
string[] menu1 = {"Ruleta", "Roles", "Salir" };
int opciones1 = 0;

string titulo = @" 
 _____                                                                                                  _____ 
( ___ )                                                                                                ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |                                                                                                  |   | 
 |   |                       ▄████████  ▄█          ▄████████    ▄████████    ▄████████                 |   | 
 |   |                      ███    ███ ███         ███    ███   ███    ███   ███    ███                 |   | 
 |   |                      ███    █▀  ███         ███    ███   ███    █▀    ███    █▀                  |   | 
 |   |                      ███        ███         ███    ███   ███          ███                        |   | 
 |   |                      ███        ███       ▀███████████ ▀███████████ ▀███████████                 |   | 
 |   |                      ███    █▄  ███         ███    ███          ███          ███                 |   | 
 |   |                      ███    ███ ███▌    ▄   ███    ███    ▄█    ███    ▄█    ███                 |   | 
 |   |                      ████████▀  █████▄▄██   ███    █▀   ▄████████▀   ▄████████▀                  |   | 
 |   |                                 ▀                                                                |   | 
 |   |     ▄████████    ▄█    █▄     ▄██████▄   ▄█     █▄  ████████▄   ▄██████▄   ▄█     █▄  ███▄▄▄▄    |   | 
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
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();

int menutop = 8;
void DibujarMenu()
{
    Console.SetCursorPosition(0, menutop);
    for (int i = 0; i < menu1.Length; i++)
    {
        if (i == opciones1)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("   >>  [");
            Console.WriteLine(menu1[i] + "] << ");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("        " + menu1[i] + "      ");
        }
    }
}
while (true)
{
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
        
        
        System.Console.WriteLine("Has elegido " + menu1[opciones1]);
        ReproducirSonido(rutasonido[0]);
        break;

    }


    Thread.Sleep(100);
}