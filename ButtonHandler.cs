using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Material day;
    public Material evening;
    public Material night;

    public void SetDaySkybox()
    {
        RenderSettings.skybox = day;
    }
    public void SetEveningSkybox()
    {
        RenderSettings.skybox = evening;
    }
    public void SetNightSkybox()
    {
        RenderSettings.skybox = night;
    }
}
