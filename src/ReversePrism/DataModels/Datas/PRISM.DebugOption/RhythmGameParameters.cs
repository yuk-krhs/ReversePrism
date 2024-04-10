using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Current                                  RhythmGameParameters IL2CPP_TYPE_CLASS
    // 010 カメラ切り替え間引き秒数                             0001866656B0 ModelPrimitiveType float float float Single
    // 014 TextureBorderU                           0001866656B0 ModelPrimitiveType float float float Single
    // 018 MeshBorderSpace                          0001866656B0 ModelPrimitiveType float float float Single
    // 01C MeshBorderWidth                          0001866656B0 ModelPrimitiveType float float float Single
    // 020 LerpPow                                  0001866656B0 ModelPrimitiveType float float float Single
    // 024 LerpOffset                               0001866656B0 ModelPrimitiveType float float float Single
    // 028 ScoreConstantCoefficient                 0001866656B0 ModelPrimitiveType float float float Single
    // 02C MaxNoteHeightScale                       0001866656B0 ModelPrimitiveType float float float Single
    // 030 SE再生間隔                                   0001866656B0 ModelPrimitiveType float float float Single
    // 034 IOSパターンID                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Androidミリ秒数                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 JudgementRanges                          Dictionary`2<NoteType, ValueTuple`2<JudgementRange, JudgementRange>> IL2CPP_TYPE_GENERICINST
    // 048 TargetType                               0001866B0820 ModelEnumType NoteType NoteType NoteType Int32
    // 04C 早押しMiss秒数                                0001866656B0 ModelPrimitiveType float float float Single
    // 050 フリック判定する秒間レーン移動量                         0001866656B0 ModelPrimitiveType float float float Single
    // 054 Reverse判定開始秒数                            0001866656B0 ModelPrimitiveType float float float Single
    // 058 タップズレ許容幅                                 0001866656B0 ModelPrimitiveType float float float Single
    // 05C ズームイン秒数                                  0001866656B0 ModelPrimitiveType float float float Single
    // 060 表示秒数                                     0001866656B0 ModelPrimitiveType float float float Single
    // 064 ズームアウト秒数                                 0001866656B0 ModelPrimitiveType float float float Single
    // 068 NoteLineNotJudgeColorR                   0001866656B0 ModelPrimitiveType float float float Single
    // 06C NoteLineNotJudgeColorG                   0001866656B0 ModelPrimitiveType float float float Single
    // 070 NoteLineNotJudgeColorB                   0001866656B0 ModelPrimitiveType float float float Single
    // 074 NoteLineNotJudgeColorA                   0001866656B0 ModelPrimitiveType float float float Single
    // 078 NoteLineSuccessColorR                    0001866656B0 ModelPrimitiveType float float float Single
    // 07C NoteLineSuccessColorG                    0001866656B0 ModelPrimitiveType float float float Single
    // 080 NoteLineSuccessColorB                    0001866656B0 ModelPrimitiveType float float float Single
    // 084 NoteLineSuccessColorA                    0001866656B0 ModelPrimitiveType float float float Single
    // 088 NoteLineFailureColorR                    0001866656B0 ModelPrimitiveType float float float Single
    // 08C NoteLineFailureColorG                    0001866656B0 ModelPrimitiveType float float float Single
    // 090 NoteLineFailureColorB                    0001866656B0 ModelPrimitiveType float float float Single
    // 094 NoteLineFailureColorA                    0001866656B0 ModelPrimitiveType float float float Single
    // 098 JudgementShowPositionUpper               0001866656B0 ModelPrimitiveType float float float Single
    // 09C JudgementShowPositionCenter              0001866656B0 ModelPrimitiveType float float float Single
    // 0A0 JudgementShowPositionCenterLower         0001866656B0 ModelPrimitiveType float float float Single
    // 0A4 JudgementLagShowPositionY                0001866656B0 ModelPrimitiveType float float float Single
    // 0A8 JudgementLagShowPositionFixedRightX      0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 PropertyChanged                          0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class RhythmGameParameters : DataModel
    {
        public float                                    カメラ切り替え間引き秒数                            { get; set; }
        public float                                    TextureBorderU                          { get; set; }
        public float                                    MeshBorderSpace                         { get; set; }
        public float                                    MeshBorderWidth                         { get; set; }
        public float                                    LerpPow                                 { get; set; }
        public float                                    LerpOffset                              { get; set; }
        public float                                    ScoreConstantCoefficient                { get; set; }
        public float                                    MaxNoteHeightScale                      { get; set; }
        public float                                    SE再生間隔                                  { get; set; }
        public int                                      IOSパターンID                               { get; set; }
        public int                                      Androidミリ秒数                             { get; set; }
        public NoteType                                 TargetType                              { get; set; }
        public float                                    早押しMiss秒数                               { get; set; }
        public float                                    フリック判定する秒間レーン移動量                        { get; set; }
        public float                                    Reverse判定開始秒数                           { get; set; }
        public float                                    タップズレ許容幅                                { get; set; }
        public float                                    ズームイン秒数                                 { get; set; }
        public float                                    表示秒数                                    { get; set; }
        public float                                    ズームアウト秒数                                { get; set; }
        public float                                    NoteLineNotJudgeColorR                  { get; set; }
        public float                                    NoteLineNotJudgeColorG                  { get; set; }
        public float                                    NoteLineNotJudgeColorB                  { get; set; }
        public float                                    NoteLineNotJudgeColorA                  { get; set; }
        public float                                    NoteLineSuccessColorR                   { get; set; }
        public float                                    NoteLineSuccessColorG                   { get; set; }
        public float                                    NoteLineSuccessColorB                   { get; set; }
        public float                                    NoteLineSuccessColorA                   { get; set; }
        public float                                    NoteLineFailureColorR                   { get; set; }
        public float                                    NoteLineFailureColorG                   { get; set; }
        public float                                    NoteLineFailureColorB                   { get; set; }
        public float                                    NoteLineFailureColorA                   { get; set; }
        public float                                    JudgementShowPositionUpper              { get; set; }
        public float                                    JudgementShowPositionCenter             { get; set; }
        public float                                    JudgementShowPositionCenterLower        { get; set; }
        public float                                    JudgementLagShowPositionY               { get; set; }
        public float                                    JudgementLagShowPositionFixedRightX     { get; set; }
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }

        public static RhythmGameParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameParameters() { Pointer= p0 };

            value.カメラ切り替え間引き秒数                              = GetSingle(new IntPtr(p + 0x010)); // 024664FC6948 0x10 カメラ切り替え間引き秒数                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TextureBorderU                            = GetSingle(new IntPtr(p + 0x014)); // 024664FC6968 0x14 TextureBorderU              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MeshBorderSpace                           = GetSingle(new IntPtr(p + 0x018)); // 024664FC6988 0x18 MeshBorderSpace             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MeshBorderWidth                           = GetSingle(new IntPtr(p + 0x01C)); // 024664FC69A8 0x1C MeshBorderWidth             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LerpPow                                   = GetSingle(new IntPtr(p + 0x020)); // 024664FC69C8 0x20 LerpPow                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LerpOffset                                = GetSingle(new IntPtr(p + 0x024)); // 024664FC69E8 0x24 LerpOffset                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScoreConstantCoefficient                  = GetSingle(new IntPtr(p + 0x028)); // 024664FC6A08 0x28 ScoreConstantCoefficient    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxNoteHeightScale                        = GetSingle(new IntPtr(p + 0x02C)); // 024664FC6A28 0x2C MaxNoteHeightScale          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SE再生間隔                                    = GetSingle(new IntPtr(p + 0x030)); // 024664FC6A48 0x30 SE再生間隔                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IOSパターンID                                 = GetInt32(new IntPtr(p + 0x034)); // 024664FC6A68 0x34 IOSパターンID                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Androidミリ秒数                               = GetInt32(new IntPtr(p + 0x038)); // 024664FC6A88 0x38 Androidミリ秒数                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TargetType                                = (NoteType)GetInt32(new IntPtr(p + 0x048)); // 024664FC6AC8 0x48 TargetType                  ( 0001866B0820 ModelEnumType NoteType NoteType NoteType Int32 )
            value.早押しMiss秒数                                 = GetSingle(new IntPtr(p + 0x04C)); // 024664FC6AE8 0x4C 早押しMiss秒数                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.フリック判定する秒間レーン移動量                          = GetSingle(new IntPtr(p + 0x050)); // 024664FC6B08 0x50 フリック判定する秒間レーン移動量            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Reverse判定開始秒数                             = GetSingle(new IntPtr(p + 0x054)); // 024664FC6B28 0x54 Reverse判定開始秒数               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.タップズレ許容幅                                  = GetSingle(new IntPtr(p + 0x058)); // 024664FC6B48 0x58 タップズレ許容幅                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ズームイン秒数                                   = GetSingle(new IntPtr(p + 0x05C)); // 024664FC6B68 0x5C ズームイン秒数                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.表示秒数                                      = GetSingle(new IntPtr(p + 0x060)); // 024664FC6B88 0x60 表示秒数                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ズームアウト秒数                                  = GetSingle(new IntPtr(p + 0x064)); // 024664FC6BA8 0x64 ズームアウト秒数                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorR                    = GetSingle(new IntPtr(p + 0x068)); // 024664FC6BC8 0x68 NoteLineNotJudgeColorR      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorG                    = GetSingle(new IntPtr(p + 0x06C)); // 024664FC6BE8 0x6C NoteLineNotJudgeColorG      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorB                    = GetSingle(new IntPtr(p + 0x070)); // 024664FC6C08 0x70 NoteLineNotJudgeColorB      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorA                    = GetSingle(new IntPtr(p + 0x074)); // 024664FC6C28 0x74 NoteLineNotJudgeColorA      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorR                     = GetSingle(new IntPtr(p + 0x078)); // 024664FC6C48 0x78 NoteLineSuccessColorR       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorG                     = GetSingle(new IntPtr(p + 0x07C)); // 024664FC6C68 0x7C NoteLineSuccessColorG       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorB                     = GetSingle(new IntPtr(p + 0x080)); // 024664FC6C88 0x80 NoteLineSuccessColorB       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorA                     = GetSingle(new IntPtr(p + 0x084)); // 024664FC6CA8 0x84 NoteLineSuccessColorA       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorR                     = GetSingle(new IntPtr(p + 0x088)); // 024664FC6CC8 0x88 NoteLineFailureColorR       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorG                     = GetSingle(new IntPtr(p + 0x08C)); // 024664FC6CE8 0x8C NoteLineFailureColorG       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorB                     = GetSingle(new IntPtr(p + 0x090)); // 024664FC6D08 0x90 NoteLineFailureColorB       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorA                     = GetSingle(new IntPtr(p + 0x094)); // 024664FC6D28 0x94 NoteLineFailureColorA       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionUpper                = GetSingle(new IntPtr(p + 0x098)); // 024664FC6D48 0x98 JudgementShowPositionUpper  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionCenter               = GetSingle(new IntPtr(p + 0x09C)); // 024664FC6D68 0x9C JudgementShowPositionCenter ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionCenterLower          = GetSingle(new IntPtr(p + 0x0A0)); // 024664FC6D88 0xA0 JudgementShowPositionCenterLower ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementLagShowPositionY                 = GetSingle(new IntPtr(p + 0x0A4)); // 024664FC6DA8 0xA4 JudgementLagShowPositionY   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementLagShowPositionFixedRightX       = GetSingle(new IntPtr(p + 0x0A8)); // 024664FC6DC8 0xA8 JudgementLagShowPositionFixedRightX ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 024664FC6DE8 0xB0 PropertyChanged             ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
