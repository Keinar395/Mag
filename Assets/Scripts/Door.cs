using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform openPosition; // Kapýnýn açýk olduðu pozisyon
    public float speed = 2f; // Kapýnýn hareket hýzý

    private Vector3 closedPosition; // Kapýnýn baþlangýçtaki, yani kapalý pozisyonu
    private bool isOpen = false;

    private void Start()
    {
        // Kapýnýn baþlangýç pozisyonunu kaydediyoruz.
        closedPosition = transform.position;
    }

    private void Update()
    {
        if (isOpen)
        {
            // Kapý açýksa, açýk pozisyona doðru hareket et.
            transform.position = Vector3.MoveTowards(transform.position, openPosition.position, speed * Time.deltaTime);
        }
        else
        {
            // Kapý kapalýysa, kapalý pozisyona doðru hareket et.
            transform.position = Vector3.MoveTowards(transform.position, closedPosition, speed * Time.deltaTime);
        }
    }

    public void SetOpen(bool state)
    {
        // Kapýnýn durumunu günceller.
        isOpen = state;
    }
}