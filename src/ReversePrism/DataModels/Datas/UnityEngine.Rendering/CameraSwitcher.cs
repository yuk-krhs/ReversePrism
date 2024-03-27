using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Cameras                                000185B72DE0 ModelClassListType Camera[] Camera[] List<Camera> Pointer
    // 028 M_CurrentCameraIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_OriginalCamera                         0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 038 M_OriginalCameraPosition                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 M_OriginalCameraRotation                 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 058 M_CurrentCamera                          0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 060 M_CameraNames                            000185B80930 ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer
    // 068 M_CameraIndices                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 M_DebugEntry                             000186584190 ModelClassType EnumField EnumField EnumField Pointer
    // 078 M_DebugEntryEnumIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CameraSwitcher
    {
        public List<Camera>?                            M_Cameras                               { get; set; }
        public int                                      M_CurrentCameraIndex                    { get; set; }
        public Camera?                                  M_OriginalCamera                        { get; set; }
        public Vector3                                  M_OriginalCameraPosition                { get; set; }
        public Quaternion                               M_OriginalCameraRotation                { get; set; }
        public Camera?                                  M_CurrentCamera                         { get; set; }
        public List<GUIContent>?                        M_CameraNames                           { get; set; }
        public List<int>?                               M_CameraIndices                         { get; set; }
        public EnumField?                               M_DebugEntry                            { get; set; }
        public int                                      M_DebugEntryEnumIndex                   { get; set; }

        public static CameraSwitcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraSwitcher();

            value.M_Cameras                                 = GetObjectList<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0270D90F5FC0 0x20 M_Cameras                   ( 000185B72DE0 ModelClassListType Camera[] Camera[] List<Camera> Pointer )
            value.M_CurrentCameraIndex                      = GetInt32(new IntPtr(p + 0x028)); // 0270D90F5FE0 0x28 M_CurrentCameraIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OriginalCamera                          = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0270D90F6000 0x30 M_OriginalCamera            ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.M_OriginalCameraPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0270D90F6020 0x38 M_OriginalCameraPosition    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_OriginalCameraRotation                  = (Quaternion)GetInt32(new IntPtr(p + 0x044)); // 0270D90F6040 0x44 M_OriginalCameraRotation    ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_CurrentCamera                           = GetObject<Camera>(new IntPtr(p + 0x058), ReversePrism.DataModels.Camera.FromPointer); // 0270D90F6060 0x58 M_CurrentCamera             ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.M_CameraNames                             = GetObjectList<GUIContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.GUIContent.FromPointer); // 0270D90F6080 0x60 M_CameraNames               ( 000185B80930 ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer )
            value.M_CameraIndices                           = GetInt32List(new IntPtr(p + 0x068)); // 0270D90F60A0 0x68 M_CameraIndices             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_DebugEntry                              = GetObject<EnumField>(new IntPtr(p + 0x070), ReversePrism.DataModels.EnumField.FromPointer); // 0270D90F60C0 0x70 M_DebugEntry                ( 000186584190 ModelClassType EnumField EnumField EnumField Pointer )
            value.M_DebugEntryEnumIndex                     = GetInt32(new IntPtr(p + 0x078)); // 0270D90F60E0 0x78 M_DebugEntryEnumIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
