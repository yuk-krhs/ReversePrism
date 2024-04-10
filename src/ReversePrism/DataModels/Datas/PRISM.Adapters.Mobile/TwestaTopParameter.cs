using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class TwestaTopParameter : DataModel
    {
        public float                                    ScrollPosition                          { get; set; }

        public static TwestaTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopParameter() { Pointer= p0 };

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 024666961328 0x10 ScrollPosition              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
