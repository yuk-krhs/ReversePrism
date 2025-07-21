using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour Pointer
    public partial class ScreenEdgeColorClip : DataModel
    {
        public ScreenEdgeColorBehaviour?                Behaviour                               { get; set; }

        public static ScreenEdgeColorClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEdgeColorClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<ScreenEdgeColorBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScreenEdgeColorBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour ScreenEdgeColorBehaviour Pointer )

            return value;
        }
    }
}
