using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

        public GameObject ball;
        public Camera mycamera;
        public float timer;
        RaycastHit hit;
        public Vector3 vec;
        // public Vector3 v3;
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
                                //  Ray ray =Camera.main.ScreenPointToRay(v3);
                                Ray ray = mycamera.ScreenPointToRay(v3);
                                float distance = 1000;
                                if(Physics.Raycast(ray,out hit,distance)) {

                                        v3 = mycamera.ScreenToWorldPoint(v3);//始点
                                        vec =(hit.point-v3).normalized;
                                        Debug.Log(v3);
                                        GameObject obj = (GameObject)Instantiate(ball, v3, transform.rotation);
                                        obj.SendMessage("Vec",vec);
                                }
                                timer = 0;
                        }
                }
        }
}
