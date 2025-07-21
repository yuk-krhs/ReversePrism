using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Z                                        ModelPrimitiveType bool bool bool Bool
    // 010 B                                        ModelPrimitiveType sbyte sbyte sbyte SByte
    // 010 c                                        char IL2CPP_TYPE_CHAR
    // 010 S                                        ModelPrimitiveType short short short Int16
    // 010 I                                        ModelPrimitiveType int int int Int32
    // 010 J                                        ModelPrimitiveType long long long Int64
    // 010 F                                        ModelPrimitiveType float float float Single
    // 010 D                                        ModelPrimitiveType double double double Double
    // 010 l                                        <int> IL2CPP_TYPE_I
    public partial class jvalue : DataModel
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
            var value   = new jvalue() { Pointer= p0 };

            value.Z                                         = GetBool(new IntPtr(p + 0x010)); // 0x10 Z                           ( ModelPrimitiveType bool bool bool Bool )
            value.B                                         = GetSByte(new IntPtr(p + 0x010)); // 0x10 B                           ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.S                                         = GetInt16(new IntPtr(p + 0x010)); // 0x10 S                           ( ModelPrimitiveType short short short Int16 )
            value.I                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 I                           ( ModelPrimitiveType int int int Int32 )
            value.J                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 J                           ( ModelPrimitiveType long long long Int64 )
            value.F                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 F                           ( ModelPrimitiveType float float float Single )
            value.D                                         = GetDouble(new IntPtr(p + 0x010)); // 0x10 D                           ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
