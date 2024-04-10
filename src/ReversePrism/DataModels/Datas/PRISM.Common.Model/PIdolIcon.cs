using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 bottomTypeRP                             ReactiveProperty`1<Bottom> IL2CPP_TYPE_GENERICINST
    // 048 AwakenDisplayPermit                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 TrainingDisplayPermit                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04A SkillLvUpDisplayPermit                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 IconId                                   000186671910 ModelPrimitiveType string string string String
    // 058 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 Star                                     0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 068 AwakeningLv                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 VoDaViMe                                 000186575070 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 078 <PotentialLiveSkillList>k__BackingField  IEnumerable`1<IPotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 080 UnlockIdolSkillIconIdList                000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 088 IdolSkillIconIdList                      000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 090 CanAwaken                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 091 CanTraining                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 092 CanSkillLvUp                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 093 HasEventBonus                            0001865965D0 ModelPrimitiveType bool bool bool Bool
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

        public static PIdolIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolIcon() { Pointer= p0 };

            value.AwakenDisplayPermit                       = GetBool(new IntPtr(p + 0x048)); // 024664CEE070 0x48 AwakenDisplayPermit         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TrainingDisplayPermit                     = GetBool(new IntPtr(p + 0x049)); // 024664CEE090 0x49 TrainingDisplayPermit       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SkillLvUpDisplayPermit                    = GetBool(new IntPtr(p + 0x04A)); // 024664CEE0B0 0x4A SkillLvUpDisplayPermit      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IconId                                    = GetString(new IntPtr(p + 0x050)); // 024664CEE0D0 0x50 IconId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x058)); // 024664CEE0F0 0x58 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 024664CEE110 0x60 Star                        ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.AwakeningLv                               = GetInt32(new IntPtr(p + 0x068)); // 024664CEE130 0x68 AwakeningLv                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 024664CEE150 0x70 VoDaViMe                    ( 000186575070 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.UnlockIdolSkillIconIdList                 = GetInt32List(new IntPtr(p + 0x080)); // 024664CEE190 0x80 UnlockIdolSkillIconIdList   ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.IdolSkillIconIdList                       = GetInt32List(new IntPtr(p + 0x088)); // 024664CEE1B0 0x88 IdolSkillIconIdList         ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.CanAwaken                                 = GetBool(new IntPtr(p + 0x090)); // 024664CEE1D0 0x90 CanAwaken                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x091)); // 024664CEE1F0 0x91 CanTraining                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CanSkillLvUp                              = GetBool(new IntPtr(p + 0x092)); // 024664CEE210 0x92 CanSkillLvUp                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.HasEventBonus                             = GetBool(new IntPtr(p + 0x093)); // 024664CEE230 0x93 HasEventBonus               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
