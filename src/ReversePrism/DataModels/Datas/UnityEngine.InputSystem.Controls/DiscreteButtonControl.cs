using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 138 MinValue                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 13C MaxValue                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 140 WrapAtValue                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 144 NullValue                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 148 WriteMode                                0001865A7AF0 ModelEnumType WriteMode WriteMode WriteMode Int32
    public partial class DiscreteButtonControl
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
            var value   = new DiscreteButtonControl();

            value.MinValue                                  = GetInt32(new IntPtr(p + 0x138)); // 027003379ED8 0x138 MinValue                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxValue                                  = GetInt32(new IntPtr(p + 0x13C)); // 027003379EF8 0x13C MaxValue                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WrapAtValue                               = GetInt32(new IntPtr(p + 0x140)); // 027003379F18 0x140 WrapAtValue                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NullValue                                 = GetInt32(new IntPtr(p + 0x144)); // 027003379F38 0x144 NullValue                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WriteMode                                 = (WriteMode)GetInt32(new IntPtr(p + 0x148)); // 027003379F58 0x148 WriteMode                   ( 0001865A7AF0 ModelEnumType WriteMode WriteMode WriteMode Int32 )

            return value;
        }
    }
}
