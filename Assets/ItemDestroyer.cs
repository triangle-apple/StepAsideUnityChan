using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //UnityÇøÇ·ÇÒÇÃç¿ïWÇì«Ç›çûÇﬁ
        this.unitychan =GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.z < this.unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
