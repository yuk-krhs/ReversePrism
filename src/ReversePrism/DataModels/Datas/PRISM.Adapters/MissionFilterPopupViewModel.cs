using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 filterSaveData                           SavableJsonObject`1<MissionFilterSaveData> IL2CPP_TYPE_GENERICINST
    public partial class MissionFilterPopupViewModel : DataModel
    {

        public static MissionFilterPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionFilterPopupViewModel() { Pointer= p0 };


            return value;
        }
    }
}
