using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update


    public void MudaCor(MeshRenderer obj)

    {

        Color color = new Color32(255, 255, 255, 51);

        if (obj.material.color == color)
            obj.material.color = Color.red;
        else if (obj.material.color == Color.red)
            obj.material.color = Color.green;
        else if (obj.material.color == Color.green)
            obj.material.color = color;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    MudaCor(hit.collider.GetComponent<MeshRenderer>());
                }

            }
        }
    }
}

