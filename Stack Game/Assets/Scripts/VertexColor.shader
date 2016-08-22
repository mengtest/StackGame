Shader "Vertex Color"{
	Properties{
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader{
		Pass{
			Lighting On
			ColorMaterial AmbientAndDiffuse
			SetTexture[_MaintTex]{
					combine texture * primary DOUBLE
			}
		}
	}
}