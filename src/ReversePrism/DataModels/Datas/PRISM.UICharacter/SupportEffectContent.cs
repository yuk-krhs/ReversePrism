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
    public partial class SupportEffectContent : DataModel
    {
        public BoolReactiveProperty?                    AcquireRP                               { get; set; }
        public BoolReactiveProperty?                    AcquiredRP                              { get; set; }
        public int                                      SupportEffectId                         { get; set; }
        public int                                      UnlockLv                                { get; set; }

        public static SupportEffectContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectContent() { Pointer= p0 };

            value.AcquireRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665E1FF08 0x10 AcquireRP                   ( 000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.AcquiredRP                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024665E1FF28 0x18 AcquiredRP                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SupportEffectId                           = GetInt32(new IntPtr(p + 0x020)); // 024665E1FF48 0x20 SupportEffectId             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnlockLv                                  = GetInt32(new IntPtr(p + 0x024)); // 024665E1FF68 0x24 UnlockLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
