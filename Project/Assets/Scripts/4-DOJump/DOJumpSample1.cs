using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOJumpSample1 : MonoBehaviour
{
    [SerializeField] private Vector3 endValue;
    [SerializeField] private float jumpPower;
    [SerializeField] private float duration;
    void Start()
    {
        transform.DOMove(endValue,duration).SetLoops(-1);

        //DOLocalXXXXXはローカル座標バージョン
        //DOMoveなどにもLocalバージョンが存在する。
        transform.DOLocalJump(
            endValue,//最終的な地点。普通のジャンプするイメージなら(0f,0f,0f)で良い。
            jumpPower,//ジャンプの高さ
            3,//回数
            duration//かける秒数
        )
        .SetLoops(-1);//1秒待って
    }
}
