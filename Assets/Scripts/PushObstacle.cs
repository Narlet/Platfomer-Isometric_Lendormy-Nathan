using UnityEngine;

public class PushObstacle : MonoBehaviour
{
    [SerializeField] private float _forcePower  = 1.0f;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if (rigidbody != null && rigidbody.transform.tag == "PushableObstacle")
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.forward;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection * _forcePower, transform.position, ForceMode.Impulse);
        }
    }
}
