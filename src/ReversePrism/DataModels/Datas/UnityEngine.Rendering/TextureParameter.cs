using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Dimension                                ModelEnumType TextureDimension TextureDimension TextureDimension Int32
    public partial class TextureParameter : DataModel
    {
        public TextureDimension                         Dimension                               { get; set; }

        public static TextureParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureParameter() { Pointer= p0 };

            value.Dimension                                 = (TextureDimension)GetInt32(new IntPtr(p + 0x020)); // 0x20 Dimension                   ( ModelEnumType TextureDimension TextureDimension TextureDimension Int32 )

            return value;
        }
    }
}
