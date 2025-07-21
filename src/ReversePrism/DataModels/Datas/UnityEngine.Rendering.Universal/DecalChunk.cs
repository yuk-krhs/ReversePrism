using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 014 Capacity                                 ModelPrimitiveType int int int Int32
    // 018 CurrentJobHandle                         ModelEnumType JobHandle JobHandle JobHandle Int32
    public partial class DecalChunk : DataModel
    {
        public int                                      Count                                   { get; set; }
        public int                                      Capacity                                { get; set; }
        public JobHandle                                CurrentJobHandle                        { get; set; }

        public static DecalChunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalChunk() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Capacity                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Capacity                    ( ModelPrimitiveType int int int Int32 )
            value.CurrentJobHandle                          = (JobHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentJobHandle            ( ModelEnumType JobHandle JobHandle JobHandle Int32 )

            return value;
        }
    }
}
