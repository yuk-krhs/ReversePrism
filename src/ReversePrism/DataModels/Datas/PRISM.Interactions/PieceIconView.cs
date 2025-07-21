using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 CgSelectedFrame                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 GoBadge                                  ModelClassType GameObject GameObject GameObject Pointer
    // 038 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 040 OnSelectedDisposable                     ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 OnGrayOutDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PieceIconView : DataModel
    {
        public RewardItem?                              RewardItem                              { get; set; }
        public CanvasGroup?                             CgSelectedFrame                         { get; set; }
        public GameObject?                              GoBadge                                 { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public IDisposable?                             OnSelectedDisposable                    { get; set; }
        public IDisposable?                             OnGrayOutDisposable                     { get; set; }

        public static PieceIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceIconView() { Pointer= p0 };

            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 RewardItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.CgSelectedFrame                           = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgSelectedFrame             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoBadge                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x38 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.OnSelectedDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 OnSelectedDisposable        ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnGrayOutDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 OnGrayOutDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
