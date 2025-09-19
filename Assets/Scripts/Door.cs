using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform openPosition; // Kapýnýn açýlacaðý pozisyon
    public float speed = 2f;       // Açýlma hýzý
    private Vector3 closedPosition;
    private bool isOpening = false;

    private void Start()
    {
        closedPosition = transform.position;
    }

    private void Update()
    {
        if (isOpening)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition.position, speed * Time.deltaTime);
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
        Debug.Log("Kapý açýlýyor!");
    }
}
