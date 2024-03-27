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
    public partial class SkillContentBase
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
            var value   = new SkillContentBase();

            value.BgImage                                   = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0270D59DB0E8 0x20 BgImage                     ( 000186692340 ModelClassType Graphic Graphic Graphic Pointer )
            value.ProducePointText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D59DB108 0x28 ProducePointText            ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillLimitPanel                           = GetObject<SkillLimitPanel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SkillLimitPanel.FromPointer); // 0270D59DB128 0x30 SkillLimitPanel             ( 000186513830 ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer )
            value.SkillButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270D59DB148 0x38 SkillButton                 ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D59DB168 0x40 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.NotEnoughPPColor                          = (Color)GetInt32(new IntPtr(p + 0x048)); // 0270D59DB188 0x48 NotEnoughPPColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.NotAvailableColor                         = (Color)GetInt32(new IntPtr(p + 0x058)); // 0270D59DB1A8 0x58 NotAvailableColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.IsAvailable                               = GetBool(new IntPtr(p + 0x068)); // 0270D59DB1C8 0x68 IsAvailable                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0270D59DB1E8 0x70 EffectPoint                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
