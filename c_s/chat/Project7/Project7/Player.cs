using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project7;
using System.Collections.Generic;

namespace Project7
{
    public class Player
    {
        public Vector2 Pozisyon; // karakterin ekrandaki konumu
        private float hareketHizi = 3f;

        private Dictionary<string, Texture2D> yuruSpriteSet;
        private string aktifYon = "down";

        private int aktifKare = 0;
        private int kareGenislik = 32;
        private int kareYukseklik = 48;
        private int kareSayisi = 4;

        private double animasyonSayaci = 0;
        private double animasyonSuresi = 150;

        private TileMap tileMap;

        public Player(Dictionary<string, Texture2D> spriteSet, Vector2 baslangicPozisyon, TileMap map)
        {
            yuruSpriteSet = spriteSet;
            Pozisyon = baslangicPozisyon;
            tileMap = map;
        }

        public void Guncelle(GameTime gameTime)
        {
            var klavye = Keyboard.GetState();

            Vector2 hedefPozisyon = Pozisyon;
            bool hareketVar = false;

            if (klavye.IsKeyDown(Keys.Right))
            {
                hedefPozisyon.X += hareketHizi;
                aktifYon = "right";
                hareketVar = true;
            }
            else if (klavye.IsKeyDown(Keys.Left))
            {
                hedefPozisyon.X -= hareketHizi;
                aktifYon = "left";
                hareketVar = true;
            }
            else if (klavye.IsKeyDown(Keys.Up))
            {
                hedefPozisyon.Y -= hareketHizi;
                aktifYon = "up";
                hareketVar = true;
            }
            else if (klavye.IsKeyDown(Keys.Down))
            {
                hedefPozisyon.Y += hareketHizi;
                aktifYon = "down";
                hareketVar = true;
            }

            // ✅ Çarpışma kontrolü: karakterin alt kenarının sol ve sağ noktası
            Vector2 solAlt = hedefPozisyon + new Vector2(4, kareYukseklik - 4);
            Vector2 sagAlt = hedefPozisyon + new Vector2(kareGenislik - 4, kareYukseklik - 4);

            if (tileMap.HareketEdilebilirMi(solAlt) && tileMap.HareketEdilebilirMi(sagAlt))
            {
                Pozisyon = hedefPozisyon;
            }

            if (hareketVar)
            {
                animasyonSayaci += gameTime.ElapsedGameTime.TotalMilliseconds;

                if (animasyonSayaci >= animasyonSuresi)
                {
                    aktifKare = (aktifKare + 1) % kareSayisi;
                    animasyonSayaci = 0;
                }
            }
            else
            {
                aktifKare = 0;
            }
        }

        public void Ciz(SpriteBatch spriteBatch)
        {
            Texture2D aktifSprite = yuruSpriteSet[aktifYon];
            Rectangle kaynak = new Rectangle(aktifKare * kareGenislik, 0, kareGenislik, kareYukseklik);
            spriteBatch.Draw(aktifSprite, Pozisyon, kaynak, Color.White);
        }
    }
}
