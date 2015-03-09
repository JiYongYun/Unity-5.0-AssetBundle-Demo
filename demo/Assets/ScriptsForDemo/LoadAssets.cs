using UnityEngine;
using System.Collections;

public class LoadAssets : BaseLoader {

	public string assetBundleName = "cube.unity3d";
	public string assetName = "cube";

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

		// Load asset.
		yield return StartCoroutine(Load (assetBundleName, assetName) );

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(assetBundleName);
	}
}
