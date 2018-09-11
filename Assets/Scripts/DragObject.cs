using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public enum MouseButtom { Primary, Secondary, Middle };

    public MouseButtom mouseButtom = MouseButtom.Primary;

    RectTransform rect;
    Vector2 startPos;
    Vector2 startClickPos;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        startClickPos = MousePosUI();
        startPos = rect.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.GetMouseButton((int)mouseButtom))
        {
            rect.anchoredPosition = startPos + MousePosUI() - startClickPos;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rect.anchoredPosition = startPos;
    }

    private Vector2 MousePosUI()
    {
        return new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
