namespace Piano;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;
static class PianoClass{
    
    private static string WhatIsNoise(char key){
        int.TryParse(key.ToString(), out int number);
        switch(number){
            case (int) Nots.Do:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-do.wav";
            case (int) Nots.Re:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-re.wav";
            case (int) Nots.Mi:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-mi.wav";
            case (int) Nots.Fa:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-fa.wav";
            case (int) Nots.Sol:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-sol.wav";
            case (int) Nots.Lya:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-lya.wav";
            case (int) Nots.Si:
                return "C:\\Users\\user\\Desktop\\ds\\Piano\\sounds\\zvuk-notyi-si.wav";
            default:
                return "0";
        }
    }
    public static void PlaySomeNoise(char key){
        string noise = WhatIsNoise(key);
        if(noise == "0"){
            return;
        }
        using(var audioFile = new AudioFileReader(noise))
        using(var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1000);
            }
        }
        
        
    }
}
static class Greetings
{
    static private readonly string UserName;

    static Greetings(){
        UserName =$"Мистер {Environment.UserName}";
    }
    public static void SayHelloToUser(){
        Console.WriteLine($"Приветствую вас, дорогой {Greetings.UserName}!");
    }
}
enum Nots{
    Do,
    Re,
    Mi,
    Fa,
    Sol,
    Lya,
    Si

}