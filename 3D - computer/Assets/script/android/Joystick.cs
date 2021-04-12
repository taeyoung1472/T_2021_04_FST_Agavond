using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{

    private Image imagebackground;
    private Image imagecontroller;
    private Vector2 touchposition;

    private void Awake()
    {
        imagebackground = GetComponent<Image>();
        imagecontroller = transform.GetChild(0).GetComponent<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnDrag(PointerEventData eventData)
    {
        touchposition = Vector2.zero;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imagebackground.rectTransform, eventData.position, eventData.pressEventCamera, out touchposition))
        {
            touchposition.x = (touchposition.x / imagebackground.rectTransform.sizeDelta.x);
            touchposition.y = (touchposition.y / imagebackground.rectTransform.sizeDelta.y);
            touchposition = new Vector2(touchposition.x * 2 - 1, touchposition.y * 2 - 1);
            touchposition = (touchposition.magnitude > 1) ? touchposition.normalized : touchposition;

            imagecontroller.rectTransform.anchoredPosition = new Vector2(
                touchposition.x * imagebackground.rectTransform.sizeDelta.x / 2,
                touchposition.y * imagebackground.rectTransform.sizeDelta.y / 2);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        imagecontroller.rectTransform.anchoredPosition = Vector2.zero;
        touchposition = Vector2.zero;
    }
    public float Horizontal()
    {
        return touchposition.x;
    }
    public float Vertical()
    {
        return touchposition.y;
    }
}

