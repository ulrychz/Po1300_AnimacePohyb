namespace Po1300_AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string iDPostavy, string jmeno, string image, int width) 
        { 
            IDPostavy = iDPostavy;
            Jmeno = jmeno;
            Image = image;
            Width = width;
            AktualniPozice = -1;
        }
        public List<Souradnice> PoziceList { get; private set; } = new List<Souradnice>();
        public string Jmeno { get; private set; }
        public string IDPostavy { get; private set; }
        public string Image { get; private set; }
        public int Width { get; private set; }
        public int AktualniPozice { get; private set; }
        private int IndexDalsi { get; set; } = 1;
        public string Style { 
            get {
                if (AktualniPozice < 0)
                    return "";
                else
                {
                    var poz = PoziceList[AktualniPozice];
                    return poz.Style + $"width: {Width*poz.ImageSize/100}px; "; ;
                }
            }
        }
        private bool JdiDoleva { get; set; } = false;
        public string TransformRotateY => JdiDoleva ? "transform: rotateY(180deg);" : "transform: rotateY(0deg);";
         
        public int Progress => (int)Math.Round((double)(AktualniPozice+1)/PoziceList.Count * 100);

        public void PridejPozici(int pozX, int pozY,int imageSize)
        {
            var souradnice = new Souradnice(pozX, pozY, imageSize);
            PoziceList.Add(souradnice);
        }

        public void Presun()
        {
            if (IndexDalsi == 1)
            {
                //jdu dopredu
                if (PoziceList.Count == AktualniPozice + 1)
                {
                    //jsme na konci cesty
                    IndexDalsi = -1;
                }
            }
            else
            {
                //jdu zpet - tj. IndexDalsi = -1
                if (AktualniPozice == 0)
                {
                    //jsme na zacatku cesty
                    IndexDalsi = 1;
                }
            }
            var predchoziPozice = AktualniPozice;
            
            AktualniPozice += IndexDalsi;
            if (predchoziPozice >=0)
            {
                JdiDoleva = PoziceList[predchoziPozice].PozX > PoziceList[AktualniPozice].PozX;
            }
        }
    }
}
