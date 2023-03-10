Repro Steps:

1. Open the Unity project `AddressablesBatchLoadBug`
1. Open the scene `SampleScene`
1. Press play to enter play mode
1. See the Console log for the following error:

```
UnityEngine.AddressableAssets.InvalidKeyException: Exception of type 'UnityEngine.AddressableAssets.InvalidKeyException' was thrown. No Asset found with for Key=Base. Key exists as multiple Types=SO.Sub1, SO.Sub2, which is not assignable from the requested Type=SO.Base
UnityEngine.AddressableAssets.Addressables:LoadAssetsAsync<SO.Base> (System.Collections.IEnumerable,System.Action`1<SO.Base>,UnityEngine.AddressableAssets.Addressables/MergeMode)
Loading.Loader:Awake () (at Assets/Scripts/Loading/Loader.cs:13)
```
