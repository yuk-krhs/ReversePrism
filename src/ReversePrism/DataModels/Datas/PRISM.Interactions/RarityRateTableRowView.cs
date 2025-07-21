using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rect                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 TxtRarity                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtNormalRate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtPromisedRate                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BgBlue                                   ModelClassType GameObject GameObject GameObject Pointer
    // 048 BgWhite                                  ModelClassType GameObject GameObject GameObject Pointer
    // 050 PromisedRateColmObjects                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class RarityRateTableRowView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public UITextMeshProUGUI?                       TxtRarity                               { get; set; }
        public UITextMeshProUGUI?                       TxtNormalRate                           { get; set; }
        public UITextMeshProUGUI?                       TxtPromisedRate                         { get; set; }
        public GameObject?                              BgBlue                                  { get; set; }
        public GameObject?                              BgWhite                                 { get; set; }
        public List<GameObject>?                        PromisedRateColmObjects                 { get; set; }

        public static RarityRateTableRowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RarityRateTableRowView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Rect                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TxtRarity                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtRarity                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtNormalRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtNormalRate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPromisedRate                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtPromisedRate             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BgBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 BgBlue                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BgWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 BgWhite                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PromisedRateColmObjects                   = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 PromisedRateColmObjects     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
