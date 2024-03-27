using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_OnStateChanged                         000186567610 ModelClassType StateChanged StateChanged StateChanged Pointer
    public partial class CullingGroup
    {
        public StateChanged?                            M_OnStateChanged                        { get; set; }

        public static CullingGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CullingGroup();

            value.M_OnStateChanged                          = GetObject<StateChanged>(new IntPtr(p + 0x018), ReversePrism.DataModels.StateChanged.FromPointer); // 0270023596B0 0x18 M_OnStateChanged            ( 000186567610 ModelClassType StateChanged StateChanged StateChanged Pointer )

            return value;
        }
    }
}
