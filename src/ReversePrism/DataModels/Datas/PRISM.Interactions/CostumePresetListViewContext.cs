using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 OnClickApplyButton                       Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CostumePresetListViewContext : DataModel
    {

        public static CostumePresetListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
