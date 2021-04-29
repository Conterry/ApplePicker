using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    private SettingsReader settingsReader;
    private int speedOf = 10;
    private float leftAndRightEdge = 10f;
    public float chanceToChangeDirections;

    private void Start()
    {
        chanceToChangeDirections = SettingsReader.TakeSettingByLine(2);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speedOf * Time.deltaTime;
        transform.position = pos;

        ChangeDiraction();

    }

    void ChangeDiraction()
    {
        Vector3 pos = this.transform.position;
        if (pos.x < -leftAndRightEdge)
        {
            speedOf = Mathf.Abs(speedOf);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speedOf = -Mathf.Abs(speedOf);
        }

        if (Random.value < chanceToChangeDirections)
        {
            speedOf *= -1;
        }
    }
}
