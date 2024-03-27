using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001866F0EC0 ModelClassType ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour Pointer
    public partial class ScreenEdgeColorClip
    {
        public ScreenEdgeColorBehaviour?                Behaviour                               { get; set; }

        public static ScreenEdgeColorClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEdgeColorClip();

            value.Behaviour                                 = GetObject<ScreenEdgeColorBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScreenEdgeColorBehaviour.FromPointer); // 0270D5075E58 0x18 Behaviour                   ( 0001866F0EC0 ModelClassType ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour Pointer )

            return value;
        }
    }
}
