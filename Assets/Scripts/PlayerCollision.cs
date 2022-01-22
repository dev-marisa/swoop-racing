using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers {
    public class PlayerCollision : MonoBehaviour
    {

        public PlayerMovement movement;
        public int score = 0;
        public Text scoreText;

        // public void Start() {
        //     scoreText = GameObject.Find("Score").GetComponent<Text>();
        //     Debug.Log(scoreText.text);
        // }

        public void OnCollisionEnter (Collision collisionInfo) {
            Debug.Log(collisionInfo.collider.name);

            if (collisionInfo.collider.tag == "Obstacle")
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            } 
        }

        public void OnTriggerEnter(Collider c) {
            if (c.tag == "Pickup")
            {
                Destroy(c.gameObject);
                movement.forwardForce += 200;
                score += 100;
                scoreText.text = score.ToString();
            }
        }

    }

}
