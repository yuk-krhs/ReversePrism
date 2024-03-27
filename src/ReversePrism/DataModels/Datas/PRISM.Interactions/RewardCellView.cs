using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TrRewardParent                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 VerticalLayoutGroup                      000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 058 GoArchived                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 068 itemColumnPool                           ObjectPool`1<RewardItemColumn> IL2CPP_TYPE_GENERICINST
    // 070 statusColumnPool                         ObjectPool`1<RewardStatusColumn> IL2CPP_TYPE_GENERICINST
    // 078 borderLinePool                           ObjectPool`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 080 ActiveItemColumns                        000185D03978 ModelClassListType List`1<RewardItemColumn> List`1<RewardItemColumn> List<RewardItemColumn> Pointer
    // 088 ActiveStatusColumns                      000185D03BC8 ModelClassListType List`1<RewardStatusColumn> List`1<RewardStatusColumn> List<RewardStatusColumn> Pointer
    // 090 ActiveBorderLines                        000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class RewardCellView
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public Transform?                               TrRewardParent                          { get; set; }
        public VerticalLayoutGroup?                     VerticalLayoutGroup                     { get; set; }
        public GameObject?                              GoArchived                              { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public List<RewardItemColumn>?                  ActiveItemColumns                       { get; set; }
        public List<RewardStatusColumn>?                ActiveStatusColumns                     { get; set; }
        public List<GameObject>?                        ActiveBorderLines                       { get; set; }

        public static RewardCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardCellView();

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA3187C8 0x38 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3187E8 0x40 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrRewardParent                            = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0270DA318808 0x48 TrRewardParent              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.VerticalLayoutGroup                       = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0270DA318828 0x50 VerticalLayoutGroup         ( 000186515B70 ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.GoArchived                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA318848 0x58 GoArchived                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA318868 0x60 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ActiveItemColumns                         = GetObjectList<RewardItemColumn>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItemColumn.FromPointer); // 0270DA3188E8 0x80 ActiveItemColumns           ( 000185D03978 ModelClassListType List`1<RewardItemColumn> List`1<RewardItemColumn> List<RewardItemColumn> Pointer )
            value.ActiveStatusColumns                       = GetObjectList<RewardStatusColumn>(new IntPtr(p + 0x088), ReversePrism.DataModels.RewardStatusColumn.FromPointer); // 0270DA318908 0x88 ActiveStatusColumns         ( 000185D03BC8 ModelClassListType List`1<RewardStatusColumn> List`1<RewardStatusColumn> List<RewardStatusColumn> Pointer )
            value.ActiveBorderLines                         = GetObjectList<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA318928 0x90 ActiveBorderLines           ( 000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
