using UnityEngine;
using System.Collections;

public class LoadVariants : BaseLoader {

	public string variantSceneAssetBundle = "variants/variant-scene.unity3d";
	public string variantSceneName = "variant-scene";
	public string[] activeVariants = {"hd"};

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

		// Set active variants.
		AssetBundleManager.Variants = activeVariants;

		// Load variant level which depends on variants.
		yield return StartCoroutine(LoadLevel (variantSceneAssetBundle, variantSceneName, true) );
		
		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(variantSceneAssetBundle);
	}
}
