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
    // 038 Rect                                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 BaseHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 048 TxtLabelRarity                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtLabelNormal                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLabelPromised                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RowViewPrefab                            000186611630 ModelClassType RarityRateTableRowView RarityRateTableRowView RarityRateTableRowView Pointer
    // 068 TrRowViewParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 070 rowViewPool                              ObjectPool`1<RarityRateTableRowView> IL2CPP_TYPE_GENERICINST
    // 078 ActiveRowViews                           000185CFF798 ModelClassListType List`1<RarityRateTableRowView> List`1<RarityRateTableRowView> List<RarityRateTableRowView> Pointer
    public partial class StepUpGashaRatesRarityRateTableCellView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtLabelRarity                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelNormal                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelPromised                        { get; set; }
        public RarityRateTableRowView?                  RowViewPrefab                           { get; set; }
        public Transform?                               TrRowViewParent                         { get; set; }
        public List<RarityRateTableRowView>?            ActiveRowViews                          { get; set; }

        public static StepUpGashaRatesRarityRateTableCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesRarityRateTableCellView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466BA9B928 0x38 Rect                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x040)); // 02466BA9B948 0x40 BaseHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TxtLabelRarity                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9B968 0x48 TxtLabelRarity              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelNormal                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9B988 0x50 TxtLabelNormal              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelPromised                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9B9A8 0x58 TxtLabelPromised            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RowViewPrefab                             = GetObject<RarityRateTableRowView>(new IntPtr(p + 0x060), ReversePrism.DataModels.RarityRateTableRowView.FromPointer); // 02466BA9B9C8 0x60 RowViewPrefab               ( 000186611630 ModelClassType RarityRateTableRowView RarityRateTableRowView RarityRateTableRowView Pointer )
            value.TrRowViewParent                           = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 02466BA9B9E8 0x68 TrRowViewParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ActiveRowViews                            = GetObjectList<RarityRateTableRowView>(new IntPtr(p + 0x078), ReversePrism.DataModels.RarityRateTableRowView.FromPointer); // 02466BA9BA28 0x78 ActiveRowViews              ( 000185CFF798 ModelClassListType List`1<RarityRateTableRowView> List`1<RarityRateTableRowView> List<RarityRateTableRowView> Pointer )

            return value;
        }
    }
}
