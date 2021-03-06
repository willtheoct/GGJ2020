﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Plane))]
public class failToClearScreen : MonoBehaviour
{
    public Texture dvdLogo;
    public Texture startingImage;
    RenderTexture rt;
    Material mat;
    public Shader shader;
    public Vector2 newDrawPosition;
    private void Start()
    {
        rt = RenderTexture.GetTemporary(1600, 900);
        mat = new Material(shader);
        mat.SetFloat("_Size", 0.3f);
        OnEnable();
    }
    private void OnDisable()
    {
        OnEnable();
    }
    void OnEnable()
    {
        Graphics.Blit(startingImage, rt);

        //for some reason unity needs all this to trigger the material to be transparent.
        var surfaceMat= new Material(Shader.Find("Standard"));
        surfaceMat.SetFloat("_SpecularHighlights", 0f);
        surfaceMat.SetFloat("_GlossyReflections", 0f);
        surfaceMat.SetFloat("_Glossiness", 0f);
        surfaceMat.SetTexture("_MainTex", rt);
        surfaceMat.SetFloat("_Mode", 1f);
        surfaceMat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        surfaceMat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        surfaceMat.SetInt("_ZWrite", 0);
        surfaceMat.DisableKeyword("_ALPHATEST_ON");
        surfaceMat.EnableKeyword("_ALPHABLEND_ON");
        surfaceMat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        surfaceMat.renderQueue = 3000;


        GetComponent<MeshRenderer>().material = surfaceMat;
    }

    // Update is called once per frame
    void Update()
    {
        newDrawPosition.x += Random.Range(-1f, 1f) * Time.deltaTime;
        newDrawPosition.y +=Random.Range(-1f,1f)*Time.deltaTime;
        newDrawPosition.x = (newDrawPosition.x + 0.5f) % 2f;
        newDrawPosition.y = (newDrawPosition.y + 0.5f) % 2f;
        mat.SetVector("_Center", new Vector4(newDrawPosition.x,newDrawPosition.y));


        Graphics.Blit(dvdLogo, rt,mat);
    }
    void OnDestroy()
    {
        RenderTexture.ReleaseTemporary(rt);
    }
}
