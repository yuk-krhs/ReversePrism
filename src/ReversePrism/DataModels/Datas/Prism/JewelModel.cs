using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JewelRP                                  0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    public partial class JewelModel
    {
        public LongReactiveProperty?                    JewelRP                                 { get; set; }

        public static JewelModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JewelModel();

            value.JewelRP                                   = GetObject<LongReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 027004F46640 0x10 JewelRP                     ( 0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )

            return value;
        }
    }
}
