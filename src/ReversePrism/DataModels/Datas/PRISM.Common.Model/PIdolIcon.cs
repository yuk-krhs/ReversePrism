using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 bottomTypeRP                             ReactiveProperty`1<Bottom> IL2CPP_TYPE_GENERICINST
    // 048 AwakenDisplayPermit                      ModelPrimitiveType bool bool bool Bool
    // 049 TrainingDisplayPermit                    ModelPrimitiveType bool bool bool Bool
    // 04A SkillLvUpDisplayPermit                   ModelPrimitiveType bool bool bool Bool
    // 050 IconId                                   ModelPrimitiveType string string string String
    // 058 UnitId                                   ModelPrimitiveType int int int Int32
    // 060 Star                                     ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 068 AwakeningLv                              ModelPrimitiveType int int int Int32
    // 070 VoDaViMe                                 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 078 <PotentialLiveSkillList>k__BackingField  IEnumerable`1<IPotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 080 UnlockIdolSkillIconIdList                ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 088 IdolSkillIconIdList                      ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 090 CanAwaken                                ModelPrimitiveType bool bool bool Bool
    // 091 CanTraining                              ModelPrimitiveType bool bool bool Bool
    // 092 CanSkillLvUp                             ModelPrimitiveType bool bool bool Bool
    // 093 HasEventBonus                            ModelPrimitiveType bool bool bool Bool
    // 094 ProduceIdolType                          ModelEnumType ProduceIdolType ProduceIdolType ProduceIdolType Int32
    public partial class PIdolIcon : DataModel
    {
        public bool                                     AwakenDisplayPermit                     { get; set; }
        public bool                                     TrainingDisplayPermit                   { get; set; }
        public bool                                     SkillLvUpDisplayPermit                  { get; set; }
        public string                                   IconId                                  { get; set; }
        public int                                      UnitId                                  { get; set; }
        public ILimitedValueStatus?                     Star                                    { get; set; }
        public int                                      AwakeningLv                             { get; set; }
        public IIdolParameterStatus?                    VoDaViMe                                { get; set; }
        public List<int>?                               UnlockIdolSkillIconIdList               { get; set; }
        public List<int>?                               IdolSkillIconIdList                     { get; set; }
        public bool                                     CanAwaken                               { get; set; }
        public bool                                     CanTraining                             { get; set; }
        public bool                                     CanSkillLvUp                            { get; set; }
        public bool                                     HasEventBonus                           { get; set; }
        public ProduceIdolType                          ProduceIdolType                         { get; set; }

        public static PIdolIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolIcon() { Pointer= p0 };

            value.AwakenDisplayPermit                       = GetBool(new IntPtr(p + 0x048)); // 0x48 AwakenDisplayPermit         ( ModelPrimitiveType bool bool bool Bool )
            value.TrainingDisplayPermit                     = GetBool(new IntPtr(p + 0x049)); // 0x49 TrainingDisplayPermit       ( ModelPrimitiveType bool bool bool Bool )
            value.SkillLvUpDisplayPermit                    = GetBool(new IntPtr(p + 0x04A)); // 0x4A SkillLvUpDisplayPermit      ( ModelPrimitiveType bool bool bool Bool )
            value.IconId                                    = GetString(new IntPtr(p + 0x050)); // 0x50 IconId                      ( ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x60 Star                        ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.AwakeningLv                               = GetInt32(new IntPtr(p + 0x068)); // 0x68 AwakeningLv                 ( ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0x70 VoDaViMe                    ( ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.UnlockIdolSkillIconIdList                 = GetInt32List(new IntPtr(p + 0x080)); // 0x80 UnlockIdolSkillIconIdList   ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.IdolSkillIconIdList                       = GetInt32List(new IntPtr(p + 0x088)); // 0x88 IdolSkillIconIdList         ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.CanAwaken                                 = GetBool(new IntPtr(p + 0x090)); // 0x90 CanAwaken                   ( ModelPrimitiveType bool bool bool Bool )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x091)); // 0x91 CanTraining                 ( ModelPrimitiveType bool bool bool Bool )
            value.CanSkillLvUp                              = GetBool(new IntPtr(p + 0x092)); // 0x92 CanSkillLvUp                ( ModelPrimitiveType bool bool bool Bool )
            value.HasEventBonus                             = GetBool(new IntPtr(p + 0x093)); // 0x93 HasEventBonus               ( ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolType                           = (ProduceIdolType)GetInt32(new IntPtr(p + 0x094)); // 0x94 ProduceIdolType             ( ModelEnumType ProduceIdolType ProduceIdolType ProduceIdolType Int32 )

            return value;
        }
    }
}
