namespace State_Design_Pattern_MP3_Demo
{
    public class Play : Mp3State
    {
        Mp3Context _context;
        public Play(Mp3Context context)
        {
            _context = context;
        }
        public void PlayMusic()
        {
            Console.WriteLine("Müzik çalmaya devam ediyor");
        }

        public void StopMusic()
        {
            Console.WriteLine("Müzik durduruldu");
            _context.SetStop();
        }
    }
}