using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 DefaultTab                               0001865F2ED0 ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32
    public partial class SupportCharaUpgradingViewParameter : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public SupportIdolUpgradeTab                    DefaultTab                              { get; set; }

        public static SupportCharaUpgradingViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingViewParameter() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 024665E21CF0 0x10 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DefaultTab                                = (SupportIdolUpgradeTab)GetInt32(new IntPtr(p + 0x014)); // 024665E21D10 0x14 DefaultTab                  ( 0001865F2ED0 ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32 )

            return value;
        }
    }
}
