using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 TxtLv                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TrRewardParent                           ModelClassType Transform Transform Transform Pointer
    // 050 VerticalLayoutGroup                      ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer
    // 058 GoArchived                               ModelClassType GameObject GameObject GameObject Pointer
    // 060 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 068 itemColumnPool                           ObjectPool`1<RewardItemColumn> IL2CPP_TYPE_GENERICINST
    // 070 statusColumnPool                         ObjectPool`1<RewardStatusColumn> IL2CPP_TYPE_GENERICINST
    // 078 borderLinePool                           ObjectPool`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 080 ActiveItemColumns                        ModelClassListType List`1<RewardItemColumn> List`1<RewardItemColumn> List<RewardItemColumn> Pointer
    // 088 ActiveStatusColumns                      ModelClassListType List`1<RewardStatusColumn> List`1<RewardStatusColumn> List<RewardStatusColumn> Pointer
    // 090 ActiveBorderLines                        ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class RewardCellView : DataModel
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
            var value   = new RewardCellView() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtLv                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrRewardParent                            = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 TrRewardParent              ( ModelClassType Transform Transform Transform Pointer )
            value.VerticalLayoutGroup                       = GetObject<VerticalLayoutGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.VerticalLayoutGroup.FromPointer); // 0x50 VerticalLayoutGroup         ( ModelClassType VerticalLayoutGroup VerticalLayoutGroup VerticalLayoutGroup Pointer )
            value.GoArchived                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoArchived                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x60 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ActiveItemColumns                         = GetObjectList<RewardItemColumn>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItemColumn.FromPointer); // 0x80 ActiveItemColumns           ( ModelClassListType List`1<RewardItemColumn> List`1<RewardItemColumn> List<RewardItemColumn> Pointer )
            value.ActiveStatusColumns                       = GetObjectList<RewardStatusColumn>(new IntPtr(p + 0x088), ReversePrism.DataModels.RewardStatusColumn.FromPointer); // 0x88 ActiveStatusColumns         ( ModelClassListType List`1<RewardStatusColumn> List`1<RewardStatusColumn> List<RewardStatusColumn> Pointer )
            value.ActiveBorderLines                         = GetObjectList<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 ActiveBorderLines           ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
