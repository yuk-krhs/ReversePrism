using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       0001865F4940 ModelPrimitiveType int int int Int32
    // 014 ProductKey                               0001865A2870 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 020 MstCostumeSet                            00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    public partial class GashaDetailCostumeViewModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public ProductKey                               ProductKey                              { get; set; }
        public MstCostumeSet?                           MstCostumeSet                           { get; set; }

        public static GashaDetailCostumeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailCostumeViewModel();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D634B138 0x10 MstCharacterInfoId          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x014)); // 0270D634B158 0x14 ProductKey                  ( 0001865A2870 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.MstCostumeSet                             = GetObject<MstCostumeSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0270D634B178 0x20 MstCostumeSet               ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
