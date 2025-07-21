using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CalcIntervalSec                          float IL2CPP_TYPE_R4
    // 000 MinimumHandNum                           int IL2CPP_TYPE_I4
    // 000 IdolSkillTimeRateCorrectionValue         float IL2CPP_TYPE_R4
    // 010 IsLog                                    ModelPrimitiveType bool bool bool Bool
    // 014 DebugTime                                ModelPrimitiveType float float float Single
    // 018 UseCardIndex                             ModelPrimitiveType int int int Int32
    // 01C UseSkillIndex                            ModelPrimitiveType int int int Int32
    // 020 Time                                     ModelPrimitiveType float float float Single
    // 028 ExternalAccess                           ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 030 AiTestDataCreateModel                    ModelClassType AiTestDataCreateModel AiTestDataCreateModel AiTestDataCreateModel Pointer
    // 038 ComboModel                               ModelClassType AiComboModel AiComboModel AiComboModel Pointer
    // 040 SkillActionModel                         ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 048 SkillDataList                            ModelClassListType List`1<SkillData> List`1<SkillData> List<SkillData> Pointer
    // 050 ExecuteData                              ModelClassType ExecuteData ExecuteData ExecuteData Pointer
    // 058 AiResult                                 ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer
    // 060 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class AiModel : DataModel
    {
        public bool                                     IsLog                                   { get; set; }
        public float                                    DebugTime                               { get; set; }
        public int                                      UseCardIndex                            { get; set; }
        public int                                      UseSkillIndex                           { get; set; }
        public float                                    Time                                    { get; set; }
        public AiExternalAccess?                        ExternalAccess                          { get; set; }
        public AiTestDataCreateModel?                   AiTestDataCreateModel                   { get; set; }
        public AiComboModel?                            ComboModel                              { get; set; }
        public IngameSkillActionModel?                  SkillActionModel                        { get; set; }
        public List<SkillData>?                         SkillDataList                           { get; set; }
        public ExecuteData?                             ExecuteData                             { get; set; }
        public CardAndSkillExecResult?                  AiResult                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static AiModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiModel() { Pointer= p0 };

            value.IsLog                                     = GetBool(new IntPtr(p + 0x010)); // 0x10 IsLog                       ( ModelPrimitiveType bool bool bool Bool )
            value.DebugTime                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 DebugTime                   ( ModelPrimitiveType float float float Single )
            value.UseCardIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 UseCardIndex                ( ModelPrimitiveType int int int Int32 )
            value.UseSkillIndex                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C UseSkillIndex               ( ModelPrimitiveType int int int Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0x20 Time                        ( ModelPrimitiveType float float float Single )
            value.ExternalAccess                            = GetObject<AiExternalAccess>(new IntPtr(p + 0x028), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 0x28 ExternalAccess              ( ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.AiTestDataCreateModel                     = GetObject<AiTestDataCreateModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.AiTestDataCreateModel.FromPointer); // 0x30 AiTestDataCreateModel       ( ModelClassType AiTestDataCreateModel AiTestDataCreateModel AiTestDataCreateModel Pointer )
            value.ComboModel                                = GetObject<AiComboModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.AiComboModel.FromPointer); // 0x38 ComboModel                  ( ModelClassType AiComboModel AiComboModel AiComboModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 0x40 SkillActionModel            ( ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.SkillDataList                             = GetObjectList<SkillData>(new IntPtr(p + 0x048), ReversePrism.DataModels.SkillData.FromPointer); // 0x48 SkillDataList               ( ModelClassListType List`1<SkillData> List`1<SkillData> List<SkillData> Pointer )
            value.ExecuteData                               = GetObject<ExecuteData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExecuteData.FromPointer); // 0x50 ExecuteData                 ( ModelClassType ExecuteData ExecuteData ExecuteData Pointer )
            value.AiResult                                  = GetObject<CardAndSkillExecResult>(new IntPtr(p + 0x058), ReversePrism.DataModels.CardAndSkillExecResult.FromPointer); // 0x58 AiResult                    ( ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
