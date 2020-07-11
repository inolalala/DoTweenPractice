using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeValueYourScriptSample : MonoBehaviour
{
    /*
    DOTweenにはDOMoveやDOColorみたいにTransformやMaterialを拡張したメソッドがたくさんあって、
    基本それを使えばいいのだけど(TrailRendererのパラメータを弄るのに便利なやつ、みたいなニッチな物すら用意されている)、
    例えば自作スクリプトの値をtweenさせたい！みたいな事があった時は
    DOTween.To()で実装してあげると良い。
    */
     [Header("Tween結果を見るだけなので触らなくてOK")]
    [SerializeField] private float targetValue;
    void Start()
    {
        DOTween.To(
            () => targetValue,
            (v) => targetValue = v,
            100f,
            5f
        ).SetLoops(-1,LoopType.Yoyo);
    }
}
