using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private Transform _spanwPoint = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "DeathZone")
        {
            Debug.Log("Death");
        }
    }
}
