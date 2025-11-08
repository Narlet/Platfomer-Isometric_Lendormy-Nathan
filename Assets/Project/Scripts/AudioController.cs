using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource[] _audioSources = null;
    [SerializeField] AudioClip[] _audioClips = null;
    [SerializeField] private float[] _timestamps = null;

    private void Start()
    {
        _timestamps[0] = _audioClips[0].length;
        _timestamps[1] = _audioClips[1].length;
    }
    void Update()
    {
        PlaySound(_audioSources[0], _audioClips[0],0);
        PlaySound(_audioSources[1], _audioClips[1], 1);
    }

   private void PlaySound(AudioSource audioSource, AudioClip audioClip, int timestampID)
    {
        _timestamps[timestampID] += Time.deltaTime;
        if (_timestamps[timestampID] >= audioClip.length)
        {
            Debug.Log("oue");
            audioSource.PlayOneShot(audioClip);
            _timestamps[timestampID] = 0;
        }
    }
}
