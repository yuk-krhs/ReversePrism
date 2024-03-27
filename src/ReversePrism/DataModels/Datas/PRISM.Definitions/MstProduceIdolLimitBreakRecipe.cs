using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Star                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Amount                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstProduceIdolLimitBreakRecipe
    {
        public int                                      Id                                      { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      Amount                                  { get; set; }

        public static MstProduceIdolLimitBreakRecipe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceIdolLimitBreakRecipe();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045CD4C8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x014)); // 0270045CD4E8 0x14 Star                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x018)); // 0270045CD508 0x18 Amount                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
