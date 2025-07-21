using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 014 ProductKey                               ModelEnumType ProductKey ProductKey ProductKey Int32
    // 020 MstCostumeSet                            ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    public partial class GashaDetailCostumeViewModel : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public ProductKey                               ProductKey                              { get; set; }
        public MstCostumeSet?                           MstCostumeSet                           { get; set; }

        public static GashaDetailCostumeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailCostumeViewModel() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x014)); // 0x14 ProductKey                  ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.MstCostumeSet                             = GetObject<MstCostumeSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0x20 MstCostumeSet               ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
