using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intermission : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject big_reveal;
    public GameObject bro_object;
    public GameObject tie;

    public float timer;

    void Start()
    {
        if (Mind.player_sis_score > Mind.player_bro_score)
        {
            bro_object.SetActive(false);
        }
        if (Mind.player_bro_score == Mind.player_sis_score)
        {
            tie.SetActive(true);
        }
        big_reveal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int chosen = Random.Range(2, 7);
        timer += Time.deltaTime;
        if (Mind.previous_game != chosen && timer > 3f)
        {
            Mind.previous_game = chosen;
            UnityEngine.SceneManagement.SceneManager.LoadScene(chosen);
        }
    }
}
