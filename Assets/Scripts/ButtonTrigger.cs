using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Door door;
    public Animator buttonAnimator;
    public float autoCloseDelay = 3f;

    private bool isPressed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isPressed)
        {
            isPressed = true;

            // Eğer daha önce kapanma için zamanlayıcı başlatıldıysa, iptal et.
            CancelInvoke(nameof(DelayedCloseDoor));

            if (buttonAnimator != null)
            {
                // Butonun basma animasyonunu oynat.
                buttonAnimator.SetTrigger("Press");
            }

            if (door != null)
            {
                door.SetOpen(true); // Kapıyı aç.
                Debug.Log("Butona basıldı → Kapı açıldı!");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Oyuncu butondan ayrıldığında, belirli bir gecikmeyle kapıyı kapat.
            Invoke(nameof(DelayedCloseDoor), autoCloseDelay);
            Debug.Log("Butondan uzaklaşıldı, 3 saniye sonra kapı kapanacak.");
            isPressed = false; // Tekrar basılabilir hale getir.
        }
    }

    private void DelayedCloseDoor()
    {
        if (door != null)
        {
            door.SetOpen(false); // Kapıyı kapat.
            Debug.Log("Kapı otomatik olarak kapandı!");
        }

        if (buttonAnimator != null)
        {
            // Butonun eski haline dönme animasyonunu oynat.
            // Bu, 'Release' adında bir animasyon parametrenizin olduğunu varsayar.
            buttonAnimator.SetTrigger("Release");
        }
    }
}