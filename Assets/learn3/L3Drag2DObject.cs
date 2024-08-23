using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class L3Drag2DObject : MonoBehaviour, IDragHandler
{
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        var pt = Camera.main.ScreenToWorldPoint(eventData.position);
        pt.z = 0;
        transform.position = pt;
    }
}
