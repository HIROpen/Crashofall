using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

        // Use this for initialization
        void Start () {
    GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 15);
        }

        // Update is called once per frame
        void Update () {

        }

}
