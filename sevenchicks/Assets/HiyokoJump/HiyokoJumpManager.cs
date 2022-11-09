using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoJumpManager : MonoBehaviour
{
    private float frame;
    private int count;
    [SerializeField]
    private List<HiyokoJump>  hiyokoJumpList = new List<HiyokoJump>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(HiyokoJump hj in hiyokoJumpList)
        {
            hj.jumpScale = 40;
        }
    }

    // Update is called once per frame
    void Update()
    {
        frame += Time.deltaTime;
        if(frame > 1.0f / 8.0f)
        {
            frame -= 1.0f / 8.0f;

            hiyokoJumpList[count].jump = true;

            count++;

            count %= hiyokoJumpList.Count;
        }
    }
}
