namespace Po1300_AnimacePohyb.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX,  int pozY, int imageSize)
        { 
            PozX = pozX;
            PozY = pozY;
            ImageSize = imageSize;
        }
        public int PozX { get; }
        public int PozY { get; private set;}
        public int ImageSize { get; }

        public string Style => $"left: {PozX}px; top: {PozY}px;";
    }
}
