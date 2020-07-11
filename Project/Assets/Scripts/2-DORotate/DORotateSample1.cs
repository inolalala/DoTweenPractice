using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DORotateSample1 : MonoBehaviour
{
    void Start()
    {
        transform.DORotate(
            new Vector3(60f,60f,60f),//目的のパラメータ
            3f//かける秒数
        )
        .SetLoops(-1,LoopType.Yoyo);//ヨーヨーのような行ったり来たりの繰り返し
    }
}
