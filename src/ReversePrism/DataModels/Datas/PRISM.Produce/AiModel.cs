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
    // 010 IsLog                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 DebugTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 018 UseCardIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C UseSkillIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Time                                     0001866656B0 ModelPrimitiveType float float float Single
    // 028 ExternalAccess                           00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer
    // 030 AiTestDataCreateModel                    00018669EA60 ModelClassType AiTestDataCreateModel AiTestDataCreateModel AiTestDataCreateModel Pointer
    // 038 ComboModel                               00018669C100 ModelClassType AiComboModel AiComboModel AiComboModel Pointer
    // 040 SkillActionModel                         0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 048 SkillDataList                            000185D1E5E8 ModelClassListType List`1<SkillData> List`1<SkillData> List<SkillData> Pointer
    // 050 ExecuteData                              000186696060 ModelClassType ExecuteData ExecuteData ExecuteData Pointer
    // 058 AiResult                                 000186544B20 ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer
    // 060 PrevMental                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class AiModel
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
        public int                                      PrevMental                              { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static AiModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiModel();

            value.IsLog                                     = GetBool(new IntPtr(p + 0x010)); // 0270D5A90DF8 0x10 IsLog                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DebugTime                                 = GetSingle(new IntPtr(p + 0x014)); // 0270D5A90E18 0x14 DebugTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.UseCardIndex                              = GetInt32(new IntPtr(p + 0x018)); // 0270D5A90E38 0x18 UseCardIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseSkillIndex                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D5A90E58 0x1C UseSkillIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0270D5A90E78 0x20 Time                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ExternalAccess                            = GetObject<AiExternalAccess>(new IntPtr(p + 0x028), ReversePrism.DataModels.AiExternalAccess.FromPointer); // 0270D5A90E98 0x28 ExternalAccess              ( 00018669C800 ModelClassType AiExternalAccess AiExternalAccess AiExternalAccess Pointer )
            value.AiTestDataCreateModel                     = GetObject<AiTestDataCreateModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.AiTestDataCreateModel.FromPointer); // 0270D5A90EB8 0x30 AiTestDataCreateModel       ( 00018669EA60 ModelClassType AiTestDataCreateModel AiTestDataCreateModel AiTestDataCreateModel Pointer )
            value.ComboModel                                = GetObject<AiComboModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.AiComboModel.FromPointer); // 0270D5A90ED8 0x38 ComboModel                  ( 00018669C100 ModelClassType AiComboModel AiComboModel AiComboModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 0270D5A90EF8 0x40 SkillActionModel            ( 0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.SkillDataList                             = GetObjectList<SkillData>(new IntPtr(p + 0x048), ReversePrism.DataModels.SkillData.FromPointer); // 0270D5A90F18 0x48 SkillDataList               ( 000185D1E5E8 ModelClassListType List`1<SkillData> List`1<SkillData> List<SkillData> Pointer )
            value.ExecuteData                               = GetObject<ExecuteData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExecuteData.FromPointer); // 0270D5A90F38 0x50 ExecuteData                 ( 000186696060 ModelClassType ExecuteData ExecuteData ExecuteData Pointer )
            value.AiResult                                  = GetObject<CardAndSkillExecResult>(new IntPtr(p + 0x058), ReversePrism.DataModels.CardAndSkillExecResult.FromPointer); // 0270D5A90F58 0x58 AiResult                    ( 000186544B20 ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer )
            value.PrevMental                                = GetInt32(new IntPtr(p + 0x060)); // 0270D5A90F78 0x60 PrevMental                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5A90F98 0x68 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
