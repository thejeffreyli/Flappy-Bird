using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        Score.score++;
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class AddScore : MonoBehaviour
// {
//     public static int points = 0;

//     private void OnCollisionEnter2D(Collision2D collision) {
//         Score.score++;
//     }
// }

// 	public static int points = 0;
    
//     private void OnTriggerEnter(Collider other) {

//         points = points + 10;
//         wakaSound.Play();
//         alreadyPlayed = true;

//     }

// public class ScoreTracker : MonoBehaviour
// {
// 	public GameObject player;
// 	public Text scoreText;

//     // Update is called once per frame
//     void Update()
//     {
//         scoreText.text = PillScript.points.ToString();
//     }
// }
