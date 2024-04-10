using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TempCallBackDisposable                   0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 RandomModel                              0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 020 AvoidResult                              0001866D4D80 ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer
    // 028 IngamePlayerActionData                   0001866E5810 ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer
    // 030 IngameOpponentActionData                 0001866E5810 ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer
    // 038 EmptyApealTypes                          000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 040 VoDaApealTypes                           000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 048 VoViApealTypes                           000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 050 DaViApealTypes                           000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 058 VoDaViApealTypes                         000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 060 VoAppealTypes                            000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 068 DaAppealTypes                            000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 070 ViAppealTypes                            000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 078 <CurrentTimeSecondFunc>k__BackingField   Func`1<float> IL2CPP_TYPE_GENERICINST
    // 080 <ElapsedTimeSecondFunc>k__BackingField   Func`1<float> IL2CPP_TYPE_GENERICINST
    // 088 <CardAndSkillExecResultPoolFunc>k__BackingField Func`1<InGameActionResultPool`1<CardAndSkillExecResult>> IL2CPP_TYPE_GENERICINST
    public partial class IngameSkillActionModel : DataModel
    {
        public CompositeDisposable?                     TempCallBackDisposable                  { get; set; }
        public IngameRandomModel?                       RandomModel                             { get; set; }
        public InGameExecActionResult?                  AvoidResult                             { get; set; }
        public IngamePlayerActionData?                  IngamePlayerActionData                  { get; set; }
        public IngamePlayerActionData?                  IngameOpponentActionData                { get; set; }
        public List<ProduceParameterType>?              EmptyApealTypes                         { get; set; }
        public List<ProduceParameterType>?              VoDaApealTypes                          { get; set; }
        public List<ProduceParameterType>?              VoViApealTypes                          { get; set; }
        public List<ProduceParameterType>?              DaViApealTypes                          { get; set; }
        public List<ProduceParameterType>?              VoDaViApealTypes                        { get; set; }
        public List<ProduceParameterType>?              VoAppealTypes                           { get; set; }
        public List<ProduceParameterType>?              DaAppealTypes                           { get; set; }
        public List<ProduceParameterType>?              ViAppealTypes                           { get; set; }

        public static IngameSkillActionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameSkillActionModel() { Pointer= p0 };

            value.TempCallBackDisposable                    = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665B02118 0x10 TempCallBackDisposable      ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 024665B02138 0x18 RandomModel                 ( 0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.AvoidResult                               = GetObject<InGameExecActionResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameExecActionResult.FromPointer); // 024665B02158 0x20 AvoidResult                 ( 0001866D4D80 ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer )
            value.IngamePlayerActionData                    = GetObject<IngamePlayerActionData>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePlayerActionData.FromPointer); // 024665B02178 0x28 IngamePlayerActionData      ( 0001866E5810 ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer )
            value.IngameOpponentActionData                  = GetObject<IngamePlayerActionData>(new IntPtr(p + 0x030), ReversePrism.DataModels.IngamePlayerActionData.FromPointer); // 024665B02198 0x30 IngameOpponentActionData    ( 0001866E5810 ModelClassType IngamePlayerActionData IngamePlayerActionData IngamePlayerActionData Pointer )
            value.EmptyApealTypes                           = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x038)); // 024665B021B8 0x38 EmptyApealTypes             ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoDaApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x040)); // 024665B021D8 0x40 VoDaApealTypes              ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoViApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x048)); // 024665B021F8 0x48 VoViApealTypes              ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DaViApealTypes                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x050)); // 024665B02218 0x50 DaViApealTypes              ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoDaViApealTypes                          = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x058)); // 024665B02238 0x58 VoDaViApealTypes            ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.VoAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x060)); // 024665B02258 0x60 VoAppealTypes               ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.DaAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x068)); // 024665B02278 0x68 DaAppealTypes               ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.ViAppealTypes                             = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x070)); // 024665B02298 0x70 ViAppealTypes               ( 000185D18D98 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer )

            return value;
        }
    }
}
