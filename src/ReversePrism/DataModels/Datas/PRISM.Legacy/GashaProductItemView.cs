using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 038 <OnLongPressProduct>k__BackingField      Subject`1<ProductKey> IL2CPP_TYPE_GENERICINST
    // 040 OnClickDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaProductItemView
    {
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public CmnItem?                                 CmnItem                                 { get; set; }
        public IDisposable?                             OnClickDisposable                       { get; set; }

        public static GashaProductItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProductItemView();

            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D5DFA640 0x20 PFIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5DFA660 0x28 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D5DFA680 0x30 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5DFA6C0 0x40 OnClickDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
