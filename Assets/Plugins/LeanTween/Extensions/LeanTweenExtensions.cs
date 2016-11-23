using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// LeanTweenExtensionsClass
/// this class is leantween extension class.
/// </summary>
public static class LeanTweenExtensions
{
	#region LTDescr
	public static void LTCancel(this LTDescr self) { LeanTween.cancel(self.trans.gameObject); }
	public static void LTCancel(this LTDescr self, bool callOnComplete) { LeanTween.cancel(self.trans.gameObject, callOnComplete); }

	public static void LTPause(this LTDescr self) { LeanTween.pause(self.trans.gameObject); }
	public static void LTResume(this LTDescr self) { LeanTween.resume(self.trans.gameObject); }

	public static bool LTIsTweening(this LTDescr self) { return LeanTween.isTweening(self.trans.gameObject); }

	public static LTDescr LTAlpha(this LTDescr self, float to, float time) { return LeanTween.alpha(self.trans.gameObject, to, time); }
	public static LTDescr LTAlphaVertex(this LTDescr self, float to, float time) { return LeanTween.alphaVertex(self.trans.gameObject, to, time); }
	public static LTDescr LTColor(this LTDescr self, Color to, float time) { return LeanTween.color(self.trans.gameObject, to, time); }

	public static LTDescr LTDelayedCall(this LTDescr self, float delayTime, Action callback) { return LeanTween.delayedCall(self.trans.gameObject, delayTime, callback); }
	public static LTDescr LTDelayedCall(this LTDescr self, float delayTime, Action<object> callback) { return LeanTween.delayedCall(self.trans.gameObject, delayTime, callback); }


	public static LTDescr LTMove(this LTDescr self, Transform to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMove(this LTDescr self, Vector3 to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMove(this LTDescr self, Vector2 to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMove(this LTDescr self, Vector3[] to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMove(this LTDescr self, LTBezierPath to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMove(this LTDescr self, LTSpline to, float time) { return LeanTween.move(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveX(this LTDescr self, float to, float time) { return LeanTween.moveX(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveY(this LTDescr self, float to, float time) { return LeanTween.moveY(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveZ(this LTDescr self, float to, float time) { return LeanTween.moveZ(self.trans.gameObject, to, time); }

	public static LTDescr LTMoveLocal(this LTDescr self, Vector3 to, float time) { return LeanTween.moveLocal(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this LTDescr self, Vector3[] to, float time) { return LeanTween.moveLocal(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this LTDescr self, LTBezierPath to, float time) { return LeanTween.moveLocal(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this LTDescr self, LTSpline to, float time) { return LeanTween.moveLocal(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocalX(this LTDescr self, float to, float time) { return LeanTween.moveLocalX(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocalY(this LTDescr self, float to, float time) { return LeanTween.moveLocalY(self.trans.gameObject, to, time); }
	public static LTDescr LTMoveLocalZ(this LTDescr self, float to, float time) { return LeanTween.moveLocalZ(self.trans.gameObject, to, time); }

	public static LTDescr LTRotate(this LTDescr self, Vector3 to, float time) { return LeanTween.rotate(self.trans.gameObject, to, time); }
	public static LTDescr LTRotateLocal(this LTDescr self, Vector3 to, float time) { return LeanTween.rotateLocal(self.trans.gameObject, to, time); }
	public static LTDescr LTRotateX(this LTDescr self, float to, float time) { return LeanTween.rotateX(self.trans.gameObject, to, time); }
	public static LTDescr LTRotateY(this LTDescr self, float to, float time) { return LeanTween.rotateY(self.trans.gameObject, to, time); }
	public static LTDescr LTRotateZ(this LTDescr self, float to, float time) { return LeanTween.rotateZ(self.trans.gameObject, to, time); }
	public static LTDescr LTRotateAround(this LTDescr self, Vector3 axis, float add, float time) { return LeanTween.rotateAround(self.trans.gameObject, axis, add, time); }
	public static LTDescr LTRotateAroundLocal(this LTDescr self, Vector3 axis, float add, float time) { return LeanTween.rotateAroundLocal(self.trans.gameObject, axis, add, time); }

	public static LTDescr LTScale(this LTDescr self, Vector3 to, float time) { return LeanTween.scale(self.trans.gameObject, to, time); }
	public static LTDescr LTScaleX(this LTDescr self, float to, float time) { return LeanTween.scaleX(self.trans.gameObject, to, time); }
	public static LTDescr LTScaleY(this LTDescr self, float to, float time) { return LeanTween.scaleY(self.trans.gameObject, to, time); }
	public static LTDescr LTScaleZ(this LTDescr self, float to, float time) { return LeanTween.scaleZ(self.trans.gameObject, to, time); }

	public static LTDescr LTValue(this LTDescr self, float from, float to, float time) { return LeanTween.value(self.trans.gameObject, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Vector2 from, Vector2 to, float time) { return LeanTween.value(self.trans.gameObject, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Vector3 from, Vector3 to, float time) { return LeanTween.value(self.trans.gameObject, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Color from, Color to, float time) { return LeanTween.value(self.trans.gameObject, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<float> callOnUpdate, float from, float to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<float, float> callOnUpdateRatio, float from, float to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdateRatio, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<Color> callOnUpdate, Color from, Color to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this LTDescr self, Action<float, object> callOnUpdate, float from, float to, float time) { return LeanTween.value(self.trans.gameObject, callOnUpdate, from, to, time); }

	public static LTDescr LTDelayedSound(this LTDescr self, AudioClip audio, Vector3 pos, float volume) { return LeanTween.delayedSound(self.trans.gameObject, audio, pos, volume); }
	#endregion

	#region Transform
	public static void LTCancel(this Transform self) { LeanTween.cancel(self.gameObject); }
	public static void LTCancel(this Transform self, bool callOnComplete) { LeanTween.cancel(self.gameObject, callOnComplete); }

	public static void LTPause(this Transform self) { LeanTween.pause(self.gameObject); }
	public static void LTResume(this Transform self) { LeanTween.resume(self.gameObject); }

	public static bool LTIsTweening(this Transform self) { return LeanTween.isTweening(self.gameObject); }

	public static LTDescr LTAlpha(this Transform self, float to, float time) { return LeanTween.alpha(self.gameObject, to, time); }
	public static LTDescr LTAlphaVertex(this Transform self, float to, float time) { return LeanTween.alphaVertex(self.gameObject, to, time); }
	public static LTDescr LTColor(this Transform self, Color to, float time) { return LeanTween.color(self.gameObject, to, time); }

	public static LTDescr LTDelayedCall(this Transform self, float delayTime, Action callback) { return LeanTween.delayedCall(self.gameObject, delayTime, callback); }
	public static LTDescr LTDelayedCall(this Transform self, float delayTime, Action<object> callback) { return LeanTween.delayedCall(self.gameObject, delayTime, callback); }

	public static LTDescr LTMove(this Transform self, Transform to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMove(this Transform self, Vector3 to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMove(this Transform self, Vector2 to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMove(this Transform self, Vector3[] to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMove(this Transform self, LTBezierPath to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMove(this Transform self, LTSpline to, float time) { return LeanTween.move(self.gameObject, to, time); }
	public static LTDescr LTMoveX(this Transform self, float to, float time) { return LeanTween.moveX(self.gameObject, to, time); }
	public static LTDescr LTMoveY(this Transform self, float to, float time) { return LeanTween.moveY(self.gameObject, to, time); }
	public static LTDescr LTMoveZ(this Transform self, float to, float time) { return LeanTween.moveZ(self.gameObject, to, time); }

	public static LTDescr LTMoveLocal(this Transform self, Vector3 to, float time) { return LeanTween.moveLocal(self.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this Transform self, Vector3[] to, float time) { return LeanTween.moveLocal(self.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this Transform self, LTBezierPath to, float time) { return LeanTween.moveLocal(self.gameObject, to, time); }
	public static LTDescr LTMoveLocal(this Transform self, LTSpline to, float time) { return LeanTween.moveLocal(self.gameObject, to, time); }
	public static LTDescr LTMoveLocalX(this Transform self, float to, float time) { return LeanTween.moveLocalX(self.gameObject, to, time); }
	public static LTDescr LTMoveLocalY(this Transform self, float to, float time) { return LeanTween.moveLocalY(self.gameObject, to, time); }
	public static LTDescr LTMoveLocalZ(this Transform self, float to, float time) { return LeanTween.moveLocalZ(self.gameObject, to, time); }

	public static LTDescr LTRotate(this Transform self, Vector3 to, float time) { return LeanTween.rotate(self.gameObject, to, time); }
	public static LTDescr LTRotateLocal(this Transform self, Vector3 to, float time) { return LeanTween.rotateLocal(self.gameObject, to, time); }
	public static LTDescr LTRotateX(this Transform self, float to, float time) { return LeanTween.rotateX(self.gameObject, to, time); }
	public static LTDescr LTRotateY(this Transform self, float to, float time) { return LeanTween.rotateY(self.gameObject, to, time); }
	public static LTDescr LTRotateZ(this Transform self, float to, float time) { return LeanTween.rotateZ(self.gameObject, to, time); }
	public static LTDescr LTRotateAround(this Transform self, Vector3 axis, float add, float time) { return LeanTween.rotateAround(self.gameObject, axis, add, time); }
	public static LTDescr LTRotateAroundLocal(this Transform self, Vector3 axis, float add, float time) { return LeanTween.rotateAroundLocal(self.gameObject, axis, add, time); }

	public static LTDescr LTScale(this Transform self, Vector3 to, float time) { return LeanTween.scale(self.gameObject, to, time); }
	public static LTDescr LTScaleX(this Transform self, float to, float time) { return LeanTween.scaleX(self.gameObject, to, time); }
	public static LTDescr LTScaleY(this Transform self, float to, float time) { return LeanTween.scaleY(self.gameObject, to, time); }
	public static LTDescr LTScaleZ(this Transform self, float to, float time) { return LeanTween.scaleZ(self.gameObject, to, time); }

	public static LTDescr LTValue(this Transform self, float from, float to, float time) { return LeanTween.value(self.gameObject, from, to, time); }
	public static LTDescr LTValue(this Transform self, Vector2 from, Vector2 to, float time) { return LeanTween.value(self.gameObject, from, to, time); }
	public static LTDescr LTValue(this Transform self, Vector3 from, Vector3 to, float time) { return LeanTween.value(self.gameObject, from, to, time); }
	public static LTDescr LTValue(this Transform self, Color from, Color to, float time) { return LeanTween.value(self.gameObject, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<float> callOnUpdate, float from, float to, float time) { return LeanTween.value(self.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<float, float> callOnUpdateRatio, float from, float to, float time) { return LeanTween.value(self.gameObject, callOnUpdateRatio, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<Color> callOnUpdate, Color from, Color to, float time) { return LeanTween.value(self.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { return LeanTween.value(self.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { return LeanTween.value(self.gameObject, callOnUpdate, from, to, time); }
	public static LTDescr LTValue(this Transform self, Action<float, object> callOnUpdate, float from, float to, float time) { return LeanTween.value(self.gameObject, callOnUpdate, from, to, time); }

	public static LTDescr LTDelayedSound(this Transform self, AudioClip audio, Vector3 pos, float volume) { return LeanTween.delayedSound(self.gameObject, audio, pos, volume); }
	#endregion

	#region RectTransform
	public static LTDescr LTPlay(this RectTransform rectTransform, UnityEngine.Sprite[] sprites) { return LeanTween.play(rectTransform, sprites); }
	public static LTDescr LTTextAlpha(this RectTransform rectTransform, float to, float time) { return LeanTween.textAlpha(rectTransform, to, time); }
	public static LTDescr LTTextColor(this RectTransform rectTransform, Color to, float time) { return LeanTween.textColor(rectTransform, to, time); }
	public static LTDescr LTMove(this RectTransform rectTrans, Vector3 to, float time) { return LeanTween.move(rectTrans, to, time); }
	public static LTDescr LTMoveX(this RectTransform rectTrans, float to, float time) { return LeanTween.moveX(rectTrans, to, time); }
	public static LTDescr LTMoveY(this RectTransform rectTrans, float to, float time) { return LeanTween.moveY(rectTrans, to, time); }
	public static LTDescr LTMoveZ(this RectTransform rectTrans, float to, float time) { return LeanTween.moveZ(rectTrans, to, time); }
	public static LTDescr LTRotate(this RectTransform rectTrans, float to, float time) { return LeanTween.rotate(rectTrans, to, time); }
	public static LTDescr LTRotateAround(this RectTransform rectTrans, Vector3 axis, float to, float time) { return LeanTween.rotateAround(rectTrans, axis, to, time); }
	public static LTDescr LTRotateAroundLocal(this RectTransform rectTrans, Vector3 axis, float to, float time) { return LeanTween.rotateAroundLocal(rectTrans, axis, to, time); }
	public static LTDescr LTScale(this RectTransform rectTrans, Vector3 to, float time) { return LeanTween.scale(rectTrans, to, time); }
	public static LTDescr LTAlpha(this RectTransform rectTrans, float to, float time) { return LeanTween.alpha(rectTrans, to, time); }
	public static LTDescr LTColor(this RectTransform rectTrans, Color to, float time) { return LeanTween.color(rectTrans, to, time); }
	public static LTDescr LTAnchorMax(this RectTransform self, Vector2 to, float time) { return self.LTValue(self.anchorMax, to, time).setOnUpdate((Vector2 x) => self.anchorMax = x); }
	public static LTDescr LTAnchorMin(this RectTransform self, Vector2 to, float time) { return self.LTValue(self.anchorMin, to, time).setOnUpdate((Vector2 x) => self.anchorMin = x); }
	public static LTDescr LTAnchoredPosition(this RectTransform self, Vector2 to, float time) { return self.LTValue(self.anchoredPosition, to, time).setOnUpdate((Vector2 x) => self.anchoredPosition = x); }
	public static LTDescr LTAnchoredPositionX(this RectTransform self, float to, float time) { return self.LTAnchoredPosition(new Vector2(to, self.anchoredPosition.y), time); }
	public static LTDescr LTAnchoredPositionY(this RectTransform self, float to, float time) { return self.LTAnchoredPosition(new Vector2(self.anchoredPosition.x, to), time); }
	public static LTDescr LTAnchoredPosition3D(this RectTransform self, Vector3 to, float time) { return self.LTValue(self.anchoredPosition3D, to, time).setOnUpdate((Vector3 x) => self.anchoredPosition3D = x); }
	public static LTDescr LTPivot(this RectTransform self, Vector2 to, float time) { return self.transform.LTValue(self.pivot, to, time).setOnUpdate((Vector2 x) => self.pivot = x); }
	public static LTDescr LTPivotX(this RectTransform self, float to, float time) { return self.LTPivot(new Vector2(to, self.pivot.y), time); }
	public static LTDescr LTPivotY(this RectTransform self, float to, float time) { return self.LTPivot(new Vector2(self.pivot.x, to), time); }
	public static LTDescr LTSizeDelta(this RectTransform self, Vector2 to, float time) { return self.LTValue(self.sizeDelta, to, time).setOnUpdate((Vector2 x) => self.sizeDelta = x); }
	#endregion

	#region AudioSource
	public static LTDescr LTVolume(this AudioSource self, float to, float time) { return self.transform.LTValue(self.volume, to, time).setOnUpdate((float x) => self.volume = x); }
	public static LTDescr LTPitch(this AudioSource self, float to, float time) { return self.transform.LTValue(self.pitch, to, time).setOnUpdate((float x) => self.pitch = x); }
	#endregion

	#region Camera
	public static LTDescr LTAspect(this Camera self, float to, float time) { return self.transform.LTValue(self.aspect, to, time).setOnUpdate((float x) => self.aspect = x); }
	public static LTDescr LTBackgroundColor(this Camera self, Color to, float time) { return self.transform.LTValue(self.backgroundColor, to, time).setOnUpdate((Color x) => self.backgroundColor = x); }
	public static LTDescr LTFarClipPlane(this Camera self, float to, float time) { return self.transform.LTValue(self.farClipPlane, to, time).setOnUpdate((float x) => self.farClipPlane = x); }
	public static LTDescr LTFieldOfView(this Camera self, float to, float time) { return self.transform.LTValue(self.fieldOfView, to, time).setOnUpdate((float x) => self.fieldOfView = x); }
	public static LTDescr LTNearClipPlane(this Camera self, float to, float time) { return self.transform.LTValue(self.nearClipPlane, to, time).setOnUpdate((float x) => self.nearClipPlane = x); }
	public static LTDescr LTOrthographicSize(this Camera self, float to, float time) { return self.transform.LTValue(self.orthographicSize, to, time).setOnUpdate((float x) => self.orthographicSize = x); }
	#endregion

	#region Light
	public static LTDescr LTColor(this Light self, Color to, float time) { return self.transform.LTValue(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTIntensity(this Light self, float to, float time) { return self.transform.LTValue(self.intensity, to, time).setOnUpdate((float x) => self.intensity = x); }
	public static LTDescr LTShadowStrength(this Light self, float to, float time) { return self.transform.LTValue(self.shadowStrength, to, time).setOnUpdate((float x) => self.shadowStrength = x); }
	#endregion

	#region Material
	public static LTDescr LTColor(this Material self, Color to, float time) { return LeanVirtual.Value(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTColor(this Material self, string property, Color to, float time)
	{
		int id = Shader.PropertyToID(property);
		return LeanVirtual.Value(self.GetColor(id), to, time)
			.setOnUpdate((Color x) => self.SetColor(id, x));
	}
	public static LTDescr LTAlpha(this Material self, float to, float time) { return self.LTColor(new Color(self.color.r, self.color.g, self.color.b, to), time); }
	public static LTDescr LTAlpha(this Material self, string property, float to, float time)
	{
		int id = Shader.PropertyToID(property);
		Color c = self.GetColor(id);
		return self.LTColor(property, new Color(c.r, c.g, c.b, to), time);
	}
	public static LTDescr LTFloat(this Material self, string property, float to, float time)
	{
		int id = Shader.PropertyToID(property);
		return LeanVirtual.Value(self.GetFloat(id), to, time)
			.setOnUpdate((float x) => self.SetFloat(id, x));
	}
	public static LTDescr LTOffset(this Material self, Vector2 to, float time) { return LeanVirtual.Value(self.mainTextureOffset, to, time).setOnUpdate((Vector2 x) => self.mainTextureOffset = x); }
	public static LTDescr LTOffset(this Material self, string property, Vector2 to, float time) { return LeanVirtual.Value(self.GetTextureOffset(property), to, time).setOnUpdate((Vector2 x) => self.SetTextureOffset(property, to)); }
	public static LTDescr LTScale(this Material self, Vector2 to, float time) { return LeanVirtual.Value(self.mainTextureScale, to, time).setOnUpdate((Vector2 x) => self.mainTextureScale = x); }
	public static LTDescr LTScale(this Material self, string property, Vector2 to, float time) { return LeanVirtual.Value(self.GetTextureScale(property), to, time).setOnUpdate((Vector2 x) => self.SetTextureOffset(property, x)); }
	#endregion

	#region SpriteRenderer
	public static LTDescr LTColor(this SpriteRenderer self, Color to, float time) { return self.transform.LTValue(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTAlpha(this SpriteRenderer self, float to, float time) { return self.LTColor(new Color(self.color.r, self.color.g, self.color.b, to), time).setOnUpdate((Color x) => self.color = x); }
	#endregion

	#region TrailRenderer
	public static LTDescr LTResize(this TrailRenderer self, float toStart, float toEnd, float time)
	{
		return self.transform.LTValue(new Vector2(self.startWidth, self.endWidth), new Vector2(toStart, toEnd), time)
			.setOnUpdate((Vector2 x) =>
			{
				self.startWidth = x.x;
				self.endWidth = x.y;
			});
	}
	public static LTDescr LTTime(this TrailRenderer self, float to, float time) { return self.transform.LTValue(self.time, to, time).setOnUpdate((float x) => self.time = x); }
	#endregion

	#region CanvasGroup
	public static LTDescr LTAlpha(this CanvasGroup self, float to, float time) { return self.transform.LTValue(self.alpha, to, time).setOnUpdate((float x) => self.alpha = x); }
	#endregion

	#region Graphic
	public static LTDescr LTColor(this Graphic self, Color to, float time) { return self.transform.LTValue(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTAlpha(this Graphic self, float to, float time) { return self.LTColor(new Color(self.color.r, self.color.g, self.color.b, to), time).setOnUpdate((Color x) => self.color = x); }
	#endregion

	#region Image
	public static LTDescr LTColor(this Image self, Color to, float time) { return self.transform.LTValue(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTAlpha(this Image self, float to, float time) { return self.LTColor(new Color(self.color.r, self.color.g, self.color.g, to), time); }
	public static LTDescr LTFillAmount(this Image self, float to, float time) { return self.transform.LTValue(self.fillAmount, to, time).setOnUpdate((float x) => self.fillAmount = x); }
	#endregion

	#region LayoutElement
	public static LTDescr LTFlexibleSize(this LayoutElement self, Vector2 to, float time)
	{
		return self.transform.LTValue(new Vector2(self.flexibleWidth, self.flexibleHeight), to, time)
			.setOnUpdate((Vector2 x) =>
			{
				self.flexibleWidth = x.x;
				self.flexibleHeight = x.y;
			});
	}
	public static LTDescr LTMinSize(this LayoutElement self, Vector2 to, float time)
	{
		return self.transform.LTValue(new Vector2(self.minWidth, self.minHeight), to, time)
			.setOnUpdate((Vector2 x) =>
			{
				self.minWidth = x.x;
				self.minHeight = x.y;
			});
	}
	public static LTDescr LTPreferredSize(this LayoutElement self, Vector2 to, float time)
	{
		return self.transform.LTValue(new Vector2(self.preferredWidth, self.preferredHeight), to, time)
			.setOnUpdate((Vector2 x) =>
			{
				self.preferredWidth = x.x;
				self.preferredHeight = x.y;
			});
	}
	#endregion

	#region OutLine
	public static LTDescr LTEffectColor(this Outline self, Color to, float time) { return self.transform.LTValue(self.effectColor, to, time).setOnUpdate((Color x) => self.effectColor = x); }
	public static LTDescr LTAlpha(this Outline self, float to, float time) { return self.LTEffectColor(new Color(self.effectColor.r, self.effectColor.g, self.effectColor.b, to), time); }
	#endregion

	#region ScrollRect
	public static LTDescr LTNormalizedPosition(this ScrollRect self, Vector2 to, float time) { return self.transform.LTValue(self.normalizedPosition, to, time).setOnUpdate((Vector2 x) => self.normalizedPosition = x); }
	public static LTDescr LTHorizontalNormalizedPosition(this ScrollRect self, float to, float time) { return self.transform.LTValue(self.horizontalNormalizedPosition, to, time).setOnUpdate((float x) => self.horizontalNormalizedPosition = x); }
	public static LTDescr LTVerticalNormalizedPosition(this ScrollRect self, float to, float time) { return self.transform.LTValue(self.verticalNormalizedPosition, to, time).setOnUpdate((float x) => self.verticalNormalizedPosition = x); }
	#endregion

	#region Slider
	public static LTDescr LTValue(this Slider self, float to, float time) { return self.transform.LTValue(self.value, to, time).setOnUpdate((float x) => self.value = x); }
	#endregion

	#region Text
	public static LTDescr LTColor(this Text self, Color to, float time) { return self.transform.LTValue(self.color, to, time).setOnUpdate((Color x) => self.color = x); }
	public static LTDescr LTAlpha(this Text self, float to, float time) { return self.LTColor(new Color(self.color.r, self.color.g, self.color.b, to), time); }
	public static LTDescr LTText(this Text self, string to, float time)
	{
		return self.transform.LTValue(0, to.Length, time)
			.setOnUpdate((float x) =>
			{
				int pos = (int)x;
				self.text = to.Substring(0, pos);
			});
	}
	#endregion
}