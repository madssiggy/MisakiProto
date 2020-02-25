using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeControl : MonoBehaviour
{
    GameObject Manager;
    manager script;

    GameObject Field;
    field F_script;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<manager>();

        Field = GameObject.Find("Field");
        F_script = Field.GetComponent<field>();

    }

    // Update is called once per frame
    void Update()
    {
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
            //同じタグが接触したら消えるだけ。switchで分岐を増やせばよい
            switch (this.gameObject.tag) {
                case "BigSlime":
                    Destroy(this.gameObject);
                    Debug.Log("BiggestSlimes Disappear!");
                    break;
                case "MiddleSlime":
                    //おっきくなって上位存在のプレハブ生産
                    Vector3 tmp2= this.gameObject.transform.position;
                    Destroy(this.gameObject);
                    script.CreatePrefabAsChild(Field, (GameObject)Resources.Load("Prefab/BigSlime"),
                        tmp2, "BigSlime");
                    break;
                case "SmallSlime":
                    //おっきくなって上位存在のプレハブ生産
                    Vector3 tmp1 = this.gameObject.transform.position;
                    Destroy(this.gameObject);
                    script.CreatePrefabAsChild(Field, (GameObject)Resources.Load("Prefab/MiddleSlime"),
                        tmp1, "MiddleSlime");
                    break;
                default:break;
            }
          
        }
    }
    }
