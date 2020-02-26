using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeControl : MonoBehaviour
{
    GameObject Manager;
    manager script;

    GameObject Field;
    field F_script;
    bool isMove;
    // Start is called before the first frame update
    void Awake()
    {
        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<manager>();

        Field = transform.parent.gameObject;//GameObject.Find("Field");
        F_script = Field.GetComponent<field>();
        Physics.gravity = new Vector3(0, 0, 0);
        isMove = false;
    }
   

    // Update is called once per frame
    void Update()
    {
        if (isMove == false&&(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))) {
            isMove = true;
            Physics.gravity = new Vector3(0, -10, 0);
        }
        switch (script.nowTop) {
            case (int)manager.Wall.Top:
                //処理
                break;
            case (int)manager.Wall.Bottom:
                //処理
                break;
            case (int)manager.Wall.Left:
                //処理
                break;
            case (int)manager.Wall.Right:
                //処理
                break;

            default:break;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == this.gameObject.tag) {


            switch (this.gameObject.tag) {
                case "BigSlime":
                    Destroy(this.gameObject);
                    Debug.Log("BiggestSlimes Disappear!");
                    break;
                case "MiddleSlime":
                    //おっきくなって上位存在のプレハブ生産
                    Vector3 tmp = this.gameObject.transform.position;//生まれる位置（＝変更前の位置)取得
                    GameObject OYA = transform.parent.gameObject;//親クラス取得
                    Destroy(this.gameObject);
                    script.CreatePrefabAsChild(OYA, (GameObject)Resources.Load("Prefab/BigSlime"),
                        tmp, "BigSlime");
                    break;
                case "SmallSlime":
                    //おっきくなって上位存在のプレハブ生産    
                    Vector3 tmp2 = this.gameObject.transform.position;//生まれる位置（＝変更前の位置)取得
                    GameObject OYA2 = transform.parent.gameObject;//親クラス取得
                    Destroy(this.gameObject);
                    GameObject G = (GameObject)Resources.Load("Prefab/MiddleSlime");
                    script.CreatePrefabAsChild(OYA2,G,// (GameObject)Resources.Load("Prefab/MiddleSlime")
                        tmp2, "MiddleSlime");
                    break;
                default:break;
            }
          
        }
    }
    }
