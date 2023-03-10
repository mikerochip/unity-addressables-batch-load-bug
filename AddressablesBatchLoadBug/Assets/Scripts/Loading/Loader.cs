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
            var op = Addressables.LoadAssetsAsync<Base>(Label.labelString, null, Addressables.MergeMode.Union);
            op.Completed += handle =>
            {
                Debug.Log($"Load Step=Completed|Status={handle.Status}");
            };
        }
    }
}
