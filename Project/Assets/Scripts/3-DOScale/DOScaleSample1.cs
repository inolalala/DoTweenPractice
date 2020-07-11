using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOScaleSample1 : MonoBehaviour
{
    [SerializeField] private float duration;//インスペクターで指定してね。(デフォルトでは4秒にしてる)
    [SerializeField] private Ease easeType;//インスペクターで選んでね。(デフォルトではLinearにしてる)
    void Start()
    {
        transform.DOScale(
            new Vector3(5f,5f,5f),
            duration
        )
        .SetLoops(-1,LoopType.Yoyo)//膨らんで、縮む。
        .SetEase(easeType); //イージングをかける。Sphere膨らみ方・縮み方加速度に変化がつく
    }
}
