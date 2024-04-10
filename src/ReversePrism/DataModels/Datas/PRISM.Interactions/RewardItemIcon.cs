using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _RewardItemIcon                          00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 PfIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 030 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 IconDisposable                           0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 PIdolDetail                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 050 SCharaDetail                             0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class RewardItemIcon : DataModel
    {
        public RewardItem?                              _RewardItemIcon                         { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IDisposable?                             IconDisposable                          { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetail                             { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetail                            { get; set; }

        public static RewardItemIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardItemIcon() { Pointer= p0 };

            value._RewardItemIcon                           = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 024665563FA0 0x20 _RewardItemIcon             ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 024665563FC0 0x28 PfIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconView.FromPointer); // 024665563FE0 0x30 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665564000 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IconDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 024665564020 0x40 IconDisposable              ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.PIdolDetail                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 024665564040 0x48 PIdolDetail                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetail                              = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 024665564060 0x50 SCharaDetail                ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
