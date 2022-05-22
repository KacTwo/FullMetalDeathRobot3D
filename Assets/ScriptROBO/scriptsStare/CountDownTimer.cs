using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class CountDownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    [SerializeField] TextMeshProUGUI countdownText;
    

    public void  Start()
    {
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            GameObject.Find("InGameManager").GetComponent<GameManager>().deathScore += 1;
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
