using Microsoft.Xna.Framework;

namespace Project7
{
    public class Camera
    {
        private Matrix transformMatrix;           // Ekrandaki dönüşüm matrisi
        private Vector2 ekranMerkez;              // Ekranın ortası

        public Camera(int ekranGenislik, int ekranYukseklik)
        {
            // Ekranın ortasını hesapla
            ekranMerkez = new Vector2(ekranGenislik / 2, ekranYukseklik / 2);
        }

        // Kamera karaktere göre konumlanır (transform matrisi oluşturur)
        public void TakipEt(Vector2 hedefPozisyon)
        {
            // Karakteri ekranın ortasına getir (ters pozisyon + ekran ortası)
            transformMatrix = Matrix.CreateTranslation(new Vector3(-hedefPozisyon + ekranMerkez, 0));
        }

        // SpriteBatch'e aktarılacak matrix'i döndürür
        public Matrix GetMatrix()
        {
            return transformMatrix;
        }
    }
}
