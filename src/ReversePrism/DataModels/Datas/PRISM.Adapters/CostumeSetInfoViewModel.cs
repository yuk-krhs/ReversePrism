using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCostumeSetId                          ModelPrimitiveType int int int Int32
    // 014 StarLv                                   ModelPrimitiveType int int int Int32
    // 018 Unlocked                                 ModelPrimitiveType bool bool bool Bool
    // 01C MstCostumeId                             ModelPrimitiveType int int int Int32
    // 020 MstHairStyleId                           ModelPrimitiveType int int int Int32
    // 028 <MstAccessoryIdList>k__BackingField      IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSetInfoViewModel : DataModel
    {
        public int                                      MstCostumeSetId                         { get; set; }
        public int                                      StarLv                                  { get; set; }
        public bool                                     Unlocked                                { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairStyleId                          { get; set; }

        public static CostumeSetInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetInfoViewModel() { Pointer= p0 };

            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )
            value.StarLv                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 StarLv                      ( ModelPrimitiveType int int int Int32 )
            value.Unlocked                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Unlocked                    ( ModelPrimitiveType bool bool bool Bool )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstHairStyleId                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstHairStyleId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
