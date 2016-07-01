using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
        public Text time;
        public static float timelimit=5f;
        // Use this for initialization
        void Start () {
                timelimit=30f;
        }

        // Update is called once per frame
        void Update () {
                timelimit-=Time.deltaTime;
                time.text=timelimit.ToString("f0");
                if(timelimit<0) {
                        SceneManager.LoadScene("end");
                }
        }
}
