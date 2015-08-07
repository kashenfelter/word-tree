﻿using UnityEngine;
using System.Collections;

namespace WordTree
{
	public class PulseBehavior : MonoBehaviour {

		public void StartPulsing (GameObject go, float delayTime = 0)
		{
			float scaleUpBy = 1.2f; 
			float time = Random.Range (.8f,1.0f);
			
			LeanTween.scale(go, new Vector3(go.transform.localScale.x * scaleUpBy, go.transform.localScale.y * scaleUpBy, 
			                                go.transform.localScale.z * scaleUpBy), time)
				.setEase(LeanTweenType.easeOutSine).setLoopPingPong().setDelay(delayTime);
		}
		
		public void StopPulsing (GameObject go)
		{
			LeanTween.cancel (go);
		}

	}
}
