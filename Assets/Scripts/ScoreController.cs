using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers {    
    public class ScoreController : MonoBehaviour
    {

        public Text scoreText;
        public int score = 0;

        public void ScoreUp() {
            Debug.Log($"Score: {score}");
            score += 100;
            scoreText.text = score.ToString();
        }

    }
}
