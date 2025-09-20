using UnityEngine;

public class Spike : MonoBehaviour
{
    public float initialDelay = 3f;
    public float repeatRate = 3f;
    public float knockbackForce = 10f; // Geri tepme kuvveti

    private bool isVisible = true;

    private void Start()
    {
        InvokeRepeating(nameof(ToggleSpike), initialDelay, repeatRate);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // E�er �elale g�r�n�rse oyuncuya hasar ver ve geri tepme uygula
            if (isVisible)
            {
                Debug.Log("Oyuncu �elaleye �arpt� ve hasar ald�!");
                ApplyKnockback(other.transform);
            }
            else
            {
                Debug.Log("�elale g�r�nmez oldu�u i�in oyuncu hasar almad�.");
            }
        }
    }

    private void ApplyKnockback(Transform player)
    {
        Rigidbody2D playerRb = player.GetComponent<Rigidbody2D>();
        if (playerRb != null)
        {
            // Oyuncuyu �elalenin tersi y�nde it
            Vector2 knockbackDirection = (player.position - transform.position).normalized;
            playerRb.linearVelocity = Vector2.zero;
            playerRb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
        }
    }

    private void ToggleSpike()
    {
        isVisible = !isVisible;
        GetComponent<SpriteRenderer>().enabled = isVisible;
        GetComponent<Collider2D>().enabled = isVisible;

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