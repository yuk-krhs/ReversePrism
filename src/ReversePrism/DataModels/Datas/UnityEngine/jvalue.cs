using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Z                                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 010 B                                        00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 c                                        char IL2CPP_TYPE_CHAR
    // 010 S                                        0001865F1520 ModelPrimitiveType short short short Int16
    // 010 I                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 J                                        0001865F7E40 ModelPrimitiveType long long long Int64
    // 010 F                                        000186666050 ModelPrimitiveType float float float Single
    // 010 D                                        0001865C2E50 ModelPrimitiveType double double double Double
    // 010 l                                        <int> IL2CPP_TYPE_I
    public partial class jvalue
    {
        public bool                                     Z                                       { get; set; }
        public sbyte                                    B                                       { get; set; }
        public short                                    S                                       { get; set; }
        public int                                      I                                       { get; set; }
        public long                                     J                                       { get; set; }
        public float                                    F                                       { get; set; }
        public double                                   D                                       { get; set; }

        public static jvalue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new jvalue();

            value.Z                                         = GetBool(new IntPtr(p + 0x010)); // 027006945238 0x10 Z                           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.B                                         = GetSByte(new IntPtr(p + 0x010)); // 027006945258 0x10 B                           ( 00018665D780 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.S                                         = GetInt16(new IntPtr(p + 0x010)); // 027006945298 0x10 S                           ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 0270069452B8 0x10 I                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.J                                         = GetInt64(new IntPtr(p + 0x010)); // 0270069452D8 0x10 J                           ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.F                                         = GetSingle(new IntPtr(p + 0x010)); // 0270069452F8 0x10 F                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.D                                         = GetDouble(new IntPtr(p + 0x010)); // 027006945318 0x10 D                           ( 0001865C2E50 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
