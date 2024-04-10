using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  000186692340 ModelClassType Graphic Graphic Graphic Pointer
    // 028 ProducePointText                         0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SkillLimitPanel                          000186513830 ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer
    // 038 SkillButton                              0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 040 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 NotEnoughPPColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 058 NotAvailableColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 068 IsAvailable                              000186595480 ModelPrimitiveType bool bool bool Bool
    // 070 EffectPoint                              0001866AA150 ModelClassType Transform Transform Transform Pointer
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

            value.BgImage                                   = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 024665A3C860 0x20 BgImage                     ( 000186692340 ModelClassType Graphic Graphic Graphic Pointer )
            value.ProducePointText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A3C880 0x28 ProducePointText            ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillLimitPanel                           = GetObject<SkillLimitPanel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SkillLimitPanel.FromPointer); // 024665A3C8A0 0x30 SkillLimitPanel             ( 000186513830 ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer )
            value.SkillButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024665A3C8C0 0x38 SkillButton                 ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 024665A3C8E0 0x40 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.NotEnoughPPColor                          = (Color)GetInt32(new IntPtr(p + 0x048)); // 024665A3C900 0x48 NotEnoughPPColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.NotAvailableColor                         = (Color)GetInt32(new IntPtr(p + 0x058)); // 024665A3C920 0x58 NotAvailableColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.IsAvailable                               = GetBool(new IntPtr(p + 0x068)); // 024665A3C940 0x68 IsAvailable                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 024665A3C960 0x70 EffectPoint                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
