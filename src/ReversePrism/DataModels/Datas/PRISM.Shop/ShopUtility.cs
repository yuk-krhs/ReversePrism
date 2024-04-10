using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 shopDocumentAssetPath                    string IL2CPP_TYPE_STRING
    // 000 ShopResourcesTag                         string IL2CPP_TYPE_STRING
    // 000 MultiProductIconKey                      string IL2CPP_TYPE_STRING
    // 000 StoreMasterIconNameKey                   string IL2CPP_TYPE_STRING
    // 000 ShopMasterIconNameKey                    string IL2CPP_TYPE_STRING
    public partial class ShopUtility : DataModel
    {

        public static ShopUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopUtility() { Pointer= p0 };


            return value;
        }
    }
}
