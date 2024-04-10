using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 OnClickSaveButton                        Action`1<int> IL2CPP_TYPE_GENERICINST
    // 098 OnClickApplyButton                       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 OnClickDeleteButton                      Action`1<int> IL2CPP_TYPE_GENERICINST
    // 0A8 onEndEditPresetNameSubject               Subject`1<ValueTuple`2<int, string>> IL2CPP_TYPE_GENERICINST
    public partial class LiveCostumePresetListView : DataModel
    {

        public static LiveCostumePresetListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumePresetListView() { Pointer= p0 };


            return value;
        }
    }
}
