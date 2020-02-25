using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class field : MonoBehaviour
{
    GameObject Center;//Fieldの親のCenter
    GameObject Manager;//各値が入ってるマネージャーを呼び出す
    manager script;//マネージャーのスクリプト
    Vector3 targetPos;//

    [SerializeField, PersistentAmongPlayMode] public int AppearSlimeCount;//使うスライムの数


    //[System.Serializable]
    //public struct SlimeAttriBute
    //{
    [SerializeField, PersistentAmongPlayMode] public Vector3[] SpawnSlimePos;//スライムごとの位置
    [SerializeField, PersistentAmongPlayMode] public string[] TakenTag;//スライムごとのタグ

    //}
    //[SerializeField, PersistentAmongPlayMode] SlimeAttriBute[] slime;



    // Start is called before the first frame update
    void Start()
    {
       

       Center = GameObject.Find("FieldCenter");
        targetPos = Center.transform.position;

        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<manager>();

     
        for(int i=0;i<AppearSlimeCount;i++)
        script.CreatePrefabAsChild(GameObject.Find("Field"), (GameObject)Resources.Load("Prefab/SmallSlime"),SpawnSlimePos[i],TakenTag[i]);
      
    }

    // Update is called once per frame
    void Update()
    {

        // キーを押している間
        if (Input.anyKey) {
            // 移動量
            float InputZ = 0f;//Input.GetAxis("Mouse X");
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {

                script.SetTop(script.nowTop, true);
                InputZ = -90f;

            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                script.SetTop(script.nowTop, false);
                InputZ = 90f;
        }
            //           float mouseInputY = Input.GetAxis("Mouse Y");
            // targetの位置のZ軸を中心に、回転（公転）する
            transform.RotateAround(targetPos, Vector3.forward, InputZ);
            }
        }


}
