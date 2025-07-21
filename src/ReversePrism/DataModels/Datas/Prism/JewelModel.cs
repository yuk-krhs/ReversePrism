using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JewelRP                                  ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    public partial class JewelModel : DataModel
    {
        public LongReactiveProperty?                    JewelRP                                 { get; set; }

        public static JewelModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JewelModel() { Pointer= p0 };

            value.JewelRP                                   = GetObject<LongReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x10 JewelRP                     ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )

            return value;
        }
    }
}
