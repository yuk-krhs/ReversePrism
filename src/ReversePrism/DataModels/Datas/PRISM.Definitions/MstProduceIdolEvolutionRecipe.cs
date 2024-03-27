using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 GroupId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EvolutionLevel                           0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ProductIdWithAmountList                  000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Money                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstProduceIdolEvolutionRecipe
    {
        public int                                      Id                                      { get; set; }
        public int                                      GroupId                                 { get; set; }
        public int                                      EvolutionLevel                          { get; set; }
        public List<string>?                            ProductIdWithAmountList                 { get; set; }
        public int                                      Money                                   { get; set; }

        public static MstProduceIdolEvolutionRecipe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProduceIdolEvolutionRecipe();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045C8300 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GroupId                                   = GetInt32(new IntPtr(p + 0x014)); // 0270045C8320 0x14 GroupId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x018)); // 0270045C8340 0x18 EvolutionLevel              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProductIdWithAmountList                   = GetStringList(new IntPtr(p + 0x020)); // 0270045C8360 0x20 ProductIdWithAmountList     ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Money                                     = GetInt32(new IntPtr(p + 0x028)); // 0270045C8380 0x28 Money                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
