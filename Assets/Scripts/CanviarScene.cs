using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanviarScene : MonoBehaviour
{
    private bool boto = false;
    public Button botoCanvi;
    // Start is called before the first frame update
    void Start()
    {
        //Button btn1 = botoCanvi.GetComponent<Button>();
        //btn1.onClick.AddListener(botoOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botoOn()
    {
        boto = true;
    }

    void OnTriggerEnter(Collider other)
    {
        //if (boto == true)&& boto == true
        //{
        if (other.tag == "Player" )
            {
                SceneManager.LoadScene("Globos");
            }
        //}
    }
}
