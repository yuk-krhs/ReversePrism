using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 018 CostumeType                              0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 020 <CostumeList>k__BackingField             IEnumerable`1<GalleryCostumeViewModel> IL2CPP_TYPE_GENERICINST
    // 028 Enable                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryCostumeSetViewModel : DataModel
    {
        public string                                   Name                                    { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryCostumeSetViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryCostumeSetViewModel() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0246660B4758 0x10 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x018)); // 0246660B4778 0x18 CostumeType                 ( 0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x028)); // 0246660B47B8 0x28 Enable                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
