using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadetest: MonoBehaviour
{
    [SerializeField]

    Fade fade = null;


    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}
    
    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
           

    //   }
    //}

    public void FadeOut()
    {
        //fade.FadeIn (1, () => {

        //	fade.FadeOut (1);

        //});

        fade.FadeIn(1, () =>
        {
            Invoke("ChangeScene", 0.5f);
        });
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("EASY+");
    }


}
