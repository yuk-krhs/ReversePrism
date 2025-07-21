using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vocal                                    ModelPrimitiveType int int int Int32
    // 014 Dance                                    ModelPrimitiveType int int int Int32
    // 018 Visual                                   ModelPrimitiveType int int int Int32
    // 01C Mental                                   ModelPrimitiveType int int int Int32
    public partial class IngamePlayerStatusModel : DataModel
    {
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }

        public static IngamePlayerStatusModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePlayerStatusModel() { Pointer= p0 };

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vocal                       ( ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Dance                       ( ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Visual                      ( ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Mental                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
