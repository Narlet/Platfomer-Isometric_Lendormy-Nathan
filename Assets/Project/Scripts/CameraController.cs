using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform _target = null;
    void Update()
    {
        transform.LookAt( _target );
    }
}
