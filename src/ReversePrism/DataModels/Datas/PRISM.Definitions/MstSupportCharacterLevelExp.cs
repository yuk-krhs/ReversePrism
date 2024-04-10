using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Level                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Exp                                      0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSupportCharacterLevelExp : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      Rarity                                  { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      Exp                                     { get; set; }

        public static MstSupportCharacterLevelExp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportCharacterLevelExp() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A469EE48 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x014)); // 0245A469EE68 0x14 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A469EE88 0x18 Level                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x01C)); // 0245A469EEA8 0x1C Exp                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
