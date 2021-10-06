using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.GameRunning() == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GetComponent<Animator>().SetTrigger("Fly");
            }
        }
        else
        {
            Vector3 mousePoint = Vector3.zero;
            if (Input.GetButtonDown("Fire1"))
            {
                mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                mousePoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            }
            mousePoint.z = 0;

            if (mousePoint != Vector3.zero)
            {
                if (boxCollider.bounds.Contains(mousePoint))
                {
                    EventSystem.StartGame();
                }
            }
        }

    }
}
