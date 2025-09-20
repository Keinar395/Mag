using UnityEngine;



public class Trap : MonoBehaviour

{

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            Debug.Log("Oyuncu dikenlere çarptý! (Trigger)");

        }

    }

}