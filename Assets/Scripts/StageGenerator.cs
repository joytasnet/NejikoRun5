using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    const int StageChipSize = 30;
    //ネジコのindex
    int charIndex=0;
    public Transform character;
    public List<GameObject> stageList = new List<GameObject>();

    void Update()
    {
        int nowIndex = (int)(character.position.z / StageChipSize);
        if (nowIndex  > charIndex)
        {
            charIndex++;
            GameObject Stage = stageList[0];
            stageList.RemoveAt(0);
            Stage.transform.position = new Vector3(0, 0, (charIndex+5)*StageChipSize);
            stageList.Add(Stage);
        }
    }
}
