using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 RewardItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 038 <OnLongPressProduct>k__BackingField      Subject`1<ProductKey> IL2CPP_TYPE_GENERICINST
    // 040 OnClickDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaProductItemView : DataModel
    {
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public RewardItem?                              RewardItem                              { get; set; }
        public IDisposable?                             OnClickDisposable                       { get; set; }

        public static GashaProductItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProductItemView() { Pointer= p0 };

            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 PFIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x28 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItem.FromPointer); // 0x30 RewardItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 OnClickDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
