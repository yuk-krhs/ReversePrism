using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ObjectPoolDefaultCapacity                int IL2CPP_TYPE_I4
    // 000 ObjectPoolMaxSize                        int IL2CPP_TYPE_I4
    // 038 Rect                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 BaseHeight                               ModelPrimitiveType float float float Single
    // 048 TxtLabelRarity                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtLabelNormal                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLabelPromised                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RowViewPrefab                            ModelClassType RarityRateTableRowView RarityRateTableRowView RarityRateTableRowView Pointer
    // 068 TrRowViewParent                          ModelClassType Transform Transform Transform Pointer
    // 070 BottomMargin                             ModelPrimitiveType float float float Single
    // 078 PromisedRateColmObjects                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 080 rowViewPool                              ObjectPool`1<RarityRateTableRowView> IL2CPP_TYPE_GENERICINST
    // 088 ActiveRowViews                           ModelClassListType List`1<RarityRateTableRowView> List`1<RarityRateTableRowView> List<RarityRateTableRowView> Pointer
    public partial class GashaRatesRarityRateTableCellView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtLabelRarity                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelNormal                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelPromised                        { get; set; }
        public RarityRateTableRowView?                  RowViewPrefab                           { get; set; }
        public Transform?                               TrRowViewParent                         { get; set; }
        public float                                    BottomMargin                            { get; set; }
        public List<GameObject>?                        PromisedRateColmObjects                 { get; set; }
        public List<RarityRateTableRowView>?            ActiveRowViews                          { get; set; }

        public static GashaRatesRarityRateTableCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRarityRateTableCellView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 Rect                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x040)); // 0x40 BaseHeight                  ( ModelPrimitiveType float float float Single )
            value.TxtLabelRarity                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtLabelRarity              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelNormal                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtLabelNormal              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelPromised                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtLabelPromised            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RowViewPrefab                             = GetObject<RarityRateTableRowView>(new IntPtr(p + 0x060), ReversePrism.DataModels.RarityRateTableRowView.FromPointer); // 0x60 RowViewPrefab               ( ModelClassType RarityRateTableRowView RarityRateTableRowView RarityRateTableRowView Pointer )
            value.TrRowViewParent                           = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 TrRowViewParent             ( ModelClassType Transform Transform Transform Pointer )
            value.BottomMargin                              = GetSingle(new IntPtr(p + 0x070)); // 0x70 BottomMargin                ( ModelPrimitiveType float float float Single )
            value.PromisedRateColmObjects                   = GetObjectList<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 PromisedRateColmObjects     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ActiveRowViews                            = GetObjectList<RarityRateTableRowView>(new IntPtr(p + 0x088), ReversePrism.DataModels.RarityRateTableRowView.FromPointer); // 0x88 ActiveRowViews              ( ModelClassListType List`1<RarityRateTableRowView> List`1<RarityRateTableRowView> List<RarityRateTableRowView> Pointer )

            return value;
        }
    }
}
