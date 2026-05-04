using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{

    private int tempo;
    [SerializeField] Text tempoText;

    void Start()
    {
       tempo = 0;
        StartCoroutine(Timer());
    }

    void Update()
    {
        tempoText.text = tempo.ToString();
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        tempo++;
        StartCoroutine(Timer());
    }

}
