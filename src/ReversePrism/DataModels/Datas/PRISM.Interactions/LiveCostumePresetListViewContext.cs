using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OnClickSaveButton                        Action`1<int> IL2CPP_TYPE_GENERICINST
    // 040 OnClickApplyButton                       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 048 OnClickDeleteButton                      Action`1<int> IL2CPP_TYPE_GENERICINST
    // 050 OnEndEditPresetName                      Action`1<ValueTuple`2<int, string>> IL2CPP_TYPE_GENERICINST
    public partial class LiveCostumePresetListViewContext : DataModel
    {

        public static LiveCostumePresetListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumePresetListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
