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
    public partial class RhythmGameParameters
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
            var value   = new RhythmGameParameters();

            value.カメラ切り替え間引き秒数                              = GetSingle(new IntPtr(p + 0x010)); // 0270D4F5FF38 0x10 カメラ切り替え間引き秒数                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TextureBorderU                            = GetSingle(new IntPtr(p + 0x014)); // 0270D4F5FF58 0x14 TextureBorderU              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MeshBorderSpace                           = GetSingle(new IntPtr(p + 0x018)); // 0270D4F5FF78 0x18 MeshBorderSpace             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MeshBorderWidth                           = GetSingle(new IntPtr(p + 0x01C)); // 0270D4F5FF98 0x1C MeshBorderWidth             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LerpPow                                   = GetSingle(new IntPtr(p + 0x020)); // 0270D4F5FFB8 0x20 LerpPow                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LerpOffset                                = GetSingle(new IntPtr(p + 0x024)); // 0270D4F5FFD8 0x24 LerpOffset                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScoreConstantCoefficient                  = GetSingle(new IntPtr(p + 0x028)); // 0270D4F5FFF8 0x28 ScoreConstantCoefficient    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxNoteHeightScale                        = GetSingle(new IntPtr(p + 0x02C)); // 0270D4F60018 0x2C MaxNoteHeightScale          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SE再生間隔                                    = GetSingle(new IntPtr(p + 0x030)); // 0270D4F60038 0x30 SE再生間隔                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IOSパターンID                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D4F60058 0x34 IOSパターンID                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Androidミリ秒数                               = GetInt32(new IntPtr(p + 0x038)); // 0270D4F60078 0x38 Androidミリ秒数                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TargetType                                = (NoteType)GetInt32(new IntPtr(p + 0x048)); // 0270D4F600B8 0x48 TargetType                  ( 0001866B0820 ModelEnumType NoteType NoteType NoteType Int32 )
            value.早押しMiss秒数                                 = GetSingle(new IntPtr(p + 0x04C)); // 0270D4F600D8 0x4C 早押しMiss秒数                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.フリック判定する秒間レーン移動量                          = GetSingle(new IntPtr(p + 0x050)); // 0270D4F600F8 0x50 フリック判定する秒間レーン移動量            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Reverse判定開始秒数                             = GetSingle(new IntPtr(p + 0x054)); // 0270D4F60118 0x54 Reverse判定開始秒数               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.タップズレ許容幅                                  = GetSingle(new IntPtr(p + 0x058)); // 0270D4F60138 0x58 タップズレ許容幅                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ズームイン秒数                                   = GetSingle(new IntPtr(p + 0x05C)); // 0270D4F60158 0x5C ズームイン秒数                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.表示秒数                                      = GetSingle(new IntPtr(p + 0x060)); // 0270D4F60178 0x60 表示秒数                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ズームアウト秒数                                  = GetSingle(new IntPtr(p + 0x064)); // 0270D4F60198 0x64 ズームアウト秒数                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorR                    = GetSingle(new IntPtr(p + 0x068)); // 0270D4F601B8 0x68 NoteLineNotJudgeColorR      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorG                    = GetSingle(new IntPtr(p + 0x06C)); // 0270D4F601D8 0x6C NoteLineNotJudgeColorG      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorB                    = GetSingle(new IntPtr(p + 0x070)); // 0270D4F601F8 0x70 NoteLineNotJudgeColorB      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineNotJudgeColorA                    = GetSingle(new IntPtr(p + 0x074)); // 0270D4F60218 0x74 NoteLineNotJudgeColorA      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorR                     = GetSingle(new IntPtr(p + 0x078)); // 0270D4F60238 0x78 NoteLineSuccessColorR       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorG                     = GetSingle(new IntPtr(p + 0x07C)); // 0270D4F60258 0x7C NoteLineSuccessColorG       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorB                     = GetSingle(new IntPtr(p + 0x080)); // 0270D4F60278 0x80 NoteLineSuccessColorB       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineSuccessColorA                     = GetSingle(new IntPtr(p + 0x084)); // 0270D4F60298 0x84 NoteLineSuccessColorA       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorR                     = GetSingle(new IntPtr(p + 0x088)); // 0270D4F602B8 0x88 NoteLineFailureColorR       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorG                     = GetSingle(new IntPtr(p + 0x08C)); // 0270D4F602D8 0x8C NoteLineFailureColorG       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorB                     = GetSingle(new IntPtr(p + 0x090)); // 0270D4F602F8 0x90 NoteLineFailureColorB       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoteLineFailureColorA                     = GetSingle(new IntPtr(p + 0x094)); // 0270D4F60318 0x94 NoteLineFailureColorA       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionUpper                = GetSingle(new IntPtr(p + 0x098)); // 0270D4F60338 0x98 JudgementShowPositionUpper  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionCenter               = GetSingle(new IntPtr(p + 0x09C)); // 0270D4F60358 0x9C JudgementShowPositionCenter ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementShowPositionCenterLower          = GetSingle(new IntPtr(p + 0x0A0)); // 0270D4F60378 0xA0 JudgementShowPositionCenterLower ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementLagShowPositionY                 = GetSingle(new IntPtr(p + 0x0A4)); // 0270D4F60398 0xA4 JudgementLagShowPositionY   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JudgementLagShowPositionFixedRightX       = GetSingle(new IntPtr(p + 0x0A8)); // 0270D4F603B8 0xA8 JudgementLagShowPositionFixedRightX ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0270D4F603D8 0xB0 PropertyChanged             ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
