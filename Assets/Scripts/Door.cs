using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform openPosition; // Kap�n�n a��k oldu�u pozisyon
    public float speed = 2f; // Kap�n�n hareket h�z�

    private Vector3 closedPosition; // Kap�n�n ba�lang��taki, yani kapal� pozisyonu
    private bool isOpen = false;

    private void Start()
    {
        // Kap�n�n ba�lang�� pozisyonunu kaydediyoruz.
        closedPosition = transform.position;
    }

    private void Update()
    {
        if (isOpen)
        {
            // Kap� a��ksa, a��k pozisyona do�ru hareket et.
            transform.position = Vector3.MoveTowards(transform.position, openPosition.position, speed * Time.deltaTime);
        }
        else
        {
            // Kap� kapal�ysa, kapal� pozisyona do�ru hareket et.
            transform.position = Vector3.MoveTowards(transform.position, closedPosition, speed * Time.deltaTime);
        }
    }

    public void SetOpen(bool state)
    {
        // Kap�n�n durumunu g�nceller.
        isOpen = state;
    }
}