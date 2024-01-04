using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class fearmanager : MonoBehaviour
{

    public Image fearbar;
    public float fearamount = 100f;
    public GameObject pillbottle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (fearamount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);        
        }



        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            LoseFear(20);
        }
    }

    public void LoseFear(float fear)
    {
        fearamount -= fear;
        fearamount = Mathf.Clamp(fearamount, 0, 100);
        fearbar.fillAmount = fearamount / 100f;

    }





}
