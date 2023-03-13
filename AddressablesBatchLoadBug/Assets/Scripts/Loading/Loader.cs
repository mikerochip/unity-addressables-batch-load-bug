using SO;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Loading
{
    public class Loader : MonoBehaviour
    {
        public AssetLabelReference Label;
        
        private void Awake()
        {
            var assetsOp = Addressables.LoadAssetsAsync<Base>(Label.labelString, null, Addressables.MergeMode.Union);
            assetsOp.Completed += handle =>
            {
                Debug.Log($"Load Op=LoadAssets|Step=Completed|Status={handle.Status}");
            };

            var locationsOp = Addressables.LoadResourceLocationsAsync(Label.labelString);
            locationsOp.Completed += handle =>
            {
                Debug.Log($"Load Op=LoadLocations|Step=Completed|Status={handle.Status}");
            };
        }
    }
}
