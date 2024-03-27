using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ComboNumberParent                        0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ComboNumberDigitView                     0001865DDAD0 ModelClassType ComboDigitView ComboDigitView ComboDigitView Pointer
    // 030 ComboNumberDigitEffectViews              000185B762D0 ModelClassListType ComboDigitView[] ComboDigitView[] List<ComboDigitView> Pointer
    // 038 Spacing                                  0001866656B0 ModelPrimitiveType float float float Single
    // 040 SkillEffect                              000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 048 PunchStrength                            0001866656B0 ModelPrimitiveType float float float Single
    // 04C PunchDuration                            0001866656B0 ModelPrimitiveType float float float Single
    // 050 SpecialNumberEffect283                   00018653DAF0 ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer
    // 058 SpecialNumberEffect412                   00018653DAF0 ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer
    // 060 AllPerfectEffects                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 CurrentCombo                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 PunchTweener                             0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    // 078 IsSkillActive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ComboView
    {
        public Transform?                               ComboNumberParent                       { get; set; }
        public ComboDigitView?                          ComboNumberDigitView                    { get; set; }
        public List<ComboDigitView>?                    ComboNumberDigitEffectViews             { get; set; }
        public float                                    Spacing                                 { get; set; }
        public ParticleSystem?                          SkillEffect                             { get; set; }
        public float                                    PunchStrength                           { get; set; }
        public float                                    PunchDuration                           { get; set; }
        public SpecialComboNumberEffect?                SpecialNumberEffect283                  { get; set; }
        public SpecialComboNumberEffect?                SpecialNumberEffect412                  { get; set; }
        public List<GameObject>?                        AllPerfectEffects                       { get; set; }
        public int                                      CurrentCombo                            { get; set; }
        public Tweener?                                 PunchTweener                            { get; set; }
        public bool                                     IsSkillActive                           { get; set; }

        public static ComboView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboView();

            value.ComboNumberParent                         = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270D4EC22C8 0x20 ComboNumberParent           ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ComboNumberDigitView                      = GetObject<ComboDigitView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ComboDigitView.FromPointer); // 0270D4EC22E8 0x28 ComboNumberDigitView        ( 0001865DDAD0 ModelClassType ComboDigitView ComboDigitView ComboDigitView Pointer )
            value.ComboNumberDigitEffectViews               = GetObjectList<ComboDigitView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ComboDigitView.FromPointer); // 0270D4EC2308 0x30 ComboNumberDigitEffectViews ( 000185B762D0 ModelClassListType ComboDigitView[] ComboDigitView[] List<ComboDigitView> Pointer )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x038)); // 0270D4EC2328 0x38 Spacing                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SkillEffect                               = GetObject<ParticleSystem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4EC2348 0x40 SkillEffect                 ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.PunchStrength                             = GetSingle(new IntPtr(p + 0x048)); // 0270D4EC2368 0x48 PunchStrength               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PunchDuration                             = GetSingle(new IntPtr(p + 0x04C)); // 0270D4EC2388 0x4C PunchDuration               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SpecialNumberEffect283                    = GetObject<SpecialComboNumberEffect>(new IntPtr(p + 0x050), ReversePrism.DataModels.SpecialComboNumberEffect.FromPointer); // 0270D4EC23A8 0x50 SpecialNumberEffect283      ( 00018653DAF0 ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer )
            value.SpecialNumberEffect412                    = GetObject<SpecialComboNumberEffect>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpecialComboNumberEffect.FromPointer); // 0270D4EC23C8 0x58 SpecialNumberEffect412      ( 00018653DAF0 ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer )
            value.AllPerfectEffects                         = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4EC23E8 0x60 AllPerfectEffects           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CurrentCombo                              = GetInt32(new IntPtr(p + 0x068)); // 0270D4EC2408 0x68 CurrentCombo                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PunchTweener                              = GetObject<Tweener>(new IntPtr(p + 0x070), ReversePrism.DataModels.Tweener.FromPointer); // 0270D4EC2428 0x70 PunchTweener                ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )
            value.IsSkillActive                             = GetBool(new IntPtr(p + 0x078)); // 0270D4EC2448 0x78 IsSkillActive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
