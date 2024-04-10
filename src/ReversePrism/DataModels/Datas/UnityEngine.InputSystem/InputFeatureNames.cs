using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kRunPlayerUpdatesInEditMode              string IL2CPP_TYPE_STRING
    // 000 kDisableUnityRemoteSupport               string IL2CPP_TYPE_STRING
    // 000 kUseWindowsGamingInputBackend            string IL2CPP_TYPE_STRING
    // 000 kUseOptimizedControls                    string IL2CPP_TYPE_STRING
    // 000 kUseReadValueCaching                     string IL2CPP_TYPE_STRING
    // 000 kParanoidReadValueCachingChecks          string IL2CPP_TYPE_STRING
    public partial class InputFeatureNames : DataModel
    {

        public static InputFeatureNames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFeatureNames() { Pointer= p0 };


            return value;
        }
    }
}
