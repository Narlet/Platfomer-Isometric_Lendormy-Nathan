using Unity.VisualScripting;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    private float _timestamps = 0f;
    [SerializeField] private float _endScreanDuration = 0f;

    private void Start()
    {
        _timestamps = 0;
    }
    void Update()
    {
        EndGame();
    }

    private void EndGame()
    {
        _timestamps += Time.deltaTime;
        if ( _timestamps >= _endScreanDuration)
        {
            Debug.Log("QUIT");
            Application.Quit();
        }

    }
}
