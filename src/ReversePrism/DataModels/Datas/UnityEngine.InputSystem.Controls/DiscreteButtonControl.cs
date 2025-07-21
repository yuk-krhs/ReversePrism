using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 138 MinValue                                 ModelPrimitiveType int int int Int32
    // 13C MaxValue                                 ModelPrimitiveType int int int Int32
    // 140 WrapAtValue                              ModelPrimitiveType int int int Int32
    // 144 NullValue                                ModelPrimitiveType int int int Int32
    // 148 WriteMode                                ModelEnumType WriteMode WriteMode WriteMode Int32
    public partial class DiscreteButtonControl : DataModel
    {
        public int                                      MinValue                                { get; set; }
        public int                                      MaxValue                                { get; set; }
        public int                                      WrapAtValue                             { get; set; }
        public int                                      NullValue                               { get; set; }
        public WriteMode                                WriteMode                               { get; set; }

        public static DiscreteButtonControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiscreteButtonControl() { Pointer= p0 };

            value.MinValue                                  = GetInt32(new IntPtr(p + 0x138)); // 0x138 MinValue                    ( ModelPrimitiveType int int int Int32 )
            value.MaxValue                                  = GetInt32(new IntPtr(p + 0x13C)); // 0x13C MaxValue                    ( ModelPrimitiveType int int int Int32 )
            value.WrapAtValue                               = GetInt32(new IntPtr(p + 0x140)); // 0x140 WrapAtValue                 ( ModelPrimitiveType int int int Int32 )
            value.NullValue                                 = GetInt32(new IntPtr(p + 0x144)); // 0x144 NullValue                   ( ModelPrimitiveType int int int Int32 )
            value.WriteMode                                 = (WriteMode)GetInt32(new IntPtr(p + 0x148)); // 0x148 WriteMode                   ( ModelEnumType WriteMode WriteMode WriteMode Int32 )

            return value;
        }
    }
}
