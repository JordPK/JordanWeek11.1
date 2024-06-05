using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessingFxScript : MonoBehaviour
{
    [SerializeField] Volume globalVolumeBase;

    private ColorAdjustments colAdj;

    // Start is called before the first frame update
    void Start()
    {
        globalVolumeBase.profile.TryGet(out colAdj);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            BlackAndWhiteFilter(true);
        }
        else
        {
            BlackAndWhiteFilter(false);
        }
    }
    public void BlackAndWhiteFilter(bool toggle)
    {
        if (toggle)
        {
            colAdj.saturation.value = -100;
        }
        else if (!toggle)
        {
            colAdj.saturation.value = 0;
        }
    }
}