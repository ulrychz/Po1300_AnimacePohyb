using Po1300_AnimacePohyb.Models;

namespace Po1300_AnimacePohyb.Pages
{
    public partial class Animace1
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }
        public Postava Postava { get; set; }
        private void InicializaceHry()
        {
            Postava = new Postava(iDPostavy: "maxipes", jmeno: "Maxipes", image: "../img/maxipes.png", width: 150);
            Postava.PridejPozici(pozX: 45, pozY: 280, imageSize: 70);
            Postava.PridejPozici(pozX: 450, pozY: 240, imageSize: 40);
            Postava.PridejPozici(pozX: 840, pozY: 340, imageSize: 80);
            Postava.PridejPozici(pozX: 110, pozY: 470, imageSize: 100);
        }
    }
}
