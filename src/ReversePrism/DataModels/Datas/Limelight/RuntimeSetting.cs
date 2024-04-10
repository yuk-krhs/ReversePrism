using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Platform                                 string IL2CPP_TYPE_STRING
    // 000 ResourceDownloadURLRoot                  string IL2CPP_TYPE_STRING
    // 000 DefaultResourceVersion                   string IL2CPP_TYPE_STRING
    // 000 CatalogCacheScopeKey                     string IL2CPP_TYPE_STRING
    // 000 CatalogDBLocationKey                     string IL2CPP_TYPE_STRING
    // 000 AssetFileCleanerLocationKey              string IL2CPP_TYPE_STRING
    // 000 DefaultSafetyCapacityMargineMB           int IL2CPP_TYPE_I4
    public partial class RuntimeSetting : DataModel
    {

        public static RuntimeSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeSetting() { Pointer= p0 };


            return value;
        }
    }
}
