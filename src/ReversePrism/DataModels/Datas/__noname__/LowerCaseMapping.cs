using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChMin                                    char IL2CPP_TYPE_CHAR
    // 012 ChMax                                    char IL2CPP_TYPE_CHAR
    // 014 LcOp                                     0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Data                                     0001865F4940 ModelPrimitiveType int int int Int32
    public partial class LowerCaseMapping
    {
        public int                                      LcOp                                    { get; set; }
        public int                                      Data                                    { get; set; }

        public static LowerCaseMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LowerCaseMapping();

            value.LcOp                                      = GetInt32(new IntPtr(p + 0x014)); // 027003431768 0x14 LcOp                        ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetInt32(new IntPtr(p + 0x018)); // 027003431788 0x18 Data                        ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
