using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class TwestaTopParameter
    {
        public float                                    ScrollPosition                          { get; set; }

        public static TwestaTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopParameter();

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 0270D68F1328 0x10 ScrollPosition              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
