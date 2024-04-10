using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Icon                                     0001866AA3B0 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 018 IsSetting                                000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 019 IsPIdolDuplicated                        000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 01A IsDuplicated                             000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 01B IsSameIdolId                             000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceSupportCharaSelectGridViewCellViewModel : DataModel
    {
        public SCharaIcon?                              Icon                                    { get; set; }
        public bool                                     IsSetting                               { get; set; }
        public bool                                     IsPIdolDuplicated                       { get; set; }
        public bool                                     IsDuplicated                            { get; set; }
        public bool                                     IsSameIdolId                            { get; set; }

        public static ProduceSupportCharaSelectGridViewCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectGridViewCellViewModel() { Pointer= p0 };

            value.Icon                                      = GetObject<SCharaIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.SCharaIcon.FromPointer); // 02466658BBD0 0x10 Icon                        ( 0001866AA3B0 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.IsSetting                                 = GetBool(new IntPtr(p + 0x018)); // 02466658BBF0 0x18 IsSetting                   ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.IsPIdolDuplicated                         = GetBool(new IntPtr(p + 0x019)); // 02466658BC10 0x19 IsPIdolDuplicated           ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.IsDuplicated                              = GetBool(new IntPtr(p + 0x01A)); // 02466658BC30 0x1A IsDuplicated                ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.IsSameIdolId                              = GetBool(new IntPtr(p + 0x01B)); // 02466658BC50 0x1B IsSameIdolId                ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
