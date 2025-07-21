using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 <StatusDisplayType>k__BackingField       ReactiveProperty`1<LiveIdolIconStatusDisplayType> IL2CPP_TYPE_GENERICINST
    public partial class LiveIdolGridViewContext : DataModel
    {

        public static LiveIdolGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolGridViewContext() { Pointer= p0 };


            return value;
        }
    }
}
