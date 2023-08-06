using System.Diagnostics;

namespace State_Design_Pattern_MP3_Demo
{
    public class Mp3Context
    {
        Mp3State state;
        Mp3State play;
        Mp3State stop;
        public Mp3Context()
        {
            play = new Play(this);
            stop = new Stop(this);
            state = play;
        }


        public void SetPlay() => state = play;
        public void SetStop() => state = stop;

        public void Play() => state.PlayMusic();
        public void Stop() => state.StopMusic();
    }
}