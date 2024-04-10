using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleButtonGroup                        000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 IconViews                                000185B77940 ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer
    // 030 BlankIconViews                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 BtnSelectCasualCostume                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 changeRadioBtnSelection                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 onSelectCasualCostume                    Subject`1<IdolBaseCostumeTargetSceneType> IL2CPP_TYPE_GENERICINST
    // 050 IsSettingCasualCostume                   000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466A2B5EB0 0x20 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.IconViews                                 = GetObjectList<CostumeIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeIconView.FromPointer); // 02466A2B5ED0 0x28 IconViews                   ( 000185B77940 ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer )
            value.BlankIconViews                            = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2B5EF0 0x30 BlankIconViews              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BtnSelectCasualCostume                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2B5F10 0x38 BtnSelectCasualCostume      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IsSettingCasualCostume                    = GetBool(new IntPtr(p + 0x050)); // 02466A2B5F70 0x50 IsSettingCasualCostume      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
