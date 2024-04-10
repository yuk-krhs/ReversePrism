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
    // 018 Diamond                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Amount                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSupportCharacterLimitBreakRecipe : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      Rarity                                  { get; set; }
        public int                                      Diamond                                 { get; set; }
        public int                                      Amount                                  { get; set; }

        public static MstSupportCharacterLimitBreakRecipe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportCharacterLimitBreakRecipe() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46E4158 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rarity                                    = GetInt32(new IntPtr(p + 0x014)); // 0245A46E4178 0x14 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Diamond                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A46E4198 0x18 Diamond                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A46E41B8 0x1C Amount                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
