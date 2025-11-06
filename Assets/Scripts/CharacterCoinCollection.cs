using TMPro;
using UnityEngine;

public class CharacterCoinCollection : MonoBehaviour
{
    [Header("Sounds")]
    [SerializeField] AudioSource _audioSource = null;
    [SerializeField] private AudioClip _coinSound = null;

    [Header("Coin")]
    [SerializeField] TextMeshProUGUI _coinText = null;
    [SerializeField] private int _maxCoin = 1;
    private int _coinCollection = 0;

    private void Start()
    {
        _coinCollection = 0;
    }

    void Update()
    {
        WinGame();
        DisplayCoinCollec();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            _coinCollection++;
            Destroy(other.gameObject);
            _audioSource.PlayOneShot(_coinSound);
            Debug.Log(_coinCollection);
        }
    }

    private void DisplayCoinCollec()
    {
        _coinText.text = "Coins : " + _coinCollection.ToString() + "/" + _maxCoin.ToString();
    }

    private void WinGame()
    {
        if (_coinCollection >= _maxCoin)
        {
            Debug.Log("WIN");
        }
    }
}
