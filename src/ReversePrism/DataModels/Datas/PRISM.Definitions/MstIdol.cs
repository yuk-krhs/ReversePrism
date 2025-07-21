using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstDefaultLiveCostumeSetId               ModelPrimitiveType int int int Int32
    // 018 DefaultLiveCostumeSet                    ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    public partial class MstIdol : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstDefaultLiveCostumeSetId              { get; set; }
        public MstCostumeSet?                           DefaultLiveCostumeSet                   { get; set; }

        public static MstIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstIdol() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstDefaultLiveCostumeSetId                = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstDefaultLiveCostumeSetId  ( ModelPrimitiveType int int int Int32 )
            value.DefaultLiveCostumeSet                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0x18 DefaultLiveCostumeSet       ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )

            return value;
        }
    }
}
