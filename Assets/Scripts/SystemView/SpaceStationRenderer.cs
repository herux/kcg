using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemView
{
    public class SpaceStationRenderer : MonoBehaviour
    {
        public SpaceStation Station;

        public SpriteRenderer StationRenderer;
        public OrbitRenderer  OrbitRender;

        public Color orbitColor   = new Color(0.843f, 0.290f, 0.075f, 1.0f);
        public Color stationColor = new Color(0.839f, 0.075f, 0.114f, 1.0f);

        public CameraController Camera;

        // Start is called before the first frame update
        void Start()
        {
            OrbitRender = gameObject.AddComponent<OrbitRenderer>();
            StationRenderer = gameObject.AddComponent<SpriteRenderer>();

            OrbitRender.descriptor = Station.Descriptor;

            Camera = GameObject.Find("Main Camera").GetComponent<CameraController>();

            // Temporary sprites
            StationRenderer.sprite = UnityEditor.AssetDatabase.GetBuiltinExtraResource<Sprite>("UI/Skin/UISprite.psd");
        }

        // Update is called once per frame
        void Update()
        {
            float[] Position = Station.Descriptor.GetPosition();

            StationRenderer.transform.position = new Vector3(Position[0], Position[1], -0.1f);
            StationRenderer.transform.localScale = new Vector3(7.5f / Camera.scale, 7.5f / Camera.scale, 1.0f);

            StationRenderer.color = stationColor;
            OrbitRender.color = orbitColor;

            OrbitRender.descriptor = Station.Descriptor;

            OrbitRender.UpdateRenderer(128);
        }
    }
}
