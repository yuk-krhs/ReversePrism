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
    // 048 TxtRarityGroup                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtLabelRarity                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLabelChara                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtLabelNormal                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtLabelPromised                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 RowViewPrefab                            000186612230 ModelClassType RateTableRowView RateTableRowView RateTableRowView Pointer
    // 078 TrRowViewParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 080 rowViewPool                              ObjectPool`1<RateTableRowView> IL2CPP_TYPE_GENERICINST
    // 088 ActiveRowViews                           000185CFFA08 ModelClassListType List`1<RateTableRowView> List`1<RateTableRowView> List<RateTableRowView> Pointer
    public partial class StepUpGashaRatesRateTableCellView : DataModel
    {
        public RectTransform?                           Rect                                    { get; set; }
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtRarityGroup                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelRarity                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelChara                           { get; set; }
        public UITextMeshProUGUI?                       TxtLabelNormal                          { get; set; }
        public UITextMeshProUGUI?                       TxtLabelPromised                        { get; set; }
        public RateTableRowView?                        RowViewPrefab                           { get; set; }
        public Transform?                               TrRowViewParent                         { get; set; }
        public List<RateTableRowView>?                  ActiveRowViews                          { get; set; }

        public static StepUpGashaRatesRateTableCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesRateTableCellView() { Pointer= p0 };

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466BAA9E40 0x38 Rect                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x040)); // 02466BAA9E60 0x40 BaseHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TxtRarityGroup                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BAA9E80 0x48 TxtRarityGroup              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelRarity                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BAA9EA0 0x50 TxtLabelRarity              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelChara                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BAA9EC0 0x58 TxtLabelChara               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelNormal                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BAA9EE0 0x60 TxtLabelNormal              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLabelPromised                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BAA9F00 0x68 TxtLabelPromised            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RowViewPrefab                             = GetObject<RateTableRowView>(new IntPtr(p + 0x070), ReversePrism.DataModels.RateTableRowView.FromPointer); // 02466BAA9F20 0x70 RowViewPrefab               ( 000186612230 ModelClassType RateTableRowView RateTableRowView RateTableRowView Pointer )
            value.TrRowViewParent                           = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 02466BAA9F40 0x78 TrRowViewParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ActiveRowViews                            = GetObjectList<RateTableRowView>(new IntPtr(p + 0x088), ReversePrism.DataModels.RateTableRowView.FromPointer); // 02466BAA9F80 0x88 ActiveRowViews              ( 000185CFFA08 ModelClassListType List`1<RateTableRowView> List`1<RateTableRowView> List<RateTableRowView> Pointer )

            return value;
        }
    }
}
