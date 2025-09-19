using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Door door; // Baðlanacak kapý

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            door.OpenDoor();
            Debug.Log("Butona basýldý!");
        }
    }
}
