using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 TransceiverHn                            ModelClassType CriAtomEx3dTransceiver CriAtomEx3dTransceiver CriAtomEx3dTransceiver Pointer
    // 038 InputPos                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 InputFront                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 InputUp                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 RegionOnStart                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 068 UseDedicatedInput                        ModelPrimitiveType bool bool bool Bool
    // 070 DedicatedInput                           ModelClassType GameObject GameObject GameObject Pointer
    // 078 OutputVolume                             ModelPrimitiveType float float float Single
    // 07C DirectAudioRadius                        ModelPrimitiveType float float float Single
    // 080 CrossFadeDistance                        ModelPrimitiveType float float float Single
    // 084 ConeInsideAngle                          ModelPrimitiveType float float float Single
    // 088 ConeOutsideAngle                         ModelPrimitiveType float float float Single
    // 08C ConeOutsideVolume                        ModelPrimitiveType float float float Single
    // 090 TransceiverRadius                        ModelPrimitiveType float float float Single
    // 094 InteriorDistance                         ModelPrimitiveType float float float Single
    // 098 MinAttenuation                           ModelPrimitiveType float float float Single
    // 09C MaxAttenuation                           ModelPrimitiveType float float float Single
    // 0A0 GlobalAisacName                          ModelPrimitiveType string string string String
    // 0A8 MaxAngleAisacDelta                       ModelPrimitiveType float float float Single
    // 0B0 DistanceAisacControlId                   ModelPrimitiveType string string string String
    // 0B8 ListenerAzimuthAisacControlId            ModelPrimitiveType string string string String
    // 0C0 ListenerElevationAisacControlId          ModelPrimitiveType string string string String
    // 0C8 OutputAzimuthAisacControlId              ModelPrimitiveType string string string String
    // 0D0 OutputElevationAisacControlId            ModelPrimitiveType string string string String
    // 0D8 InspectorAisacSettingFoldout             ModelPrimitiveType bool bool bool Bool
    // 0D9 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 0DA DedicatedInputNotSetWarned               ModelPrimitiveType bool bool bool Bool
    // 0E0 CurrentRegion                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    public partial class CriAtomTransceiver : DataModel
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
            var value   = new CriAtomTransceiver() { Pointer= p0 };

            value.TransceiverHn                             = GetObject<CriAtomEx3dTransceiver>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomEx3dTransceiver.FromPointer); // 0x30 TransceiverHn               ( ModelClassType CriAtomEx3dTransceiver CriAtomEx3dTransceiver CriAtomEx3dTransceiver Pointer )
            value.InputPos                                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 InputPos                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InputFront                                = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 InputFront                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.InputUp                                   = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0x50 InputUp                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RegionOnStart                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0x60 RegionOnStart               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.UseDedicatedInput                         = GetBool(new IntPtr(p + 0x068)); // 0x68 UseDedicatedInput           ( ModelPrimitiveType bool bool bool Bool )
            value.DedicatedInput                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 DedicatedInput              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OutputVolume                              = GetSingle(new IntPtr(p + 0x078)); // 0x78 OutputVolume                ( ModelPrimitiveType float float float Single )
            value.DirectAudioRadius                         = GetSingle(new IntPtr(p + 0x07C)); // 0x7C DirectAudioRadius           ( ModelPrimitiveType float float float Single )
            value.CrossFadeDistance                         = GetSingle(new IntPtr(p + 0x080)); // 0x80 CrossFadeDistance           ( ModelPrimitiveType float float float Single )
            value.ConeInsideAngle                           = GetSingle(new IntPtr(p + 0x084)); // 0x84 ConeInsideAngle             ( ModelPrimitiveType float float float Single )
            value.ConeOutsideAngle                          = GetSingle(new IntPtr(p + 0x088)); // 0x88 ConeOutsideAngle            ( ModelPrimitiveType float float float Single )
            value.ConeOutsideVolume                         = GetSingle(new IntPtr(p + 0x08C)); // 0x8C ConeOutsideVolume           ( ModelPrimitiveType float float float Single )
            value.TransceiverRadius                         = GetSingle(new IntPtr(p + 0x090)); // 0x90 TransceiverRadius           ( ModelPrimitiveType float float float Single )
            value.InteriorDistance                          = GetSingle(new IntPtr(p + 0x094)); // 0x94 InteriorDistance            ( ModelPrimitiveType float float float Single )
            value.MinAttenuation                            = GetSingle(new IntPtr(p + 0x098)); // 0x98 MinAttenuation              ( ModelPrimitiveType float float float Single )
            value.MaxAttenuation                            = GetSingle(new IntPtr(p + 0x09C)); // 0x9C MaxAttenuation              ( ModelPrimitiveType float float float Single )
            value.GlobalAisacName                           = GetString(new IntPtr(p + 0x0A0)); // 0xA0 GlobalAisacName             ( ModelPrimitiveType string string string String )
            value.MaxAngleAisacDelta                        = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 MaxAngleAisacDelta          ( ModelPrimitiveType float float float Single )
            value.DistanceAisacControlId                    = GetString(new IntPtr(p + 0x0B0)); // 0xB0 DistanceAisacControlId      ( ModelPrimitiveType string string string String )
            value.ListenerAzimuthAisacControlId             = GetString(new IntPtr(p + 0x0B8)); // 0xB8 ListenerAzimuthAisacControlId ( ModelPrimitiveType string string string String )
            value.ListenerElevationAisacControlId           = GetString(new IntPtr(p + 0x0C0)); // 0xC0 ListenerElevationAisacControlId ( ModelPrimitiveType string string string String )
            value.OutputAzimuthAisacControlId               = GetString(new IntPtr(p + 0x0C8)); // 0xC8 OutputAzimuthAisacControlId ( ModelPrimitiveType string string string String )
            value.OutputElevationAisacControlId             = GetString(new IntPtr(p + 0x0D0)); // 0xD0 OutputElevationAisacControlId ( ModelPrimitiveType string string string String )
            value.InspectorAisacSettingFoldout              = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 InspectorAisacSettingFoldout ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x0D9)); // 0xD9 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.DedicatedInputNotSetWarned                = GetBool(new IntPtr(p + 0x0DA)); // 0xDA DedicatedInputNotSetWarned  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentRegion                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0xE0 CurrentRegion               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )

            return value;
        }
    }
}
