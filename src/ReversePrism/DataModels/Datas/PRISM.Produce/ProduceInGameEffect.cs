using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotTimeLimitDuration                     int IL2CPP_TYPE_I4
    // 010 Duration                                 0001866656B0 ModelPrimitiveType float float float Single
    // 014 DeleteType                               000186601040 ModelEnumType EffectDeleteType EffectDeleteType EffectDeleteType Int32
    // 018 ElapsedTime                              0001866656B0 ModelPrimitiveType float float float Single
    // 01C NotDividedEffectValue                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 DescriptionText                          000186671910 ModelPrimitiveType string string string String
    // 028 HasDescriptionText                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 TerminateDisposer                        000185CE24E8 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    // 038 Type                                     000186557E00 ModelEnumType ProduceInGameEffectType ProduceInGameEffectType ProduceInGameEffectType Int32
    // 03C EffectJudgeValue                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 CardRank                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 BuffDebuffId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 IconID                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C DisplayGroupID                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 TemporaryValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 GrantSkillBufferDisplay                  000186646D80 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer
    // 060 IsExistTimeLimit                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceInGameEffect
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
            var value   = new ProduceInGameEffect();

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0270D4BB7C30 0x10 Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DeleteType                                = (EffectDeleteType)GetInt32(new IntPtr(p + 0x014)); // 0270D4BB7C50 0x14 DeleteType                  ( 000186601040 ModelEnumType EffectDeleteType EffectDeleteType EffectDeleteType Int32 )
            value.ElapsedTime                               = GetSingle(new IntPtr(p + 0x018)); // 0270D4BB7C70 0x18 ElapsedTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NotDividedEffectValue                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D4BB7C90 0x1C NotDividedEffectValue       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DescriptionText                           = GetString(new IntPtr(p + 0x020)); // 0270D4BB7CB0 0x20 DescriptionText             ( 000186671910 ModelPrimitiveType string string string String )
            value.HasDescriptionText                        = GetBool(new IntPtr(p + 0x028)); // 0270D4BB7CD0 0x28 HasDescriptionText          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TerminateDisposer                         = GetObjectList<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D4BB7CF0 0x30 TerminateDisposer           ( 000185CE24E8 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )
            value.Type                                      = (ProduceInGameEffectType)GetInt32(new IntPtr(p + 0x038)); // 0270D4BB7D10 0x38 Type                        ( 000186557E00 ModelEnumType ProduceInGameEffectType ProduceInGameEffectType ProduceInGameEffectType Int32 )
            value.EffectJudgeValue                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D4BB7D30 0x3C EffectJudgeValue            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x040)); // 0270D4BB7D50 0x40 CardRank                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BuffDebuffId                              = GetInt32(new IntPtr(p + 0x044)); // 0270D4BB7D70 0x44 BuffDebuffId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x048)); // 0270D4BB7D90 0x48 IconID                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DisplayGroupID                            = GetInt32(new IntPtr(p + 0x04C)); // 0270D4BB7DB0 0x4C DisplayGroupID              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TemporaryValue                            = GetInt32(new IntPtr(p + 0x050)); // 0270D4BB7DD0 0x50 TemporaryValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrantSkillBufferDisplay                   = GetObject<ISkillBufferDisplayStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISkillBufferDisplayStatus.FromPointer); // 0270D4BB7DF0 0x58 GrantSkillBufferDisplay     ( 000186646D80 ModelClassType ISkillBufferDisplayStatus ISkillBufferDisplayStatus ISkillBufferDisplayStatus Pointer )
            value.IsExistTimeLimit                          = GetBool(new IntPtr(p + 0x060)); // 0270D4BB7E10 0x60 IsExistTimeLimit            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
