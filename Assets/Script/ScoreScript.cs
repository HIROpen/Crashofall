using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


        public Text Scorelabel;
        public static int TargetCount=0;
        // public gameObject Barrel;
        // Use this for initialization
        void Start () {
// TargetCount=TargetCount-20;
        }

        // Update is called once per frame
        void Update () {

                Scorelabel.text=TargetCount.ToString();
        }

}
