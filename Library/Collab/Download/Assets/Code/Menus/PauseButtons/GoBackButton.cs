using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackButton : MonoBehaviour {

    public Button goBack;

    void Start () {
        Button btn = goBack.GetComponent<Button>();
        btn.onClick.AddListener(GoBack);
    }

    
	void Update (){

    }

    public void GoBack()
    {
        GameObject.FindObjectOfType<ControlsMenu>().Die();
    }
}
