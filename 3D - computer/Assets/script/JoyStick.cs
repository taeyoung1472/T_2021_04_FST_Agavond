using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private RectTransform lever;
    private RectTransform rectTransform;
    public float speed;

    [SerializeField, Range(10, 150)]
    private float leverRange;

    private Vector2 inputDirection;
    private bool isInput;
    public Text cur;
    public Text cur2;
    public Text cur3;

    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private Hero move;
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        speed = 2.5f;
        Player = GameObject.Find("Player");
        move = Player.GetComponent<Hero>();
    }
    private void Start()
    {

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        ControlJoystickLever(eventData);
        isInput = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        ControlJoystickLever(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
        isInput = false;
    }

    private void ControlJoystickLever(PointerEventData eventData)
    {
        var inputPos = eventData.position - rectTransform.anchoredPosition;
        var inputVector = inputPos.magnitude < leverRange ? inputPos : inputPos.normalized * leverRange;
        lever.anchoredPosition = inputVector;
        inputDirection = inputVector / leverRange;
    }
    private void InputControlVector()
    {
        //Debug.Log(inputDirection.x + " / " + inputDirection.y);
        cur.text = string.Format("{0}", inputDirection.x);
        cur2.text = string.Format("{0}", speed);
        cur3.text = string.Format("{0}", inputDirection.y);
        move.Move(inputDirection.x * speed, inputDirection.y * speed);
    }
    private void Update()
    {
        if (isInput)
        {
            InputControlVector();
        }
    }
}


