using UnityEngine;

public class Spike : MonoBehaviour
{
    // �lk g�r�nmez olma veya g�r�n�r olma d�ng�s�n�n ba�lamas� i�in gecikme
    public float initialDelay = 3f;

    // �elalenin her 3 saniyede bir durum de�i�tirmesini sa�layacak s�re
    public float repeatRate = 3f;

    private bool isVisible = true;

    private void Start()
    {
        // 'ToggleSpike' fonksiyonunu 3 saniye sonra ba�lat ve her 3 saniyede bir tekrarla
        InvokeRepeating(nameof(ToggleSpike), initialDelay, repeatRate);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // E�er �elale g�r�n�rse oyuncuya hasar ver
            if (isVisible)
            {
                Debug.Log("Oyuncu �elaleye �arpt� ve hasar ald�!");
            }
            else
            {
                Debug.Log("�elale g�r�nmez oldu�u i�in oyuncu hasar almad�.");
            }
        }
    }

    private void ToggleSpike()
    {
        // �elalenin g�r�n�rl���n� tersine �evir
        isVisible = !isVisible;

        // �elale objesinin g�rselini ve collider'�n� devre d��� b�rak/etkinle�tir
        // Bu k�s�m, �elalenin nas�l olu�turuldu�una ba�l� olarak de�i�ebilir.
        // Genellikle sprite veya mesh renderer ve collider component'i kullan�l�r.
        GetComponent<SpriteRenderer>().enabled = isVisible;
        GetComponent<Collider2D>().enabled = isVisible;

        // Konsola bilgi mesaj� yazd�r
        if (isVisible)
        {
            Debug.Log("�elale �imdi g�r�n�r.");
        }
        else
        {
            Debug.Log("�elale �imdi kayboldu.");
        }
    }
}