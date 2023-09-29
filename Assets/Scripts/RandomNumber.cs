using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    [SerializeField] private List<int> collectNum;
    [ContextMenu("RanNum")]
    private void RanNum()
    {
        int ran = UnityEngine.Random.RandomRange(1,10);
        if (!collectNum.Contains(ran))
        {
            collectNum.Add(ran);
        }
    }
}
