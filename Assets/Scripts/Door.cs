using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform openPosition; // Kap�n�n a��laca�� pozisyon
    public float speed = 2f;       // A��lma h�z�
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
        Debug.Log("Kap� a��l�yor!");
    }
}
