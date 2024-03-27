using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 DefaultTab                               000186553270 ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32
    public partial class ProduceIdolUpgradingViewParameter
    {
        public int                                      CharacterId                             { get; set; }
        public ProduceIdolUpgradeTab                    DefaultTab                              { get; set; }

        public static ProduceIdolUpgradingViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingViewParameter();

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0270D5DB1108 0x10 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DefaultTab                                = (ProduceIdolUpgradeTab)GetInt32(new IntPtr(p + 0x014)); // 0270D5DB1128 0x14 DefaultTab                  ( 000186553270 ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32 )

            return value;
        }
    }
}
