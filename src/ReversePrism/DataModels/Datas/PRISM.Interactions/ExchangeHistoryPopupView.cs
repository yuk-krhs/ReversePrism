using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemListContent                          ModelClassType Transform Transform Transform Pointer
    // 030 ListScrollBar                            ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 038 ItemViewPrefab                           ModelClassType GameObject GameObject GameObject Pointer
    // 040 EmptyViewTextObj                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onClickHistoryItem                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeHistoryPopupView : DataModel
    {
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public Transform?                               ItemListContent                         { get; set; }
        public Scrollbar?                               ListScrollBar                           { get; set; }
        public GameObject?                              ItemViewPrefab                          { get; set; }
        public GameObject?                              EmptyViewTextObj                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeHistoryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryPopupView() { Pointer= p0 };

            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemListContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemListContent             ( ModelClassType Transform Transform Transform Pointer )
            value.ListScrollBar                             = GetObject<Scrollbar>(new IntPtr(p + 0x030), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x30 ListScrollBar               ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.ItemViewPrefab                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ItemViewPrefab              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewTextObj                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 EmptyViewTextObj            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
