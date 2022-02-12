using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
public class DebScoringSystem : MonoBehaviour
{

    public GameObject ScoreText;
    public static int theScore;

    void Update()
    {
        ScoreText.GetComponent<Text>().text = "GEMS: " + theScore + "/X";
    }

}
