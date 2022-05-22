using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.Audio;

public class ScoreaMnager : MonoBehaviour
{


    [SerializeField] TMP_Text pointScoreText;

    // float pointScore = 0;
    //public float storyScore = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pointScoreText.text = Mathf.FloorToInt(GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore).ToString();

        
        }













    }

