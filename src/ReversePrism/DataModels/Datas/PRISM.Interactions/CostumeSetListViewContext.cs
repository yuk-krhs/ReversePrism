using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <OnCostumeIconLongPressed>k__BackingField Action`2<CostumeCategory, int> IL2CPP_TYPE_GENERICINST
    // 040 <IsTryOnMode>k__BackingField             ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSetListViewContext
    {

        public static CostumeSetListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetListViewContext();


            return value;
        }
    }
}
