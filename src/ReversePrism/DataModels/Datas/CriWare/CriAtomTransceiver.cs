using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 TransceiverHn                            000186644D70 ModelClassType CriAtomEx3dTransceiver CriAtomEx3dTransceiver CriAtomEx3dTransceiver Pointer
    // 038 InputPos                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 InputFront                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 InputUp                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 RegionOnStart                            00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 068 UseDedicatedInput                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 DedicatedInput                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 OutputVolume                             0001866656B0 ModelPrimitiveType float float float Single
    // 07C DirectAudioRadius                        0001866656B0 ModelPrimitiveType float float float Single
    // 080 CrossFadeDistance                        0001866656B0 ModelPrimitiveType float float float Single
    // 084 ConeInsideAngle                          0001866656B0 ModelPrimitiveType float float float Single
    // 088 ConeOutsideAngle                         0001866656B0 ModelPrimitiveType float float float Single
    // 08C ConeOutsideVolume                        0001866656B0 ModelPrimitiveType float float float Single
    // 090 TransceiverRadius                        0001866656B0 ModelPrimitiveType float float float Single
    // 094 InteriorDistance                         0001866656B0 ModelPrimitiveType float float float Single
    // 098 MinAttenuation                           000186666050 ModelPrimitiveType float float float Single
    // 09C MaxAttenuation                           000186666050 ModelPrimitiveType float float float Single
    // 0A0 GlobalAisacName                          000186671910 ModelPrimitiveType string string string String
    // 0A8 MaxAngleAisacDelta                       0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 DistanceAisacControlId                   000186671910 ModelPrimitiveType string string string String
    // 0B8 ListenerAzimuthAisacControlId            000186671910 ModelPrimitiveType string string string String
    // 0C0 ListenerElevationAisacControlId          000186671910 ModelPrimitiveType string string string String
    // 0C8 OutputAzimuthAisacControlId              000186671910 ModelPrimitiveType string string string String
    // 0D0 OutputElevationAisacControlId            000186671910 ModelPrimitiveType string string string String
    // 0D8 InspectorAisacSettingFoldout             000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 0D9 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0DA DedicatedInputNotSetWarned               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 CurrentRegion                            00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    public partial class CriAtomTransceiver
    {
        public CriAtomEx3dTransceiver?                  TransceiverHn                           { get; set; }
        public Vector3                                  InputPos                                { get; set; }
        public Vector3                                  InputFront                              { get; set; }
        public Vector3                                  InputUp                                 { get; set; }
        public CriAtomRegion?                           RegionOnStart                           { get; set; }
        public bool                                     UseDedicatedInput                       { get; set; }
        public GameObject?                              DedicatedInput                          { get; set; }
        public float                                    OutputVolume                            { get; set; }
        public float                                    DirectAudioRadius                       { get; set; }
        public float                                    CrossFadeDistance                       { get; set; }
        public float                                    ConeInsideAngle                         { get; set; }
        public float                                    ConeOutsideAngle                        { get; set; }
        public float                                    ConeOutsideVolume                       { get; set; }
        public float                                    TransceiverRadius                       { get; set; }
        public float                                    InteriorDistance                        { get; set; }
        public float                                    MinAttenuation                          { get; set; }
        public float                                    MaxAttenuation                          { get; set; }
        public string                                   GlobalAisacName                         { get; set; }
        public float                                    MaxAngleAisacDelta                      { get; set; }
        public string                                   DistanceAisacControlId                  { get; set; }
        public string                                   ListenerAzimuthAisacControlId           { get; set; }
        public string                                   ListenerElevationAisacControlId         { get; set; }
        public string                                   OutputAzimuthAisacControlId             { get; set; }
        public string                                   OutputElevationAisacControlId           { get; set; }
        public bool                                     InspectorAisacSettingFoldout            { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     DedicatedInputNotSetWarned              { get; set; }
        public CriAtomRegion?                           CurrentRegion                           { get; set; }

        public static CriAtomTransceiver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomTransceiver();

            value.TransceiverHn                             = GetObject<CriAtomEx3dTransceiver>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dTransceiver.FromPointer); // 0270DAC60378 0x30 TransceiverHn               ( 000186644D70 ModelClassType CriAtomEx3dTransceiver CriAtomEx3dTransceiver CriAtomEx3dTransceiver Pointer )
            value.InputPos                                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0270DAC60398 0x38 InputPos                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InputFront                                = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0270DAC603B8 0x44 InputFront                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InputUp                                   = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0270DAC603D8 0x50 InputUp                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RegionOnStart                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0270DAC603F8 0x60 RegionOnStart               ( 00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.UseDedicatedInput                         = GetBool(new IntPtr(p + 0x068)); // 0270DAC60418 0x68 UseDedicatedInput           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DedicatedInput                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270DAC60438 0x70 DedicatedInput              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OutputVolume                              = GetSingle(new IntPtr(p + 0x078)); // 0270DAC60458 0x78 OutputVolume                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DirectAudioRadius                         = GetSingle(new IntPtr(p + 0x07C)); // 0270DAC60478 0x7C DirectAudioRadius           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CrossFadeDistance                         = GetSingle(new IntPtr(p + 0x080)); // 0270DAC60498 0x80 CrossFadeDistance           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ConeInsideAngle                           = GetSingle(new IntPtr(p + 0x084)); // 0270DAC604B8 0x84 ConeInsideAngle             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ConeOutsideAngle                          = GetSingle(new IntPtr(p + 0x088)); // 0270DAC604D8 0x88 ConeOutsideAngle            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ConeOutsideVolume                         = GetSingle(new IntPtr(p + 0x08C)); // 0270DAC604F8 0x8C ConeOutsideVolume           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TransceiverRadius                         = GetSingle(new IntPtr(p + 0x090)); // 0270DAC60518 0x90 TransceiverRadius           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InteriorDistance                          = GetSingle(new IntPtr(p + 0x094)); // 0270DAC60538 0x94 InteriorDistance            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinAttenuation                            = GetSingle(new IntPtr(p + 0x098)); // 0270DAC60558 0x98 MinAttenuation              ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAttenuation                            = GetSingle(new IntPtr(p + 0x09C)); // 0270DAC60578 0x9C MaxAttenuation              ( 000186666050 ModelPrimitiveType float float float Single )
            value.GlobalAisacName                           = GetString(new IntPtr(p + 0x0A0)); // 0270DAC60598 0xA0 GlobalAisacName             ( 000186671910 ModelPrimitiveType string string string String )
            value.MaxAngleAisacDelta                        = GetSingle(new IntPtr(p + 0x0A8)); // 0270DAC605B8 0xA8 MaxAngleAisacDelta          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DistanceAisacControlId                    = GetString(new IntPtr(p + 0x0B0)); // 0270DAC605D8 0xB0 DistanceAisacControlId      ( 000186671910 ModelPrimitiveType string string string String )
            value.ListenerAzimuthAisacControlId             = GetString(new IntPtr(p + 0x0B8)); // 0270DAC605F8 0xB8 ListenerAzimuthAisacControlId ( 000186671910 ModelPrimitiveType string string string String )
            value.ListenerElevationAisacControlId           = GetString(new IntPtr(p + 0x0C0)); // 0270DAC60618 0xC0 ListenerElevationAisacControlId ( 000186671910 ModelPrimitiveType string string string String )
            value.OutputAzimuthAisacControlId               = GetString(new IntPtr(p + 0x0C8)); // 0270DAC60638 0xC8 OutputAzimuthAisacControlId ( 000186671910 ModelPrimitiveType string string string String )
            value.OutputElevationAisacControlId             = GetString(new IntPtr(p + 0x0D0)); // 0270DAC60658 0xD0 OutputElevationAisacControlId ( 000186671910 ModelPrimitiveType string string string String )
            value.InspectorAisacSettingFoldout              = GetBool(new IntPtr(p + 0x0D8)); // 0270DAC60678 0xD8 InspectorAisacSettingFoldout ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x0D9)); // 0270DAC60698 0xD9 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DedicatedInputNotSetWarned                = GetBool(new IntPtr(p + 0x0DA)); // 0270DAC606B8 0xDA DedicatedInputNotSetWarned  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentRegion                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0270DAC606D8 0xE0 CurrentRegion               ( 00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )

            return value;
        }
    }
}
