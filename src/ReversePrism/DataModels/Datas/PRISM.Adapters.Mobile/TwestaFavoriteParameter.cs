using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollerPosition                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class TwestaFavoriteParameter
    {
        public float                                    ScrollerPosition                        { get; set; }

        public static TwestaFavoriteParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteParameter();

            value.ScrollerPosition                          = GetSingle(new IntPtr(p + 0x010)); // 0270D68DB460 0x10 ScrollerPosition            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
