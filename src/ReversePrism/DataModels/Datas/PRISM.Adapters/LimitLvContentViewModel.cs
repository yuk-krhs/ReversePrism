using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReachRP                                  000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 ReachedRP                                0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 UnlockDiamondLv                          0001865F4260 ModelPrimitiveType int int int Int32
    // 024 BeforeLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 028 AfterLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 02C UnlockSkillSlot                          0001865F4260 ModelPrimitiveType int int int Int32
    public partial class LimitLvContentViewModel : DataModel
    {
        public BoolReactiveProperty?                    ReachRP                                 { get; set; }
        public BoolReactiveProperty?                    ReachedRP                               { get; set; }
        public int                                      UnlockDiamondLv                         { get; set; }
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public int                                      UnlockSkillSlot                         { get; set; }

        public static LimitLvContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitLvContentViewModel() { Pointer= p0 };

            value.ReachRP                                   = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466617E700 0x10 ReachRP                     ( 000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.ReachedRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466617E720 0x18 ReachedRP                   ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.UnlockDiamondLv                           = GetInt32(new IntPtr(p + 0x020)); // 02466617E740 0x20 UnlockDiamondLv             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x024)); // 02466617E760 0x24 BeforeLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x028)); // 02466617E780 0x28 AfterLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnlockSkillSlot                           = GetInt32(new IntPtr(p + 0x02C)); // 02466617E7A0 0x2C UnlockSkillSlot             ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
