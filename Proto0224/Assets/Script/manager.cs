using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public bool cameraRotate;   //true = X軸、false = Z軸

    public enum Wall
    {
        Top = 0,
        Bottom,
        Left,
        Right
    }
    public int nowTop;  //現在上にある面が何かを保持する

    // Start is called before the first frame update
    void Start()
    {
        cameraRotate = false;
        nowTop = (int)Wall.Top;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetTop(int ChangeTop,bool rollWay)
    {
        switch (rollWay)
        {
            case true:
                switch (ChangeTop)
                {
                    case (int)Wall.Top:
                        nowTop = (int)Wall.Left;
                        break;
                    case (int)Wall.Bottom:
                        nowTop = (int)Wall.Right;
                        break;
                    case (int)Wall.Left:
                        nowTop = (int)Wall.Bottom;
                            break;
                    case (int)Wall.Right:
                        nowTop = (int)Wall.Top;
                        break;
                    default:break;
                }
                break;

            case false:
                switch (ChangeTop)
                {
                    case (int)Wall.Top:
                        nowTop = (int)Wall.Right;
                        break;
                    case (int)Wall.Bottom:
                        nowTop = (int)Wall.Left;
                        break;
                    case (int)Wall.Left:
                        nowTop = (int)Wall.Top;
                        break;
                    case (int)Wall.Right:
                        nowTop = (int)Wall.Bottom;
                        break;
                    default:
                        break;
                }
                break;
                
            default:
                break;

        }
    }//rollWay=trueが左、falseが左

    public void CreatePrefabAsChild(GameObject Parents, GameObject Child, Vector3 Posit = default(Vector3), string tag = default(string))
    {
        Vector3 pos = Posit;
        // プレハブからインスタンスを生成
        GameObject obj = (GameObject)Instantiate(Child, pos, Quaternion.identity);
        // 作成したオブジェクトを子として登録
        obj.transform.parent = Parents.transform;
    }//Parentsで親クラスをGameObjectで直接指定し、Childでプレハブで指定する。

    /*
    public Vector3 MakeVector3(float x,float y,float z)
    {
        return new Vector3(x, y, z);
    }
    */
    public void changeCameraRotate()
    {
        switch (cameraRotate)
        {
            case true:
                cameraRotate = false;
                break;
            case false:
                cameraRotate = true;
                break;
        }
    }


}
