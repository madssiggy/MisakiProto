using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadetest2 : MonoBehaviour
{

    public Fade fade;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        fade.FadeOut(1.5f);
    }
}
