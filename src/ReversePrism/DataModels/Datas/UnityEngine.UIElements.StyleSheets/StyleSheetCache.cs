using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Comparer                               SheetHandleKeyComparer IL2CPP_TYPE_CLASS
    // 008 s_RulePropertyIdsCache                   Dictionary`2<SheetHandleKey, StylePropertyId[]> IL2CPP_TYPE_GENERICINST
    public partial class StyleSheetCache : DataModel
    {

        public static StyleSheetCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSheetCache() { Pointer= p0 };


            return value;
        }
    }
}
