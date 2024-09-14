using Piano;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;
class Program{
    static void Main(string[] args){
        Greetings.SayHelloToUser();
        while(true){
           char KeyboardValue = Console.ReadKey().KeyChar;
           PianoClass.PlaySomeNoise(KeyboardValue);
        }

    }
    
}