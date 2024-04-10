using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 charaMaxNum                              int IL2CPP_TYPE_I4
    // 020 CharacterCamera                          000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 028 LiveCharacter                            000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 030 CharaParent                              0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 038 ActData                                  000185CB7558 ModelClassListType CharacterActData[] CharacterActData[] List<CharacterActData> Pointer
    // 040 UnitIdol                                 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 048 SequenceFrame                            000186666050 ModelPrimitiveType float float float Single
    // 050 ConvertTable                             000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SwayReset                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C NoVoice                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 060 NoVoiceLipSyncRate                       000186666050 ModelPrimitiveType float float float Single
    // 068 ActMotionClip                            000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 ActAnimState                             000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 LERP_FRAME                               int IL2CPP_TYPE_I4
    // 078 CancelPoseData                           000185CC0FD8 ModelClassListType FrameData[] FrameData[] List<FrameData> Pointer
    // 080 CancelLerpCount                          0001866656B0 ModelPrimitiveType float float float Single
    // 000 cancelLerpFrame                          float IL2CPP_TYPE_R4
    // 084 NoLerpFlag                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 SpeakerList                              000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 090 LastSpeakerList                          000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
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

            value.CharacterCamera                           = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 0245A695EC50 0x20 CharacterCamera             ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.LiveCharacter                             = GetObject<LiveCharacterController>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0245A695EC70 0x28 LiveCharacter               ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CharaParent                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0245A695EC90 0x30 CharaParent                 ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.ActData                                   = GetObjectList<CharacterActData>(new IntPtr(p + 0x038), ReversePrism.DataModels.CharacterActData.FromPointer); // 0245A695ECB0 0x38 ActData                     ( 000185CB7558 ModelClassListType CharacterActData[] CharacterActData[] List<CharacterActData> Pointer )
            value.UnitIdol                                  = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A695ECD0 0x40 UnitIdol                    ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.SequenceFrame                             = GetSingle(new IntPtr(p + 0x048)); // 0245A695ECF0 0x48 SequenceFrame               ( 000186666050 ModelPrimitiveType float float float Single )
            value.ConvertTable                              = GetInt32List(new IntPtr(p + 0x050)); // 0245A695ED10 0x50 ConvertTable                ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetInt32(new IntPtr(p + 0x058)); // 0245A695ED30 0x58 SwayReset                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NoVoice                                   = GetBool(new IntPtr(p + 0x05C)); // 0245A695ED50 0x5C NoVoice                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NoVoiceLipSyncRate                        = GetSingle(new IntPtr(p + 0x060)); // 0245A695ED70 0x60 NoVoiceLipSyncRate          ( 000186666050 ModelPrimitiveType float float float Single )
            value.ActMotionClip                             = GetStringList(new IntPtr(p + 0x068)); // 0245A695ED90 0x68 ActMotionClip               ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ActAnimState                              = GetStringList(new IntPtr(p + 0x070)); // 0245A695EDB0 0x70 ActAnimState                ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CancelPoseData                            = GetObjectList<FrameData>(new IntPtr(p + 0x078), ReversePrism.DataModels.FrameData.FromPointer); // 0245A695EDF0 0x78 CancelPoseData              ( 000185CC0FD8 ModelClassListType FrameData[] FrameData[] List<FrameData> Pointer )
            value.CancelLerpCount                           = GetSingle(new IntPtr(p + 0x080)); // 0245A695EE10 0x80 CancelLerpCount             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NoLerpFlag                                = GetBool(new IntPtr(p + 0x084)); // 0245A695EE50 0x84 NoLerpFlag                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SpeakerList                               = GetInt32List(new IntPtr(p + 0x088)); // 0245A695EE70 0x88 SpeakerList                 ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.LastSpeakerList                           = GetInt32List(new IntPtr(p + 0x090)); // 0245A695EE90 0x90 LastSpeakerList             ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
