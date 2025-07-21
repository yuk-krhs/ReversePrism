using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 GroupId                                  ModelPrimitiveType int int int Int32
    // 018 EvolutionLevel                           ModelPrimitiveType int int int Int32
    // 020 ProductIdWithAmountList                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Money                                    ModelPrimitiveType int int int Int32
    public partial class MstProduceIdolEvolutionRecipe : DataModel
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
            var value   = new MstProduceIdolEvolutionRecipe() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.GroupId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 GroupId                     ( ModelPrimitiveType int int int Int32 )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 EvolutionLevel              ( ModelPrimitiveType int int int Int32 )
            value.ProductIdWithAmountList                   = GetStringList(new IntPtr(p + 0x020)); // 0x20 ProductIdWithAmountList     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Money                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Money                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
