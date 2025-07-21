using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  ModelClassType Graphic Graphic Graphic Pointer
    // 028 ProducePointText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SkillLimitPanel                          ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer
    // 038 SkillButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 NotEnoughPPColor                         ModelEnumType Color Color Color Int32
    // 058 NotAvailableColor                        ModelEnumType Color Color Color Int32
    // 068 IsAvailable                              ModelPrimitiveType bool bool bool Bool
    // 070 EffectPoint                              ModelClassType Transform Transform Transform Pointer
    public partial class SkillContentBase : DataModel
    {
        public Graphic?                                 BgImage                                 { get; set; }
        public UITextMeshProUGUI?                       ProducePointText                        { get; set; }
        public SkillLimitPanel?                         SkillLimitPanel                         { get; set; }
        public UIButton?                                SkillButton                             { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public Color                                    NotEnoughPPColor                        { get; set; }
        public Color                                    NotAvailableColor                       { get; set; }
        public bool                                     IsAvailable                             { get; set; }
        public Transform?                               EffectPoint                             { get; set; }

        public static SkillContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillContentBase() { Pointer= p0 };

            value.BgImage                                   = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0x20 BgImage                     ( ModelClassType Graphic Graphic Graphic Pointer )
            value.ProducePointText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ProducePointText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillLimitPanel                           = GetObject<SkillLimitPanel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SkillLimitPanel.FromPointer); // 0x30 SkillLimitPanel             ( ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer )
            value.SkillButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 SkillButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x40 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.NotEnoughPPColor                          = (Color)GetInt32(new IntPtr(p + 0x048)); // 0x48 NotEnoughPPColor            ( ModelEnumType Color Color Color Int32 )
            value.NotAvailableColor                         = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 NotAvailableColor           ( ModelEnumType Color Color Color Int32 )
            value.IsAvailable                               = GetBool(new IntPtr(p + 0x068)); // 0x68 IsAvailable                 ( ModelPrimitiveType bool bool bool Bool )
            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 EffectPoint                 ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
