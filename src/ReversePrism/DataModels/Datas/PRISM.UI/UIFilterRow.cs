using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleHeight                              ModelPrimitiveType float float float Single
    // 028 TitleCheckBox                            ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 UiCheckBox                               ModelClassType UICheckBox UICheckBox UICheckBox Pointer
    // 038 UiCheckBoxHeight                         ModelPrimitiveType float float float Single
    // 03C UiCheckBoxWidth                          ModelPrimitiveType float float float Single
    // 040 NumOfMemberInRow                         ModelPrimitiveType int int int Int32
    // 044 DeployPositionY                          ModelPrimitiveType float float float Single
    // 048 DeployPositionX                          ModelPrimitiveType float float float Single
    // 050 CheckBoxes                               ModelClassListType List`1<UICheckBox> List`1<UICheckBox> List<UICheckBox> Pointer
    // 058 onChangeSubject                          Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 060 RowHeight                                ModelPrimitiveType float float float Single
    public partial class UIFilterRow : DataModel
    {
        public float                                    TitleHeight                             { get; set; }
        public ToggleButton?                            TitleCheckBox                           { get; set; }
        public UICheckBox?                              UiCheckBox                              { get; set; }
        public float                                    UiCheckBoxHeight                        { get; set; }
        public float                                    UiCheckBoxWidth                         { get; set; }
        public int                                      NumOfMemberInRow                        { get; set; }
        public float                                    DeployPositionY                         { get; set; }
        public float                                    DeployPositionX                         { get; set; }
        public List<UICheckBox>?                        CheckBoxes                              { get; set; }
        public float                                    RowHeight                               { get; set; }

        public static UIFilterRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFilterRow() { Pointer= p0 };

            value.TitleHeight                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 TitleHeight                 ( ModelPrimitiveType float float float Single )
            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 TitleCheckBox               ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.UiCheckBox                                = GetObject<UICheckBox>(new IntPtr(p + 0x030), ReversePrism.DataModels.UICheckBox.FromPointer); // 0x30 UiCheckBox                  ( ModelClassType UICheckBox UICheckBox UICheckBox Pointer )
            value.UiCheckBoxHeight                          = GetSingle(new IntPtr(p + 0x038)); // 0x38 UiCheckBoxHeight            ( ModelPrimitiveType float float float Single )
            value.UiCheckBoxWidth                           = GetSingle(new IntPtr(p + 0x03C)); // 0x3C UiCheckBoxWidth             ( ModelPrimitiveType float float float Single )
            value.NumOfMemberInRow                          = GetInt32(new IntPtr(p + 0x040)); // 0x40 NumOfMemberInRow            ( ModelPrimitiveType int int int Int32 )
            value.DeployPositionY                           = GetSingle(new IntPtr(p + 0x044)); // 0x44 DeployPositionY             ( ModelPrimitiveType float float float Single )
            value.DeployPositionX                           = GetSingle(new IntPtr(p + 0x048)); // 0x48 DeployPositionX             ( ModelPrimitiveType float float float Single )
            value.CheckBoxes                                = GetObjectList<UICheckBox>(new IntPtr(p + 0x050), ReversePrism.DataModels.UICheckBox.FromPointer); // 0x50 CheckBoxes                  ( ModelClassListType List`1<UICheckBox> List`1<UICheckBox> List<UICheckBox> Pointer )
            value.RowHeight                                 = GetSingle(new IntPtr(p + 0x060)); // 0x60 RowHeight                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
