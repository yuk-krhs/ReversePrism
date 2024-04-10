using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Finger                                 000186582560 ModelClassType Finger Finger Finger Pointer
    // 018 m_TouchRecord                            Record<TouchState> IL2CPP_TYPE_GENERICINST
    // 000 s_GlobalState                            GlobalState IL2CPP_TYPE_VALUETYPE
    public partial class Touch : DataModel
    {
        public Finger?                                  M_Finger                                { get; set; }

        public static Touch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Touch() { Pointer= p0 };

            value.M_Finger                                  = GetObject<Finger>(new IntPtr(p + 0x010), ReversePrism.DataModels.Finger.FromPointer); // 024667835E48 0x10 M_Finger                    ( 000186582560 ModelClassType Finger Finger Finger Pointer )

            return value;
        }
    }
}
