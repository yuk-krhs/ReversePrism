using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 CostumeType                              ModelPrimitiveType int int int Int32
    // 020 RecipeList                               ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstDressOrderRecipe : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      CostumeType                             { get; set; }
        public List<string>?                            RecipeList                              { get; set; }

        public static MstDressOrderRecipe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstDressOrderRecipe() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CostumeType                 ( ModelPrimitiveType int int int Int32 )
            value.RecipeList                                = GetStringList(new IntPtr(p + 0x020)); // 0x20 RecipeList                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
