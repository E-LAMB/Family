using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bro")
        {
            Mind.player_sis_score += 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        if (collision.tag == "Sis")
        {
            Mind.player_bro_score += 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }

}
