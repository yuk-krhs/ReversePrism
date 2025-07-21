using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _RewardItemIcon                          ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 PfIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 030 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 038 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 IconDisposable                           ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class RewardItemIcon : DataModel
    {
        public RewardItem?                              _RewardItemIcon                         { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IDisposable?                             IconDisposable                          { get; set; }

        public static RewardItemIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardItemIcon() { Pointer= p0 };

            value._RewardItemIcon                           = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 _RewardItemIcon             ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x28 PfIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x30 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IconDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 IconDisposable              ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
