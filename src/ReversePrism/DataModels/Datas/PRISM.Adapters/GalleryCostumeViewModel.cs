using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeType                              ModelEnumType CostumeType CostumeType CostumeType Int32
    // 014 PartsType                                ModelEnumType PartsType PartsType PartsType Int32
    // 018 MstId                                    ModelPrimitiveType int int int Int32
    // 01C Enable                                   ModelPrimitiveType bool bool bool Bool
    public partial class GalleryCostumeViewModel : DataModel
    {
        public CostumeType                              CostumeType                             { get; set; }
        public PartsType                                PartsType                               { get; set; }
        public int                                      MstId                                   { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryCostumeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryCostumeViewModel() { Pointer= p0 };

            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x010)); // 0x10 CostumeType                 ( ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.PartsType                                 = (PartsType)GetInt32(new IntPtr(p + 0x014)); // 0x14 PartsType                   ( ModelEnumType PartsType PartsType PartsType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstId                       ( ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C Enable                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
