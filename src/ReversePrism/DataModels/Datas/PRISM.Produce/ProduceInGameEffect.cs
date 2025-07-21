using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotTimeLimitDuration                     int IL2CPP_TYPE_I4
    // 010 Duration                                 ModelPrimitiveType float float float Single
    // 014 DeleteType                               ModelEnumType EffectDeleteType EffectDeleteType EffectDeleteType Int32
    // 018 ElapsedTime                              ModelPrimitiveType float float float Single
    // 01C NotDividedEffectValue                    ModelPrimitiveType int int int Int32
    // 020 DescriptionText                          ModelPrimitiveType string string string String
    // 028 HasDescriptionText                       ModelPrimitiveType bool bool bool Bool
    // 030 TerminateDisposer                        ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    // 038 Type                                     ModelEnumType ProduceInGameEffectType ProduceInGameEffectType ProduceInGameEffectType Int32
    // 03C EffectJudgeValue                         ModelPrimitiveType int int int Int32
    // 040 EffectSubJudgeValue                      ModelPrimitiveType int int int Int32
    // 044 CardRank                                 ModelPrimitiveType int int int Int32
    // 048 BuffDebuffId                             ModelPrimitiveType int int int Int32
    // 04C IconID                                   ModelPrimitiveType int int int Int32
    // 050 DisplayGroupID                           ModelPrimitiveType int int int Int32
    // 054 TemporaryValue                           ModelPrimitiveType int int int Int32
    // 058 GrantSkillBufferDisplay                  ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 060 IsExistTimeLimit                         ModelPrimitiveType bool bool bool Bool
    public partial class ProduceInGameEffect : DataModel
    {
        public float                                    Duration                                { get; set; }
        public EffectDeleteType                         DeleteType                              { get; set; }
        public float                                    ElapsedTime                             { get; set; }
        public int                                      NotDividedEffectValue                   { get; set; }
        public string                                   DescriptionText                         { get; set; }
        public bool                                     HasDescriptionText                      { get; set; }
        public List<IDisposable>?                       TerminateDisposer                       { get; set; }
        public ProduceInGameEffectType                  Type                                    { get; set; }
        public int                                      EffectJudgeValue                        { get; set; }
        public int                                      EffectSubJudgeValue                     { get; set; }
        public int                                      CardRank                                { get; set; }
        public int                                      BuffDebuffId                            { get; set; }
        public int                                      IconID                                  { get; set; }
        public int                                      DisplayGroupID                          { get; set; }
        public int                                      TemporaryValue                          { get; set; }
        public ISkillBufferDisplayStatus?               GrantSkillBufferDisplay                 { get; set; }
        public bool                                     IsExistTimeLimit                        { get; set; }

        public static ProduceInGameEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGameEffect() { Pointer= p0 };

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 Duration                    ( ModelPrimitiveType float float float Single )
            value.DeleteType                                = (EffectDeleteType)GetInt32(new IntPtr(p + 0x014)); // 0x14 DeleteType                  ( ModelEnumType EffectDeleteType EffectDeleteType EffectDeleteType Int32 )
            value.ElapsedTime                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 ElapsedTime                 ( ModelPrimitiveType float float float Single )
            value.NotDividedEffectValue                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NotDividedEffectValue       ( ModelPrimitiveType int int int Int32 )
            value.DescriptionText                           = GetString(new IntPtr(p + 0x020)); // 0x20 DescriptionText             ( ModelPrimitiveType string string string String )
            value.HasDescriptionText                        = GetBool(new IntPtr(p + 0x028)); // 0x28 HasDescriptionText          ( ModelPrimitiveType bool bool bool Bool )
            value.TerminateDisposer                         = GetObjectList<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0x30 TerminateDisposer           ( ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )
            value.Type                                      = (ProduceInGameEffectType)GetInt32(new IntPtr(p + 0x038)); // 0x38 Type                        ( ModelEnumType ProduceInGameEffectType ProduceInGameEffectType ProduceInGameEffectType Int32 )
            value.EffectJudgeValue                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C EffectJudgeValue            ( ModelPrimitiveType int int int Int32 )
            value.EffectSubJudgeValue                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 EffectSubJudgeValue         ( ModelPrimitiveType int int int Int32 )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 CardRank                    ( ModelPrimitiveType int int int Int32 )
            value.BuffDebuffId                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 BuffDebuffId                ( ModelPrimitiveType int int int Int32 )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x04C)); // 0x4C IconID                      ( ModelPrimitiveType int int int Int32 )
            value.DisplayGroupID                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 DisplayGroupID              ( ModelPrimitiveType int int int Int32 )
            value.TemporaryValue                            = GetInt32(new IntPtr(p + 0x054)); // 0x54 TemporaryValue              ( ModelPrimitiveType int int int Int32 )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0x58 GrantSkillBufferDisplay     ( ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.IsExistTimeLimit                          = GetBool(new IntPtr(p + 0x060)); // 0x60 IsExistTimeLimit            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
