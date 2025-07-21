using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DstOffset                                ModelPrimitiveType int int int Int32
    // 014 AddData                                  ModelPrimitiveType int int int Int32
    // 018 srcData                                  NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 dstData                                  NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AddIntDataCopyJob : DataModel
    {
        public int                                      DstOffset                               { get; set; }
        public int                                      AddData                                 { get; set; }

        public static AddIntDataCopyJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddIntDataCopyJob() { Pointer= p0 };

            value.DstOffset                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 DstOffset                   ( ModelPrimitiveType int int int Int32 )
            value.AddData                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 AddData                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
