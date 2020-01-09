using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision objectInfo)
    {
        if (objectInfo.collider.tag == "car1")
        {
            SceneManager.LoadScene("scene2-night");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
