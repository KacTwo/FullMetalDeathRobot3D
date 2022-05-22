using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private TMP_Text timeScoreText;
    [SerializeField] private TMP_Text timeScoreMinuteText;

    public float timeScoreMinute =0;
    public float timeScore = 0;
    public int deathScore = 0;
    public float totalPointScore = 0;
    public float pointScore = 0;







    private void Awake()
    {
        MakeSingleton();
       
    }
    // keep gamemanger betewen scenes 
    private void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()  
    {
        /* liczy czas chyba
        if (timeScore > 59)  //  niepamiêtam co to robi
        {
            timeScore = 0;
            timeScoreMinute += 1;
            timeScoreMinuteText.text = Mathf.FloorToInt(timeScoreMinute).ToString();
           // CreateText();    //robienie logów o graczu


        }

            timeScore += Time.deltaTime;
           // timeScoreText.text = Mathf.FloorToInt(timeScore).ToString();

        */

    }
    
    // Robienie logów o graczach,
    /* public void CreateText()   
     {
         string path = Application.dataPath + "/log.txt";
         if (!File.Exists(path))
         {
             File.WriteAllText(path, "Login log \n\n");
         }
         string content = "Login date: " + System.DateTime.Now + "\n\n"  + "Time in game: " + timeScoreMinute + " minutes, " + timeScore + " seconds \n"
         + "Number of Deaths: " + deathScore + "\n"
         + "Narrator Gender: " + voiceIsMale + " (t:male) (f:femmale) \n"
         + "Score: " +  pointScore + "\n" // ten sie zesral
         + "Collected Story items: " + storyScore + "\n\n" // int potrzebny i over write 
         ;
         File.AppendAllText(path, content);
    
} */
    void Start()
    {
    // logi
    //    CreateText();
    }

}
    //public enum Pointstate


