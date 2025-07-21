using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<IReadOnlyList`1<string>> IL2CPP_TYPE_GENERICINST
    // 028 onClickEndButton                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onClickResetButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onClickRankUpButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 GridView                                 ModelClassType PCardRankUpGridView PCardRankUpGridView PCardRankUpGridView Pointer
    // 048 RankUpCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 HavingCardAmountText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PCardRankUpPopupView : DataModel
    {
        public PCardRankUpGridView?                     GridView                                { get; set; }
        public UITextMeshProUGUI?                       RankUpCountText                         { get; set; }
        public UITextMeshProUGUI?                       HavingCardAmountText                    { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PCardRankUpPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<PCardRankUpGridView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PCardRankUpGridView.FromPointer); // 0x40 GridView                    ( ModelClassType PCardRankUpGridView PCardRankUpGridView PCardRankUpGridView Pointer )
            value.RankUpCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 RankUpCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HavingCardAmountText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 HavingCardAmountText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
