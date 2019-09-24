using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spnr : MonoBehaviour
{

    bool swt;
    bool spb;

    public GameObject[] blks;
    public GameObject tm;
    public Transform trgrot;
    private int randomPf;
    private int i;

    public int ct;
    public int ct2;
    public int tt;
    public int ctt;
   

    
    Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {

        spb = true;
       
        i = 0;
        ctt = 0;


    }

    // Update is called once per frame
    void Update()
    {
        


        //Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos = new Vector3(mousePos.x, mousePos.y, 0);

        transform.position = pos;


       ct =  GameObject.FindGameObjectsWithTag("Respawn").Length;

        countt.countvalue = ct;
            
        tt = GameObject.FindGameObjectsWithTag("Finish").Length;

       ct2 = ct + 0;

        if(swt == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(tm, new Vector3(pos.x, pos.y, 0), trgrot.rotation);

                //ct2 = ct + 1;
                ctt = ctt + 1;
                swt = false;
                


           }
        }


        if (tt == 1)
        {
            swt = false;

        }

        if (ctt == 30)
        {
            swt = true;
            spb = false;
        }

        if (spb == true)
        {
            swt = false;
            if (Input.GetMouseButtonDown(0))
            {


                

                if (i >= 3)
                {
                    i = 0;
                }

                if (i <= 2)
                {
                   

                    Instantiate(blks[i], new Vector3(pos.x, pos.y, 0), Quaternion.identity);

                    i = i + 1;
                    ctt = ctt + 1;

                }

            }
        }
      
        //randomPf = Random.Range(0,3);



    }
}
