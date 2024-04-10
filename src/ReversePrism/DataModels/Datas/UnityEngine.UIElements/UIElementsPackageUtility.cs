using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <IsUIEPackageLoaded>k__BackingField      bool IL2CPP_TYPE_BOOLEAN
    // 008 <EditorResourcesBasePath>k__BackingField string IL2CPP_TYPE_STRING
    public partial class UIElementsPackageUtility : DataModel
    {

        public static UIElementsPackageUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIElementsPackageUtility() { Pointer= p0 };


            return value;
        }
    }
}
