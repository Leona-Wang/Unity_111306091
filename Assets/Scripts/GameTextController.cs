using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextController : MonoBehaviour
{
    //Start is called before the first frame update

    public Text gameText_;
    public void NotYetDisplayed()
	{
        gameText_.text = "Collect All The Shards Then Come Back!";
	}

    public void CollectAllDisplayed()
	{
        gameText_.text = "Well Done!";
	}

    public void ResetText()
	{
        gameText_.text = " ";
    }
    void Start()
    {
        gameText_ = this.GetComponent<Text>();

        gameText_.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
