using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChunkIndex                               ModelPrimitiveType int int int Int32
    // 014 ArrayIndex                               ModelPrimitiveType int int int Int32
    // 018 Version                                  ModelPrimitiveType int int int Int32
    public partial class DecalEntityItem : DataModel
    {
        public int                                      ChunkIndex                              { get; set; }
        public int                                      ArrayIndex                              { get; set; }
        public int                                      Version                                 { get; set; }

        public static DecalEntityItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalEntityItem() { Pointer= p0 };

            value.ChunkIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChunkIndex                  ( ModelPrimitiveType int int int Int32 )
            value.ArrayIndex                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 ArrayIndex                  ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
