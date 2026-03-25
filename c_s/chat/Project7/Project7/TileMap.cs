using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project7
{
    public class TileMap
    {
        private int[,] haritaVerisi;
        private Texture2D cimenTexture;
        private Texture2D tasTexture;
        private int tileBoyutu = 32;

        public TileMap(int[,] harita, Texture2D cimen, Texture2D tas)
        {
            haritaVerisi = harita;
            cimenTexture = cimen;
            tasTexture = tas;
        }

        public void Ciz(SpriteBatch spriteBatch)
        {
            for (int satir = 0; satir < haritaVerisi.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < haritaVerisi.GetLength(1); sutun++)
                {
                    int tile = haritaVerisi[satir, sutun];
                    Vector2 pozisyon = new Vector2(sutun * tileBoyutu, satir * tileBoyutu);
                    Rectangle hedefAlan = new Rectangle((int)pozisyon.X, (int)pozisyon.Y, tileBoyutu, tileBoyutu);

                    if (tile == 0)
                        spriteBatch.Draw(cimenTexture, hedefAlan, Color.White);
                    else if (tile == 1)
                        spriteBatch.Draw(tasTexture, hedefAlan, Color.White);
                }
            }
        }

        public int TileTurunuAl(Vector2 pozisyon)
        {
            int sutun = (int)(pozisyon.X / tileBoyutu);
            int satir = (int)(pozisyon.Y / tileBoyutu);

            if (satir < 0 || satir >= haritaVerisi.GetLength(0) ||
                sutun < 0 || sutun >= haritaVerisi.GetLength(1))
                return 1;

            return haritaVerisi[satir, sutun];
        }

        public bool HareketEdilebilirMi(Vector2 pozisyon)
        {
            int sutun = (int)(pozisyon.X / 32);
            int satir = (int)(pozisyon.Y / 32);

            if (satir < 0 || satir >= haritaVerisi.GetLength(0) ||
                sutun < 0 || sutun >= haritaVerisi.GetLength(1))
                return false;

            return haritaVerisi[satir, sutun] == 0; // sadece çimse geç
        }

    }
}
