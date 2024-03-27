using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstDefaultLiveCostumeSetId               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 DefaultLiveCostumeSet                    00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    public partial class MstIdol
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstDefaultLiveCostumeSetId              { get; set; }
        public MstCostumeSet?                           DefaultLiveCostumeSet                   { get; set; }

        public static MstIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstIdol();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004605800 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstDefaultLiveCostumeSetId                = GetInt32(new IntPtr(p + 0x014)); // 027004605820 0x14 MstDefaultLiveCostumeSetId  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DefaultLiveCostumeSet                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027004605840 0x18 DefaultLiveCostumeSet       ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
