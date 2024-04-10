using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001865E8C40 ModelClassType SupportCharaUpgradingViewParameter SupportCharaUpgradingViewParameter SupportCharaUpgradingViewParameter Pointer
    public partial class SupportCharaUpgradingArgument : DataModel
    {
        public SupportCharaUpgradingViewParameter?      JumpParam                               { get; set; }

        public static SupportCharaUpgradingArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<SupportCharaUpgradingViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportCharaUpgradingViewParameter.FromPointer); // 0246660CCF40 0x10 JumpParam                   ( 0001865E8C40 ModelClassType SupportCharaUpgradingViewParameter SupportCharaUpgradingViewParameter SupportCharaUpgradingViewParameter Pointer )

            return value;
        }
    }
}
