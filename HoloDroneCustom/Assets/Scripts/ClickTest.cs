using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour, IInputClickHandler{

    public GameObject throwBall;
    public GameObject ballParent;
    public GameObject camera;

    public GazeManager gaze;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }


    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("クリック");
        //Vector3 ballParentPos = ballParent.transform.position;

        ////  インスタンス生成
        //var ball = Instantiate(throwBall, ballParentPos, Quaternion.identity);

        //float cameraRotationY = camera.transform.eulerAngles.y;
        //if(cameraRotationY > 180)
        //{
        //    //cameraRotationY = 180 - cameraRotationY;
        //}
        //Debug.Log("角度：" + cameraRotationY);

        //// 角度から力を計算
        //Vector3 throwBallPow = new Vector3(
        //    1 * Mathf.Sin(cameraRotationY * Mathf.Deg2Rad), 100f, 1  * Mathf.Cos(cameraRotationY * Mathf.Deg2Rad)
        //    );
        //Debug.Log("xpow:" + throwBallPow.x + " zpow:" + throwBallPow.z);

        //ball.GetComponent<Rigidbody>().AddForce(camera.transform.forward * 150);
        //ball.GetComponent<Rigidbody>().AddForce(camera.transform.up * 50);
    }
}
