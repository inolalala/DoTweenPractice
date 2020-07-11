using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOColorSample1 : MonoBehaviour
{
    [SerializeField] private Renderer targetRender;
    void Start()
    {
        //DOTweenはコールバックを指定できる。OnCompleteで「終了時に何をするか」を書ける。
        transform.DOMoveX(5f,3f).OnComplete(
            () => {
                Debug.Log("OnComplete!");
                targetRender.material.DOColor(Color.red,3f);//3秒かけて赤くなる
            }
        );
    }
}
