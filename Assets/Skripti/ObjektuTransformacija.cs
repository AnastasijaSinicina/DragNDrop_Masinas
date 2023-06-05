using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour
{

	public Objekti objektuSkripts;


	// Update is called once per frame
	void Update()
	{
		if (objektuSkripts.pedejaisVilktais != null)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 40f);
			}
			if (Input.GetKey(KeyCode.X))
			{
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 40f);
			}
			if (Input.GetKey(KeyCode.UpArrow))
			{
				if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y <= 1f)
				{

					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y + 0.005f);
				}
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y >= 0.5f)
				{

					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y - 0.005f);
				}
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y >= 0.5f)
				{

					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.005f,
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y);
				}
			}
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y <= 1f)
                {

                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.005f,
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y);
                }
            }
        }
	}
}