using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ウィンドウを表示する
    /// </summary>
    public void ShowWindow()
    {
        gameObject.SetActive(true);
    }

    /// <summary>
    /// ウィンドウを非表示にする
    /// </summary>
    public void HideWindow()
    {
        gameObject.SetActive(false);
    }
}
