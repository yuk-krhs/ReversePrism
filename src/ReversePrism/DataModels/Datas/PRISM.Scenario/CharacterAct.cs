using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 charaMaxNum                              int IL2CPP_TYPE_I4
    // 020 CharacterCamera                          ModelClassType CameraController CameraController CameraController Pointer
    // 028 LiveCharacter                            ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 030 CharaParent                              ModelClassType Transform Transform Transform Pointer
    // 038 ActData                                  ModelClassListType CharacterActData[] CharacterActData[] List<CharacterActData> Pointer
    // 040 UnitIdol                                 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 048 SequenceFrame                            ModelPrimitiveType float float float Single
    // 050 ConvertTable                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SwayReset                                ModelPrimitiveType int int int Int32
    // 05C NoVoice                                  ModelPrimitiveType bool bool bool Bool
    // 060 NoVoiceLipSyncRate                       ModelPrimitiveType float float float Single
    // 064 IsAdv                                    ModelPrimitiveType bool bool bool Bool
    // 068 ActMotionClip                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 ActAnimState                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 LERP_FRAME                               int IL2CPP_TYPE_I4
    // 078 CancelPoseData                           ModelClassListType FrameData[] FrameData[] List<FrameData> Pointer
    // 080 CancelLerpCount                          ModelPrimitiveType float float float Single
    // 000 cancelLerpFrame                          float IL2CPP_TYPE_R4
    // 084 NoLerpFlag                               ModelPrimitiveType bool bool bool Bool
    // 088 SpeakerList                              ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 090 LastSpeakerList                          ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class CharacterAct : DataModel
    {
        public CameraController?                        CharacterCamera                         { get; set; }
        public LiveCharacterController?                 LiveCharacter                           { get; set; }
        public Transform?                               CharaParent                             { get; set; }
        public List<CharacterActData>?                  ActData                                 { get; set; }
        public List<UnitIdol>?                          UnitIdol                                { get; set; }
        public float                                    SequenceFrame                           { get; set; }
        public List<int>?                               ConvertTable                            { get; set; }
        public int                                      SwayReset                               { get; set; }
        public bool                                     NoVoice                                 { get; set; }
        public float                                    NoVoiceLipSyncRate                      { get; set; }
        public bool                                     IsAdv                                   { get; set; }
        public List<string>?                            ActMotionClip                           { get; set; }
        public List<string>?                            ActAnimState                            { get; set; }
        public List<FrameData>?                         CancelPoseData                          { get; set; }
        public float                                    CancelLerpCount                         { get; set; }
        public bool                                     NoLerpFlag                              { get; set; }
        public List<int>?                               SpeakerList                             { get; set; }
        public List<int>?                               LastSpeakerList                         { get; set; }

        public static CharacterAct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterAct() { Pointer= p0 };

            value.CharacterCamera                           = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0x20 CharacterCamera             ( ModelClassType CameraController CameraController CameraController Pointer )
            value.LiveCharacter                             = GetObject<LiveCharacterController>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x28 LiveCharacter               ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CharaParent                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 CharaParent                 ( ModelClassType Transform Transform Transform Pointer )
            value.ActData                                   = GetObjectList<CharacterActData>(new IntPtr(p + 0x038), ReversePrism.DataModels.CharacterActData.FromPointer); // 0x38 ActData                     ( ModelClassListType CharacterActData[] CharacterActData[] List<CharacterActData> Pointer )
            value.UnitIdol                                  = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x40 UnitIdol                    ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x048)); // 0x48 SequenceFrame               ( ModelPrimitiveType float float float Single )
            value.ConvertTable                              = GetInt32List(new IntPtr(p + 0x050)); // 0x50 ConvertTable                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 SwayReset                   ( ModelPrimitiveType int int int Int32 )
            value.NoVoice                                   = GetBool(new IntPtr(p + 0x05C)); // 0x5C NoVoice                     ( ModelPrimitiveType bool bool bool Bool )
            value.NoVoiceLipSyncRate                        = GetSingle(new IntPtr(p + 0x060)); // 0x60 NoVoiceLipSyncRate          ( ModelPrimitiveType float float float Single )
            value.IsAdv                                     = GetBool(new IntPtr(p + 0x064)); // 0x64 IsAdv                       ( ModelPrimitiveType bool bool bool Bool )
            value.ActMotionClip                             = GetStringList(new IntPtr(p + 0x068)); // 0x68 ActMotionClip               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ActAnimState                              = GetStringList(new IntPtr(p + 0x070)); // 0x70 ActAnimState                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CancelPoseData                            = GetObjectList<FrameData>(new IntPtr(p + 0x078), ReversePrism.DataModels.FrameData.FromPointer); // 0x78 CancelPoseData              ( ModelClassListType FrameData[] FrameData[] List<FrameData> Pointer )
            value.CancelLerpCount                           = GetSingle(new IntPtr(p + 0x080)); // 0x80 CancelLerpCount             ( ModelPrimitiveType float float float Single )
            value.NoLerpFlag                                = GetBool(new IntPtr(p + 0x084)); // 0x84 NoLerpFlag                  ( ModelPrimitiveType bool bool bool Bool )
            value.SpeakerList                               = GetInt32List(new IntPtr(p + 0x088)); // 0x88 SpeakerList                 ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.LastSpeakerList                           = GetInt32List(new IntPtr(p + 0x090)); // 0x90 LastSpeakerList             ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
