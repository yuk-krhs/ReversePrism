using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeType                              0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 014 PartsType                                000186607E60 ModelEnumType PartsType PartsType PartsType Int32
    // 018 MstId                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Enable                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryCostumeViewModel
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
            var value   = new GalleryCostumeViewModel();

            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x010)); // 0270D6044108 0x10 CostumeType                 ( 0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.PartsType                                 = (PartsType)GetInt32(new IntPtr(p + 0x014)); // 0270D6044128 0x14 PartsType                   ( 000186607E60 ModelEnumType PartsType PartsType PartsType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D6044148 0x18 MstId                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x01C)); // 0270D6044168 0x1C Enable                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
