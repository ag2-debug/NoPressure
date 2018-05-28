using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsButton : MonoBehaviour {

    public Button controlButton;
    public static Transform Canvas { get; set; }


    void Start () {
        Button btn = controlButton.GetComponent<Button>();
        btn.onClick.AddListener(ControlMenu);
    }

    private void Awake()
    {
        Canvas = GameObject.Find("Canvas").transform;
    }

    void Update () {
        
    }

    public void ControlMenu()
    {
        var menu = (GameObject)Object.Instantiate(Resources.Load("Menus/ControlMenu"));
        menu.transform.SetParent(Canvas, false);
    }
}
