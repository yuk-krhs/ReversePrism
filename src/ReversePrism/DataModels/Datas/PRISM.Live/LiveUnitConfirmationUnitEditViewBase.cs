using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UNIT_NAME_MAX_LENGTH                     int IL2CPP_TYPE_I4
    // 020 DefaultBackground                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 SpecialBackground                        ModelClassType GameObject GameObject GameObject Pointer
    // 030 OpenUnitListButton                       ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 UnitNameInputField                       ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 ResetButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 SwitchContentTabGroup                    ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 050 TabContentParents                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 UseRecommendedButton                     ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 NormalCostumeView                        ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer
    // 068 SummerCostumeView                        ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer
    // 070 CurrentCostumeView                       ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer
    public partial class LiveUnitConfirmationUnitEditViewBase : DataModel
    {
        public GameObject?                              DefaultBackground                       { get; set; }
        public GameObject?                              SpecialBackground                       { get; set; }
        public ButtonBase?                              OpenUnitListButton                      { get; set; }
        public CommonInputFieldTMP?                     UnitNameInputField                      { get; set; }
        public ButtonBase?                              ResetButton                             { get; set; }
        public UITabGroupEx?                            SwitchContentTabGroup                   { get; set; }
        public List<GameObject>?                        TabContentParents                       { get; set; }
        public ButtonBase?                              UseRecommendedButton                    { get; set; }
        public LiveUnitEditCostumeView?                 NormalCostumeView                       { get; set; }
        public LiveUnitEditCostumeView?                 SummerCostumeView                       { get; set; }
        public LiveUnitEditCostumeView?                 CurrentCostumeView                      { get; set; }

        public static LiveUnitConfirmationUnitEditViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationUnitEditViewBase() { Pointer= p0 };

            value.DefaultBackground                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 DefaultBackground           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackground                         = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 SpecialBackground           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OpenUnitListButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 OpenUnitListButton          ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitNameInputField                        = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x38 UnitNameInputField          ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ResetButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 ResetButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SwitchContentTabGroup                     = GetObject<UITabGroupEx>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x48 SwitchContentTabGroup       ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.TabContentParents                         = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 TabContentParents           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UseRecommendedButton                      = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 UseRecommendedButton        ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.NormalCostumeView                         = GetObject<LiveUnitEditCostumeView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveUnitEditCostumeView.FromPointer); // 0x60 NormalCostumeView           ( ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer )
            value.SummerCostumeView                         = GetObject<LiveUnitEditCostumeView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveUnitEditCostumeView.FromPointer); // 0x68 SummerCostumeView           ( ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer )
            value.CurrentCostumeView                        = GetObject<LiveUnitEditCostumeView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveUnitEditCostumeView.FromPointer); // 0x70 CurrentCostumeView          ( ModelClassType LiveUnitEditCostumeView LiveUnitEditCostumeView LiveUnitEditCostumeView Pointer )

            return value;
        }
    }
}
