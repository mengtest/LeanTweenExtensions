using System;
using UnityEngine;

/// <summary>
/// LeanVirtualClass.
/// this class is leantween virtual suports.
/// </summary>
public static class LeanVirtual
{
	public static LTDescr DelayedCall(float delayTime, Action callback) { return LeanTween.delayedCall(LeanTween.tweenEmpty, delayTime, callback); }
	public static LTDescr DelayedCall(float delayTime, Action<object> callback) { return LeanTween.delayedCall(LeanTween.tweenEmpty, delayTime, callback); }

	public static LTDescr Value(float from, float to, float time) { return LeanTween.value(LeanTween.tweenEmpty, from, to, time); }
	public static LTDescr Value(Vector2 from, Vector2 to, float time) { return LeanTween.value(LeanTween.tweenEmpty, from, to, time); }
	public static LTDescr Value(Vector3 from, Vector3 to, float time) { return LeanTween.value(LeanTween.tweenEmpty, from, to, time); }
	public static LTDescr Value(Color from, Color to, float time) { return LeanTween.value(LeanTween.tweenEmpty, from, to, time); }
	public static LTDescr Value(Action<float> callOnUpdate, float from, float to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdate, from, to, time); }
	public static LTDescr Value(Action<float, float> callOnUpdateRatio, float from, float to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdateRatio, from, to, time); }
	public static LTDescr Value(Action<Color> callOnUpdate, Color from, Color to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdate, from, to, time); }
	public static LTDescr Value(Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdate, from, to, time); }
	public static LTDescr Value(Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdate, from, to, time); }
	public static LTDescr Value(Action<float, object> callOnUpdate, float from, float to, float time) { return LeanTween.value(LeanTween.tweenEmpty, callOnUpdate, from, to, time); }
}