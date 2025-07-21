using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 DefaultTab                               ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32
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

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.DefaultTab                                = (SupportIdolUpgradeTab)GetInt32(new IntPtr(p + 0x014)); // 0x14 DefaultTab                  ( ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32 )

            return value;
        }
    }
}
