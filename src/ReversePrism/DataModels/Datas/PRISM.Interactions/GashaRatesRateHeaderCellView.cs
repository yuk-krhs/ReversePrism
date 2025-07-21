using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CellMargin                               float IL2CPP_TYPE_R4
    // 038 Rect                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 BaseHeight                               ModelPrimitiveType float float float Single
    // 048 TxtRarityGroup                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtLabelProductType                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLabelNormal                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtLabelPromised                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 PromisedRateColmObjects                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class GashaRatesRateHeaderCellView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtRarityGroup                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelProductType                     { get; set; }
        public UITextMeshProUGUI?                       TxtLabelNormal                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelPromised                        { get; set; }
        public List<GameObject>?                        PromisedRateColmObjects                 { get; set; }

        public static GashaRatesRateHeaderCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRateHeaderCellView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 Rect                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x040)); // 0x40 BaseHeight                  ( ModelPrimitiveType float float float Single )
            value.TxtRarityGroup                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtRarityGroup              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelProductType                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtLabelProductType         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelNormal                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtLabelNormal              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelPromised                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtLabelPromised            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PromisedRateColmObjects                   = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 PromisedRateColmObjects     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
