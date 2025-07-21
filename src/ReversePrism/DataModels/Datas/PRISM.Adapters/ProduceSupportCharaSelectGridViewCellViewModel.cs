using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Icon                                     ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 018 IsSetting                                ModelPrimitiveType bool bool bool Bool
    // 019 IsPIdolDuplicated                        ModelPrimitiveType bool bool bool Bool
    // 01A IsDuplicated                             ModelPrimitiveType bool bool bool Bool
    // 01B IsDuplicatedFriend                       ModelPrimitiveType bool bool bool Bool
    // 01C IsSameIdolId                             ModelPrimitiveType bool bool bool Bool
    public partial class ProduceSupportCharaSelectGridViewCellViewModel : DataModel
    {
        public SCharaIcon?                              Icon                                    { get; set; }
        public bool                                     IsSetting                               { get; set; }
        public bool                                     IsPIdolDuplicated                       { get; set; }
        public bool                                     IsDuplicated                            { get; set; }
        public bool                                     IsDuplicatedFriend                      { get; set; }
        public bool                                     IsSameIdolId                            { get; set; }

        public static ProduceSupportCharaSelectGridViewCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectGridViewCellViewModel() { Pointer= p0 };

            value.Icon                                      = GetObject<SCharaIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x10 Icon                        ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.IsSetting                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSetting                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsPIdolDuplicated                         = GetBool(new IntPtr(p + 0x019)); // 0x19 IsPIdolDuplicated           ( ModelPrimitiveType bool bool bool Bool )
            value.IsDuplicated                              = GetBool(new IntPtr(p + 0x01A)); // 0x1A IsDuplicated                ( ModelPrimitiveType bool bool bool Bool )
            value.IsDuplicatedFriend                        = GetBool(new IntPtr(p + 0x01B)); // 0x1B IsDuplicatedFriend          ( ModelPrimitiveType bool bool bool Bool )
            value.IsSameIdolId                              = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsSameIdolId                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
