using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveScript : MonoBehaviour
{
    Gamecontroller gameController;
    public float speed = 0.0f;
    // Start is called before the first frame update 
    void Start()
    {
        gameController = GameObject.Find("Main Camera").GetComponent<Gamecontroller>();

    }

    // Update is called once per frame 
    void Update()
    {

        float x = Input.GetAxis("Horizontal"); //1 
        float z = Input.GetAxis("Vertical"); //2 

        Vector3 move = (transform.right * x + transform.forward * z) * speed * Time.deltaTime;
        transform.position += move;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube")
        {
            print("We collided with the cube");
            Destroy(other.gameObject);
            gameController.IncreaseScore(100);
        }
    }



}