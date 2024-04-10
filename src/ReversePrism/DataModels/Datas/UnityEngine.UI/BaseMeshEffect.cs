using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Graphic                                000186692A90 ModelClassType Graphic Graphic Graphic Pointer
    public partial class BaseMeshEffect : DataModel
    {
        public Graphic?                                 M_Graphic                               { get; set; }

        public static BaseMeshEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseMeshEffect() { Pointer= p0 };

            value.M_Graphic                                 = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0245A1E986F0 0x20 M_Graphic                   ( 000186692A90 ModelClassType Graphic Graphic Graphic Pointer )

            return value;
        }
    }
}
