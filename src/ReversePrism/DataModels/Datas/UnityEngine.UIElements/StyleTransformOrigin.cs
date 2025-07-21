using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelEnumType TransformOrigin TransformOrigin TransformOrigin Int32
    // 024 M_Keyword                                ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleTransformOrigin : DataModel
    {
        public TransformOrigin                          M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleTransformOrigin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleTransformOrigin() { Pointer= p0 };

            value.M_Value                                   = (TransformOrigin)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelEnumType TransformOrigin TransformOrigin TransformOrigin Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_Keyword                   ( ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
