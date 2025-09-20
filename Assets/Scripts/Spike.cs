using UnityEngine;

public class Spike : MonoBehaviour
{
    // Ýlk görünmez olma veya görünür olma döngüsünün baþlamasý için gecikme
    public float initialDelay = 3f;

    // Þelalenin her 3 saniyede bir durum deðiþtirmesini saðlayacak süre
    public float repeatRate = 3f;

    private bool isVisible = true;

    private void Start()
    {
        // 'ToggleSpike' fonksiyonunu 3 saniye sonra baþlat ve her 3 saniyede bir tekrarla
        InvokeRepeating(nameof(ToggleSpike), initialDelay, repeatRate);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Eðer þelale görünürse oyuncuya hasar ver
            if (isVisible)
            {
                Debug.Log("Oyuncu þelaleye çarptý ve hasar aldý!");
            }
            else
            {
                Debug.Log("Þelale görünmez olduðu için oyuncu hasar almadý.");
            }
        }
    }

    private void ToggleSpike()
    {
        // Þelalenin görünürlüðünü tersine çevir
        isVisible = !isVisible;

        // Þelale objesinin görselini ve collider'ýný devre dýþý býrak/etkinleþtir
        // Bu kýsým, þelalenin nasýl oluþturulduðuna baðlý olarak deðiþebilir.
        // Genellikle sprite veya mesh renderer ve collider component'i kullanýlýr.
        GetComponent<SpriteRenderer>().enabled = isVisible;
        GetComponent<Collider2D>().enabled = isVisible;

        // Konsola bilgi mesajý yazdýr
        if (isVisible)
        {
            Debug.Log("Þelale þimdi görünür.");
        }
        else
        {
            Debug.Log("Þelale þimdi kayboldu.");
        }
    }
}