using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

        public GameObject ball;
        public Camera mycamera;
        public float timer;
        // Use this for initialization
        void Start () {
                //Destroy(gameObject,5);
        }

        // Update is called once per frame
        void Update()
        {


                if (Input.GetMouseButton(0))
                {
                        timer += Time.deltaTime;
                        if(timer>0.1) {
                                Vector3 v3 = Input.mousePosition;
                                v3.z = 5;
                                v3 = mycamera.ScreenToWorldPoint(v3);
                                Debug.Log(v3);

                                Instantiate(ball, v3, transform.rotation);

                                timer = 0;
                        }
                }
        }
}
