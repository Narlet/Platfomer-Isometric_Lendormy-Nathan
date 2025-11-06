using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1f;
    [SerializeField] private Vector3[] _positionVariations = null;


    private void Update()
    {
        transform.eulerAngles += new Vector3(0, 1, 0) * _rotationSpeed * Time.deltaTime;
    }

}
