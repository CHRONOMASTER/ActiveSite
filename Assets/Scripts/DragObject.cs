using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum MouseButtom { Primary, Secondary, Middle };

    public MouseButtom mouseButtom = MouseButtom.Primary;

    RectTransform rect;
    Vector3 startClickPos;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        startClickPos = Input.mousePosition;
        Debug.Log(startClickPos);
    }

    public void OnPointerDrag(PointerEventData eventData)
    {
        if (Input.GetMouseButton((int)mouseButtom))
        {
            rect.localPosition = Input.mousePosition - startClickPos;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rect.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
