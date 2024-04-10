using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 028 TxtAmount                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Cg                                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 GoBadge                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 OnSelectedDisposable                     0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 OnGrayOutDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PieceIconView : DataModel
    {
        public CmnItem?                                 CmnItem                                 { get; set; }
        public UITextMeshProUGUI?                       TxtAmount                               { get; set; }
        public CanvasGroup?                             Cg                                      { get; set; }
        public GameObject?                              GoBadge                                 { get; set; }
        public IDisposable?                             OnSelectedDisposable                    { get; set; }
        public IDisposable?                             OnGrayOutDisposable                     { get; set; }

        public static PieceIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceIconView() { Pointer= p0 };

            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnItem.FromPointer); // 02466A2A3448 0x20 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtAmount                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2A3468 0x28 TxtAmount                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2A3488 0x30 Cg                          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoBadge                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2A34A8 0x38 GoBadge                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OnSelectedDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 02466A2A34C8 0x40 OnSelectedDisposable        ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnGrayOutDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 02466A2A34E8 0x48 OnGrayOutDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
