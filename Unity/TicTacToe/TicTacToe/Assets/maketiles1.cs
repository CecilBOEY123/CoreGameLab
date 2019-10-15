using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maketiles1 : MonoBehaviour
{

    public GameObject tiles;

    Vector3 mouseWorldPos;
    Vector3 mouseScreenPos;

    bool dragging;
    GameObject currtile;

    bool XorO;

    LayerMask grid;
    LayerMask matches;

    // Start is called before the first frame update
    void Start()
    {

        grid = LayerMask.GetMask("grid");
        matches = LayerMask.GetMask("matches");

    }

    // Update is called once per frame
    public void Update()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseScreenPos = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);

        if (dragging)
        {
            currtile.transform.position = mouseScreenPos;

            if (Input.GetMouseButtonDown(0))
            {

                RaycastHit2D hit = Physics2D.Raycast(mouseScreenPos, Vector2.zero, 100f, grid);
                if (hit.collider.gameObject.tag == "grid")
                {

                    currtile.transform.position = hit.collider.gameObject.transform.position;
                    dragging = false;
                    hit.collider.gameObject.SetActive(false);

                    checkmathces(mouseScreenPos);

                }

            }

        }


    }

     public void checkmathces(Vector3 pos)
    {

        RaycastHit2D[] hits = Physics2D.RaycastAll(pos, Vector2.zero, 100f, matches);
        if (hits.Length > 0)
        {

            for (int t = 0; t < 3; t++)
            {



            }

        }

    }

    public void click()
    {

        currtile = Instantiate(tiles, mouseScreenPos, Quaternion.identity);
        currtile.GetComponent<tilemanager>().settile(XorO);
        dragging = true;
        XorO = !XorO;

    }
}
