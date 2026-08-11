using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace UniTaskCompiled.CustomExtensions
{
    #nullable enable
    public static class GameObjectExtensions
    {
        public static CancellationToken GetSaveCancellationToken(this GameObject? gameObject)
        {
            if (gameObject == null)
            {
                return new CancellationToken(true);
            }
            
            return gameObject.GetCancellationTokenOnDestroy();
        }
    }
}