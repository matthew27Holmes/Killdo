using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManger : MonoBehaviour {
    // split screen at game start for number of players 
    // then set each cameras children
    private List<GameObject> cams = new List<GameObject>();
    public GameObject PlayersManger;
    public GameObject camPrefab;
    

    public void cerateCamears(int playerNum)
    {
        float x =-0.5f;
        float y =-0.5f;
        for(int i =0; i < playerNum;i++)
        {
            GameObject newCam = Instantiate(camPrefab, transform.position, Quaternion.identity);
            newCam.transform.parent = transform;
            cams.Add(newCam);
            newCam.GetComponent<cameraFollow>().player = PlayersManger.transform.GetChild(i).gameObject;
            //postion cam
            Camera cam = newCam.GetComponent<Camera>();
            cam.rect = new Rect(x, y,1.0f,1.0f);
            x *= -1;
            if (x < 0.5)
            {
                x = -0.5f;
                y *= -1;
            }
        }
    }
}
