using UnityEngine;
using System.Collections;

public class TargetCreaterScript : MonoBehaviour {

        public GameObject target;
        float timer = 5.0f;
        float timer2 = 5.0f;
        float timer3 = 5.0f;
        float timer4 = 5.0f;
        int interval = 5;
        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {
                timer+=Time.deltaTime;
                if(timer>=interval) {
                        transform.position=new Vector3(Random.Range(-50.0f,40.0f),7.5f,60f);
                        Instantiate(target,transform.position,transform.rotation);
                        timer=0;
                }
                timer2+=Time.deltaTime;
                if(timer2>=interval+1) {
                        transform.position=new Vector3(60f,7.5f,Random.Range(-50.0f,40.0f));
                        Instantiate(target,transform.position,transform.rotation);
                        timer2=0;
                }
                timer3+=Time.deltaTime;
                if(timer3>=interval+2) {
                        transform.position=new Vector3(Random.Range(-50.0f,40.0f),7.5f,-60f);
                        Instantiate(target,transform.position,transform.rotation);
                        timer3=0;
                }
                timer4+=Time.deltaTime;
                if(timer4>=interval+3) {
                        transform.position=new Vector3(-60f,7.5f,Random.Range(-50.0f,40.0f));
                        Instantiate(target,transform.position,transform.rotation);
                        timer4=0;
                }
        }
}
