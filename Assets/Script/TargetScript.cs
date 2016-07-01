using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {


        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }
        void OnTriggerEnter(Collider other){
                if(other.gameObject.tag=="Ball") {
                        ScoreScript.TargetCount+=1;
                        Destroy(this.gameObject);
                }
        }

}
