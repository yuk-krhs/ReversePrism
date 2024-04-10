using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Height                                   000186666F40 ModelPrimitiveType float float float Single
    public partial class SpaceAttribute : DataModel
    {
        public float                                    Height                                  { get; set; }

        public static SpaceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpaceAttribute() { Pointer= p0 };

            value.Height                                    = GetSingle(new IntPtr(p + 0x010)); // 0245A687AAA8 0x10 Height                      ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
