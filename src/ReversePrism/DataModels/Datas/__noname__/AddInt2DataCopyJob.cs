using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DstOffset                                ModelPrimitiveType int int int Int32
    // 014 AddData                                  ModelEnumType int2 int2 int2 Int32
    // 020 srcData                                  NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 030 dstData                                  NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    public partial class AddInt2DataCopyJob : DataModel
    {
        public int                                      DstOffset                               { get; set; }
        public int2                                     AddData                                 { get; set; }

        public static AddInt2DataCopyJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddInt2DataCopyJob() { Pointer= p0 };

            value.DstOffset                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 DstOffset                   ( ModelPrimitiveType int int int Int32 )
            value.AddData                                   = (int2)GetInt32(new IntPtr(p + 0x014)); // 0x14 AddData                     ( ModelEnumType int2 int2 int2 Int32 )

            return value;
        }
    }
}
