using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets.ResourceLocators;

[Serializable]
public class AssetReferencePlayer : AssetReferenceT<GameObject>
{
    public AssetReferencePlayer(string guid) : base(guid)
    {
    }
}
public class AddressableManager : MonoBehaviour
{
    [SerializeField] private AssetReference playerRef;
    [SerializeField] private AssetReferencePlayer playerAssetRef;
    private void Start()
    {
        Addressables.InitializeAsync().Completed += AddressableManagerComplete;
    }

    private void AddressableManagerComplete(AsyncOperationHandle<IResourceLocator> handle)
    {
        // playerRef.InstantiateAsync().Completed += (go) =>
        // {
        //     GameObject player = go.Result;
        //     Debug.Log($"playerRef Init {player.name}");
        // };

        playerAssetRef.LoadAssetAsync<GameObject>().Completed += (go) =>
        {
            // GameObject player = go.Result;
            // Debug.Log($"playerAssetRef Init {player.name}");
        };
    }
    private void NameMethod()
    {
    }
}
