using UnityEngine;
using System.Collections;

public class LoadScenes : BaseLoader {

	public string sceneAssetBundle = "scene.unity3d";
	public string sceneName = "testScene";

	public bool loadLevelAdditive = true;

	// Use this for initialization
	IEnumerator Start () {
		
		yield return StartCoroutine(Initialize() );

		// Load level.
		yield return StartCoroutine(LoadLevel (sceneAssetBundle, sceneName, loadLevelAdditive) );

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(sceneAssetBundle);
	}
}
