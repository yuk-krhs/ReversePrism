using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vocal                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Dance                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Visual                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Mental                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IngamePlayerStatusModel
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
            var value   = new IngamePlayerStatusModel();

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D5A89EE8 0x10 Vocal                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D5A89F08 0x14 Dance                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5A89F28 0x18 Visual                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D5A89F48 0x1C Mental                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
