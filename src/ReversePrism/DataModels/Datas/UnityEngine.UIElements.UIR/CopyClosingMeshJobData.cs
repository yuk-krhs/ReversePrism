using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 vertSrc                                  <int> IL2CPP_TYPE_I
    // 018 vertDst                                  <int> IL2CPP_TYPE_I
    // 020 VertCount                                ModelPrimitiveType int int int Int32
    // 028 indexSrc                                 <int> IL2CPP_TYPE_I
    // 030 indexDst                                 <int> IL2CPP_TYPE_I
    // 038 IndexCount                               ModelPrimitiveType int int int Int32
    // 03C IndexOffset                              ModelPrimitiveType int int int Int32
    public partial class CopyClosingMeshJobData : DataModel
    {
        public int                                      VertCount                               { get; set; }
        public int                                      IndexCount                              { get; set; }
        public int                                      IndexOffset                             { get; set; }

        public static CopyClosingMeshJobData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CopyClosingMeshJobData() { Pointer= p0 };

            value.VertCount                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 VertCount                   ( ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.IndexOffset                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C IndexOffset                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
