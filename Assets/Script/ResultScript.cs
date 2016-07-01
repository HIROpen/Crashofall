using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {

        public Text scoreText;

        // Use this for initialization
        void Start () {
                scoreText.text=ScoreScript.TargetCount.ToString();
        }

        // Update is called once per frame
        void Update () {

        }
}
