namespace State_Design_Pattern_MP3_Demo
{
    internal class Stop : Mp3State
    {
        Mp3Context _context;
        public Stop(Mp3Context context)
        {
            _context = context;
        }

        public void PlayMusic()
        {
            Console.WriteLine("Müzik başlatılıyor");
            _context.SetStop();
        }


        public void StopMusic()
        {
            Console.WriteLine("Müzik durmaya devam ediyor");
        }
    }
}