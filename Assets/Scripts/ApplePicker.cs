using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.GlobalIllumination;

public class ApplePicker : MonoBehaviour
{
    [SerializeField] DownDestroyer downField;
    [SerializeField] Basket basket;
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    public event System.Action OnAppleCatch;

    void Start()
    {
        InstantiateBaskets();
        downField.OnAppleWentOutOfTheField += DestroyBasket;
        basket.OnAppleCatch += OfAppleCatch;
    }

    private void OfAppleCatch()
    {
        if (OnAppleCatch != null)
        {
            OnAppleCatch();
        }
    }

    private void InstantiateBaskets()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }


    private void DestroyBasket()
    {
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }

}
