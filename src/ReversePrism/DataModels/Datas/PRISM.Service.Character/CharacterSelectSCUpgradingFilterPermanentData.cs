using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanMasterTraining                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 CanTraining                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CharacterSelectSCUpgradingFilterPermanentData
    {
        public bool                                     CanMasterTraining                       { get; set; }
        public bool                                     CanTraining                             { get; set; }

        public static CharacterSelectSCUpgradingFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectSCUpgradingFilterPermanentData();

            value.CanMasterTraining                         = GetBool(new IntPtr(p + 0x010)); // 027003A6BBD0 0x10 CanMasterTraining           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x011)); // 027003A6BBF0 0x11 CanTraining                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
