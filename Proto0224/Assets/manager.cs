using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public enum Wall {
        Top,Bottom,Left,Right,
    }
    public int nowTop;
    // Start is called before the first frame update
    void Start()
    {
        nowTop = (int)Wall.Top;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetTop(int ChangeTop,bool rollWay)
    {
        switch (rollWay) {

            case true:
                switch (ChangeTop) {
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
                switch (ChangeTop) {
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

        }
    }//rollWay=trueが左、falseが左

  public  void CreatePrefabAsChild(GameObject Parents,GameObject Child,Vector3 Posit=default(Vector3),string tag=default(string))
    {
        GameObject prefab = Child;// (GameObject)Resources.Load("Prefabs/Effects/Prefab名");

        Vector3 pos = Posit;
        //Vector3 pos = Vector3.Scale(Parents.transform.position,Posit);
        //Vector3.Normalize(pos);

        // プレハブからインスタンスを生成
        GameObject obj = (GameObject)Instantiate(prefab, pos, Quaternion.identity);
        obj.tag = tag;
        // 作成したオブジェクトを子として登録
        obj.transform.parent = Parents.transform;
    }//Parentsで親クラスをGameObjectで直接指定し、Childでプレハブで指定する。
    public Vector3 MakeVector3(float x,float y,float z)
    {
        return new Vector3(x, y, z);
    }
}
