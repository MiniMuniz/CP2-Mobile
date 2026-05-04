using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RoadManager : MonoBehaviour
{
    [SerializeField] private float step;
    [SerializeField] private AudioSource colectable;
    [SerializeField] private AudioSource obstacle;

    [SerializeField] private Text scoreText;

    private int score = 0;

    private void Start()
    {
        score = 0;
    }


    private void Update()
    {
        scoreText.text = score.ToString();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enter")
        {
            Vector3 p = other.transform.position;
            p.z += step;
            other.transform.position = p;
        }

        if (other.gameObject.tag == "Colectable")
        {
            score++;
            colectable.Play();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            obstacle.Play();
            StartCoroutine(Delay());
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOverScene");
    }

}



