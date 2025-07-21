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
    // 018 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    public partial class MstChainUser : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static MstChainUser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainUser() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
