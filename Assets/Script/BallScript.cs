using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

        // public static Vector3 v3;

        // Use this for initialization
        void Start () {


        }

        // Update is called once per frame
        void Update () {

        }

        void Vec(Vector3 v){
          GetComponent<Rigidbody>().velocity = v*100;
          Destroy(gameObject,10);


        }
      


}
