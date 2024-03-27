using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ProcessedResourceVersion                 SavableProperty`1<string> IL2CPP_TYPE_GENERICINST
    // 020 ServerResourceVersion                    SavableProperty`1<string> IL2CPP_TYPE_GENERICINST
    // 028 RecoveryRequired                         SavableProperty`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class CatalogCacheSavedata
    {

        public static CatalogCacheSavedata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatalogCacheSavedata();


            return value;
        }
    }
}
