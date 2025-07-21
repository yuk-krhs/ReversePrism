using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ComboNumberParent                        ModelClassType Transform Transform Transform Pointer
    // 028 ComboNumberDigitView                     ModelClassType ComboDigitView ComboDigitView ComboDigitView Pointer
    // 030 Spacing                                  ModelPrimitiveType float float float Single
    // 038 SkillEffect                              ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 040 PunchStrength                            ModelPrimitiveType float float float Single
    // 044 PunchDuration                            ModelPrimitiveType float float float Single
    // 048 SpecialNumberEffect283                   ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer
    // 050 SpecialNumberEffect412                   ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer
    // 058 AllGreatEffect                           ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer
    // 060 AllPerfectEffect                         ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer
    // 068 AllShinyEffect                           ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer
    // 070 CurrentCombo                             ModelPrimitiveType int int int Int32
    // 078 PunchTweener                             ModelClassType Tweener Tweener Tweener Pointer
    // 080 IsSkillActive                            ModelPrimitiveType bool bool bool Bool
    // 088 CurrentClearTypeEffect                   ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer
    public partial class ComboView : DataModel
    {
        public Transform?                               ComboNumberParent                       { get; set; }
        public ComboDigitView?                          ComboNumberDigitView                    { get; set; }
        public float                                    Spacing                                 { get; set; }
        public ParticleSystem?                          SkillEffect                             { get; set; }
        public float                                    PunchStrength                           { get; set; }
        public float                                    PunchDuration                           { get; set; }
        public SpecialComboNumberEffect?                SpecialNumberEffect283                  { get; set; }
        public SpecialComboNumberEffect?                SpecialNumberEffect412                  { get; set; }
        public ClearTypeEffect?                         AllGreatEffect                          { get; set; }
        public ClearTypeEffect?                         AllPerfectEffect                        { get; set; }
        public ClearTypeEffect?                         AllShinyEffect                          { get; set; }
        public int                                      CurrentCombo                            { get; set; }
        public Tweener?                                 PunchTweener                            { get; set; }
        public bool                                     IsSkillActive                           { get; set; }
        public ClearTypeEffect?                         CurrentClearTypeEffect                  { get; set; }

        public static ComboView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboView() { Pointer= p0 };

            value.ComboNumberParent                         = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ComboNumberParent           ( ModelClassType Transform Transform Transform Pointer )
            value.ComboNumberDigitView                      = GetObject<ComboDigitView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ComboDigitView.FromPointer); // 0x28 ComboNumberDigitView        ( ModelClassType ComboDigitView ComboDigitView ComboDigitView Pointer )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 Spacing                     ( ModelPrimitiveType float float float Single )
            value.SkillEffect                               = GetObject<ParticleSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x38 SkillEffect                 ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.PunchStrength                             = GetSingle(new IntPtr(p + 0x040)); // 0x40 PunchStrength               ( ModelPrimitiveType float float float Single )
            value.PunchDuration                             = GetSingle(new IntPtr(p + 0x044)); // 0x44 PunchDuration               ( ModelPrimitiveType float float float Single )
            value.SpecialNumberEffect283                    = GetObject<SpecialComboNumberEffect>(new IntPtr(p + 0x048), ReversePrism.DataModels.SpecialComboNumberEffect.FromPointer); // 0x48 SpecialNumberEffect283      ( ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer )
            value.SpecialNumberEffect412                    = GetObject<SpecialComboNumberEffect>(new IntPtr(p + 0x050), ReversePrism.DataModels.SpecialComboNumberEffect.FromPointer); // 0x50 SpecialNumberEffect412      ( ModelClassType SpecialComboNumberEffect SpecialComboNumberEffect SpecialComboNumberEffect Pointer )
            value.AllGreatEffect                            = GetObject<ClearTypeEffect>(new IntPtr(p + 0x058), ReversePrism.DataModels.ClearTypeEffect.FromPointer); // 0x58 AllGreatEffect              ( ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer )
            value.AllPerfectEffect                          = GetObject<ClearTypeEffect>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClearTypeEffect.FromPointer); // 0x60 AllPerfectEffect            ( ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer )
            value.AllShinyEffect                            = GetObject<ClearTypeEffect>(new IntPtr(p + 0x068), ReversePrism.DataModels.ClearTypeEffect.FromPointer); // 0x68 AllShinyEffect              ( ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer )
            value.CurrentCombo                              = GetInt32(new IntPtr(p + 0x070)); // 0x70 CurrentCombo                ( ModelPrimitiveType int int int Int32 )
            value.PunchTweener                              = GetObject<Tweener>(new IntPtr(p + 0x078), ReversePrism.DataModels.Tweener.FromPointer); // 0x78 PunchTweener                ( ModelClassType Tweener Tweener Tweener Pointer )
            value.IsSkillActive                             = GetBool(new IntPtr(p + 0x080)); // 0x80 IsSkillActive               ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentClearTypeEffect                    = GetObject<ClearTypeEffect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ClearTypeEffect.FromPointer); // 0x88 CurrentClearTypeEffect      ( ModelClassType ClearTypeEffect ClearTypeEffect ClearTypeEffect Pointer )

            return value;
        }
    }
}
