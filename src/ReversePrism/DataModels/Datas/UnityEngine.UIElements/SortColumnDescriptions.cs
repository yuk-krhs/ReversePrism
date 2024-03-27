using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Descriptions                           IList`1<SortColumnDescription> IL2CPP_TYPE_GENERICINST
    // 018 Changed                                  0001866792B0 ModelClassType Action Action Action Pointer
    public partial class SortColumnDescriptions
    {
        public Action?                                  Changed                                 { get; set; }

        public static SortColumnDescriptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortColumnDescriptions();

            value.Changed                                   = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 02700672D980 0x18 Changed                     ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
