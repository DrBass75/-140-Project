using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class colorchange : MonoBehaviour
{
    int x = 0;
    
    public GameObject button1;
    public GameObject button2;
    public GameObject activatedelet;
    public GameObject deactivatedelet;
    public GameObject undodelete;
    public GameObject showwui;
    public GameObject hhideui;
    public GameObject drop;
    public GameObject undoheighlight;
    int i = 0;
    int a = -1;
    int j = 0;
    List<GameObject> getobjects = new List<GameObject>();
    List<Color> getmaterial = new List<Color>();
    List<GameObject> getmaerialobjects = new List<GameObject>();
    /// public Dropdown dropdown;
    public TMP_Dropdown dropdown=null;
    // Start is called before the first frame update
    void Start()
    {
        button2.SetActive(false);
        deactivatedelet.SetActive(false);
        showwui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // dropdown.onValueChanged.AddListener(delegate
      // {
        //    check(dropdown);
       // });

        check(dropdown);
    }

    public GameObject panel;
    public void panelhide()
    {
        panel.SetActive(false);
    }
    
    public void check(TMP_Dropdown sender)
    {
        try
            {
            a = sender.value;
            if (Input.GetMouseButtonDown(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {


                    // if (hit.transform.name == "wall")
                    //{
                    //   Debug.Log("lets start");
                    //   objects.Add(GameObject.Find("wall"));
                    //    GameObject.Find("wall").SetActive(false);
                    // }

                    var selected = hit.transform;

                    if (x == 1)
                    {
                        bool check = search(hit);
                        if (a == 0)
                        {
                            //if (p == 0)
                            // {
                            Debug.Log("we got hit");
                            if (check == true)
                            {
                                selected.GetComponent<Renderer>().material.color = Color.red;
                            }
                            else
                            {
                                getmaterial.Add(selected.GetComponent<Renderer>().material.color);
                                getmaerialobjects.Add(selected.GetComponent<Renderer>().gameObject);
                                selected.GetComponent<Renderer>().material.color = Color.red;
                                updatesize();
                            }

                            // }
                        }


                        else if (a == 1)
                        {
                            if (check == true)
                            {
                                selected.GetComponent<Renderer>().material.color = Color.blue;
                            }
                            else
                            {
                                getmaterial.Add(selected.GetComponent<Renderer>().material.color);
                                getmaerialobjects.Add(selected.GetComponent<Renderer>().gameObject);
                                selected.GetComponent<Renderer>().material.color = Color.blue;
                                updatesize();
                            }

                        }
                        else if (a == 2)
                        {
                            if (check == true)
                            {
                                selected.GetComponent<Renderer>().material.color = Color.green;
                            }
                            else
                            {
                                getmaterial.Add(selected.GetComponent<Renderer>().material.color);
                                getmaerialobjects.Add(selected.GetComponent<Renderer>().gameObject);
                                selected.GetComponent<Renderer>().material.color = Color.green;
                                updatesize();
                            }

                        }
                        else
                        {

                        }
                    }

                    else if (x == 2)
                    {
                        selected.GetComponent<Renderer>().gameObject.SetActive(false);
                        getobjects.Add(selected.GetComponent<Renderer>().gameObject);
                       updatesize();

                    }

                    //Renderer.material.color = Color.red;

                }
            }
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
        
    }
    public bool search(RaycastHit hit)
    {
        try
        {
            var selected = hit.transform;
            for (int lop = 0; lop < getmaterial.Count; lop++)
            {
                if (getmaerialobjects[lop].Equals(selected.GetComponent<Renderer>().gameObject))
                {
                    return true;
                }


            }
            
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
        return false;
    }
    public void turnof()
    {
        x = 0;
        button1.SetActive(true);
        button2.SetActive(false);
       
    }
    public void turnon()
    {
        x = 1;
        j = getmaerialobjects.Count - 1;
        button2.SetActive(true);
        button1.SetActive(false);
    }
    public void activatedelete()
    {
        x = 2;
        deactivatedelet.SetActive(true);
        activatedelet.SetActive(false);
    }
    public void deactivatedelete()
    {
        x = 3;
        deactivatedelet.SetActive(false);
        activatedelet.SetActive(true);
    }
    
   
    public void undoobject()
    {try
        {


            if (i>=0)
            {
                getobjects[i].SetActive(true);
                i--;
            }
            else
            {
                //i = getobjects.Count - 1;
            }
          
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
    }
    public void undocolor()
    {
        try
        {
            if (j >= 0)
            {
                getmaerialobjects[j].GetComponent<Renderer>().material.color = getmaterial[j];
                getmaerialobjects.RemoveAt(j);
                getmaterial.RemoveAt(j);
                j--;
            }
            else
            {
                Debug.Log("No color change");
               // j = getmaerialobjects.Count - 1;
            }
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
    }
    public void hideui()
    {
        showwui.SetActive(true);
        hhideui.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        activatedelet.SetActive(false);
        deactivatedelet.SetActive(false);
        undodelete.SetActive(false);
        drop.SetActive(false);
        undoheighlight.SetActive(false);


    }
    public void showui()
    {
        showwui.SetActive(false);
        hhideui.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        activatedelet.SetActive(true);
        deactivatedelet.SetActive(true);
        undodelete.SetActive(true);
        drop.SetActive(true);
        undoheighlight.SetActive(true);
    }
    public void updatesize()
    {
        i = getobjects.Count - 1;
        j = getmaerialobjects.Count - 1;
    }
    public void refresh()
    {
        /*getmaerialobjects.Clear();
        getmaterial.Clear();
        i = getobjects.Count - 1;
        j = getmaerialobjects.Count - 1;
        getmaerialobjects.Clear();
        getmaterial.Clear();*/
    }
}
