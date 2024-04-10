using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcquireRP                                000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 AcquiredRP                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 020 SupportEffectId                          0001865F4260 ModelPrimitiveType int int int Int32
    // 024 UnlockLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class SupportEffectContentViewModel : DataModel
    {
        public BoolReactiveProperty?                    AcquireRP                               { get; set; }
        public BoolReactiveProperty?                    AcquiredRP                              { get; set; }
        public int                                      SupportEffectId                         { get; set; }
        public int                                      UnlockLv                                { get; set; }

        public static SupportEffectContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContentViewModel() { Pointer= p0 };

            value.AcquireRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466600C700 0x10 AcquireRP                   ( 000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.AcquiredRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 02466600C720 0x18 AcquiredRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SupportEffectId                           = GetInt32(new IntPtr(p + 0x020)); // 02466600C740 0x20 SupportEffectId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnlockLv                                  = GetInt32(new IntPtr(p + 0x024)); // 02466600C760 0x24 UnlockLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
