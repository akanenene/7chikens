using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoJump : MonoBehaviour
{
    private float frame;
    public bool jump;
    public float jumpScale;
    private Vector3 defaultpos;
    // Start is called before the first frame update
    void Start()
    {
        frame = 0.0f;
        jump = false;
        defaultpos = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (jump == true)
        {
            frame += Time.deltaTime;
            float per = frame / 0.25f;
            float plusY = Mathf.Sin(per * Mathf.PI);
            this.transform.localPosition = defaultpos + new Vector3(0, plusY * jumpScale, 0);
            if (per >= 1)
            {
                frame = 0.0f;
                jump = false;
                this.transform.localPosition = defaultpos;
            }
        }
    }
}
