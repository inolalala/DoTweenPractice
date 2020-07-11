using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOMoveSample1 : MonoBehaviour
{
    void Start()
    {
        transform.DOMove(
            new Vector3(5f,0f,0f),//目的のパラメータ
            5f//かける秒数
        )
        .SetLoops(-1);//繰り返し(引数に繰り返す回数をいれる。-1で無限ループ)
    }

}
