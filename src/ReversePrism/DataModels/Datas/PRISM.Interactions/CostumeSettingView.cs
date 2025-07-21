using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 IconViews                                ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer
    // 030 BlankIconViews                           ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 BtnSelectCasualCostume                   ModelClassType UIButton UIButton UIButton Pointer
    // 040 changeRadioBtnSelection                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 onSelectCasualCostume                    Subject`1<IdolBaseCostumeTargetSceneType> IL2CPP_TYPE_GENERICINST
    // 050 IsSettingCasualCostume                   ModelPrimitiveType bool bool bool Bool
    // 058 <OnIconDetail>k__BackingField            IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSettingView : DataModel
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }
        public List<CostumeIconView>?                   IconViews                               { get; set; }
        public List<GameObject>?                        BlankIconViews                          { get; set; }
        public UIButton?                                BtnSelectCasualCostume                  { get; set; }
        public bool                                     IsSettingCasualCostume                  { get; set; }

        public static CostumeSettingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSettingView() { Pointer= p0 };

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 ToggleButtonGroup           ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.IconViews                                 = GetObjectList<CostumeIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0x28 IconViews                   ( ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer )
            value.BlankIconViews                            = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 BlankIconViews              ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BtnSelectCasualCostume                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnSelectCasualCostume      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IsSettingCasualCostume                    = GetBool(new IntPtr(p + 0x050)); // 0x50 IsSettingCasualCostume      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
