using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_GroupHandle                            <int> IL2CPP_TYPE_I
    // 018 M_PerformCulling                         0001866F8300 ModelClassType OnPerformCulling OnPerformCulling OnPerformCulling Pointer
    public partial class BatchRendererGroup : DataModel
    {
        public OnPerformCulling?                        M_PerformCulling                        { get; set; }

        public static BatchRendererGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchRendererGroup() { Pointer= p0 };

            value.M_PerformCulling                          = GetObject<OnPerformCulling>(new IntPtr(p + 0x018), ReversePrism.DataModels.OnPerformCulling.FromPointer); // 0245A2456260 0x18 M_PerformCulling            ( 0001866F8300 ModelClassType OnPerformCulling OnPerformCulling OnPerformCulling Pointer )

            return value;
        }
    }
}
