using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    [SerializeField] float lifeBoss;
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.boss);
        lifeBoss = 2000f;
    }

    public void RestarVida()
    {
        if (lifeBoss > 0)
        {
            lifeBoss -= 10f;
        }
        else
        {
            StartCoroutine("CambiarEscena");
            AudioManager.Instance.StopAudio(AudioManager.Instance.boss);
            AudioManager.Instance.PlayAudio(AudioManager.Instance.bossDead);
            GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }

    IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(4f);
        AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundBoss);
        SceneManager.LoadScene(7);
    }
    public float GetVida()
    {
        return lifeBoss;
    }
}
