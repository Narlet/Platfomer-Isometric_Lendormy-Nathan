using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private Transform _spanwPoint = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "DeathZone")
        {
            GetComponent<CharacterController>().enabled = false;
            Debug.Log("Death");
            transform.position = _spanwPoint.position;
            GetComponent<CharacterController>().enabled = true;
        }
    }
}
