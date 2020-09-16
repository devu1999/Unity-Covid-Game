﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsZoom : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject zoomCard;

    public void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
    }

	public void OnHoverEnter(){
		zoomCard = Instantiate(gameObject, new Vector2(110, 60), Quaternion.identity);
		zoomCard.transform.SetParent(Canvas.transform, false);
		zoomCard.layer = LayerMask.NameToLayer("Zoom");
		RectTransform  rect = zoomCard.GetComponent<RectTransform>();
		rect.sizeDelta = new Vector2(80, 120);
	}

	public void OnHoverExit()
	{
		Destroy(zoomCard);
	}
}
