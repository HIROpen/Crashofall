using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraAxis : MonoBehaviour {

        public float fRotateSpeed = 100.0f;
        // public Camera mycamera;

        void Update()
        {
                bool isPush = Input.GetMouseButton( 0 );

                if( isPush )
                {
                        Vector3 vec3 = Input.mousePosition;
                        // Vector3 point=Camera.main.ScreenToWorldPoint(vec3);
                        Debug.Log(vec3);

                        if(vec3.x>Screen.width*0.8) {
                                // 移動量
                                float fValue = fRotateSpeed * Time.deltaTime;

                                // 回転
                                transform.Rotate( 0, fValue, 0, Space.World );
                        }else if(vec3.x<Screen.width*0.2) {
                                float fValue = fRotateSpeed * Time.deltaTime;

                                // 回転
                                transform.Rotate( 0, -fValue, 0, Space.World );
                        }
                }
        }
}
