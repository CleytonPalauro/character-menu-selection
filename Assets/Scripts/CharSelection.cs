using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelection : MonoBehaviour
{
    public Transform[] posList = new Transform[0];

    public Transform selectorOne;

    public Transform selectorTwo;

    private int oneIndex = 0;

    private int twoIndex = 1;

    void Start()
    {
        selectorOne.position = posList[oneIndex].position;
        selectorTwo.transform.position = posList[twoIndex].transform.position;
    }

    void Update()
    {
        // Selector One Controller.
        if (Input.GetButtonDown("Horizontal"))
        {
            int moveH = (int)Input.GetAxisRaw("Horizontal") * 2;

            if (oneIndex + moveH >= 0 && oneIndex + moveH < posList.Length)
            {
                oneIndex = oneIndex + moveH;
                selectorOne.transform.position = posList[oneIndex].transform.position;
            }
        }
        else if (Input.GetButtonDown("Vertical"))
        {
            int moveV = (int)Input.GetAxisRaw("Vertical") * -1;

            if ((oneIndex % 2) == 1 && moveV < 0 || (oneIndex % 2) == 0 && moveV > 0)
            {
                if (oneIndex + moveV >= 0 && oneIndex + moveV < posList.Length)
                {
                    oneIndex = oneIndex + moveV;
                    selectorOne.transform.position = posList[oneIndex].transform.position;
                }
            }
        }

        // Selector Two Controller.
        if (Input.GetButtonDown("HorizontalTwo"))
        {
            int moveH = (int)Input.GetAxisRaw("HorizontalTwo") * 2;

            if (twoIndex + moveH >= 0 && twoIndex + moveH < posList.Length)
            {
                twoIndex = twoIndex + moveH;
                selectorTwo.transform.position = posList[twoIndex].transform.position;
            }
        }
        else if (Input.GetButtonDown("VerticalTwo"))
        {
            int moveV = (int)Input.GetAxisRaw("VerticalTwo") * -1;

            if ((twoIndex % 2) == 1 && moveV < 0 || (twoIndex % 2) == 0 && moveV > 0)
            {
                if (twoIndex + moveV >= 0 && twoIndex + moveV < posList.Length)
                {
                    twoIndex = twoIndex + moveV;
                    selectorTwo.transform.position = posList[twoIndex].transform.position;
                }
            }
        }
    }
}
