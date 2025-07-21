using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollerPosition                         ModelPrimitiveType float float float Single
    public partial class TwestaFavoriteParameter : DataModel
    {
        public float                                    ScrollerPosition                        { get; set; }

        public static TwestaFavoriteParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteParameter() { Pointer= p0 };

            value.ScrollerPosition                          = GetSingle(new IntPtr(p + 0x010)); // 0x10 ScrollerPosition            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
