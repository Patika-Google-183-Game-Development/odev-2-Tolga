using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimationCurveDemo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AnimationCurve _animationCurve;
    [SerializeField] float animTime;

    GameObject testObject;

    public event Action<GameObject> OnAnimationFinished;
    
    void Start()
    {
        MathFTest();
        StartCoroutine(AnimationCurveCor());
    }

    IEnumerator AnimationCurveCor()
    {
        float currentTime = 0f;
        _animationCurve = new AnimationCurve(new Keyframe(0, transform.position.x), new Keyframe(0.5f, transform.position.x + 10), new Keyframe(1f, transform.position.x + 20));

        _animationCurve.SmoothTangents(0, 0.25f);
        _animationCurve.SmoothTangents(1, 1f);
        _animationCurve.SmoothTangents(2, 0.25f);


        while (currentTime < animTime)
        {
            transform.position = new Vector2(_animationCurve.Evaluate(currentTime / animTime),transform.position.y);
            currentTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        OnAnimationFinished?.Invoke(testObject);
       

    }

    void MathFTest()
    {

        float a = 1.2f;

        float b = 1.2000000000081f;

        if (Mathf.Approximately(a, b)) ;
    }
}
