using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Cameras                                ModelClassListType Camera[] Camera[] List<Camera> Pointer
    // 028 M_CurrentCameraIndex                     ModelPrimitiveType int int int Int32
    // 030 M_OriginalCamera                         ModelClassType Camera Camera Camera Pointer
    // 038 M_OriginalCameraPosition                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 M_OriginalCameraRotation                 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 058 M_CurrentCamera                          ModelClassType Camera Camera Camera Pointer
    // 060 M_CameraNames                            ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer
    // 068 M_CameraIndices                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 M_DebugEntry                             ModelClassType EnumField EnumField EnumField Pointer
    // 078 M_DebugEntryEnumIndex                    ModelPrimitiveType int int int Int32
    public partial class CameraSwitcher : DataModel
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
            var value   = new CameraSwitcher() { Pointer= p0 };

            value.M_Cameras                                 = GetObjectList<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 M_Cameras                   ( ModelClassListType Camera[] Camera[] List<Camera> Pointer )
            value.M_CurrentCameraIndex                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_CurrentCameraIndex        ( ModelPrimitiveType int int int Int32 )
            value.M_OriginalCamera                          = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0x30 M_OriginalCamera            ( ModelClassType Camera Camera Camera Pointer )
            value.M_OriginalCameraPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_OriginalCameraPosition    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_OriginalCameraRotation                  = (Quaternion)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_OriginalCameraRotation    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_CurrentCamera                           = GetObject<Camera>(new IntPtr(p + 0x058), ReversePrism.DataModels.Camera.FromPointer); // 0x58 M_CurrentCamera             ( ModelClassType Camera Camera Camera Pointer )
            value.M_CameraNames                             = GetObjectList<GUIContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.GUIContent.FromPointer); // 0x60 M_CameraNames               ( ModelClassListType GUIContent[] GUIContent[] List<GUIContent> Pointer )
            value.M_CameraIndices                           = GetInt32List(new IntPtr(p + 0x068)); // 0x68 M_CameraIndices             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_DebugEntry                              = GetObject<EnumField>(new IntPtr(p + 0x070), ReversePrism.DataModels.EnumField.FromPointer); // 0x70 M_DebugEntry                ( ModelClassType EnumField EnumField EnumField Pointer )
            value.M_DebugEntryEnumIndex                     = GetInt32(new IntPtr(p + 0x078)); // 0x78 M_DebugEntryEnumIndex       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
