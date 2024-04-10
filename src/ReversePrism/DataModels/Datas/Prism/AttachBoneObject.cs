using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 handTransform                            Dictionary`2<Transform, TransformValue> IL2CPP_TYPE_GENERICINST
    // 038 AttachObject                             0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 040 Bone                                     0001866E72D0 ModelEnumType HumanBodyBones HumanBodyBones HumanBodyBones Int32
    // 048 CustomBone                               000186671E00 ModelPrimitiveType string string string String
    // 050 OffsetPos                                0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 05C OffsetRot                                0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 OnTriggerName                            000186671E00 ModelPrimitiveType string string string String
    // 070 OffTriggerName                           000186671E00 ModelPrimitiveType string string string String
    // 078 HandPose                                 000186635140 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 080 HandPoseAsset                            000186671E00 ModelPrimitiveType string string string String
    // 088 CharacterScale                           000186595480 ModelPrimitiveType bool bool bool Bool
    // 090 LastParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 098 LastPosition                             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0A4 LastRotation                             000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0B8 HandValue                                0001866D0AB0 ModelClassType SaveHandValue SaveHandValue SaveHandValue Pointer
    // 0C0 AttachFlag                               000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class AttachBoneObject : DataModel
    {
        public GameObject?                              AttachObject                            { get; set; }
        public HumanBodyBones                           Bone                                    { get; set; }
        public string                                   CustomBone                              { get; set; }
        public Vector3                                  OffsetPos                               { get; set; }
        public Vector3                                  OffsetRot                               { get; set; }
        public string                                   OnTriggerName                           { get; set; }
        public string                                   OffTriggerName                          { get; set; }
        public TextAsset?                               HandPose                                { get; set; }
        public string                                   HandPoseAsset                           { get; set; }
        public bool                                     CharacterScale                          { get; set; }
        public Transform?                               LastParent                              { get; set; }
        public Vector3                                  LastPosition                            { get; set; }
        public Quaternion                               LastRotation                            { get; set; }
        public SaveHandValue?                           HandValue                               { get; set; }
        public bool                                     AttachFlag                              { get; set; }

        public static AttachBoneObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachBoneObject() { Pointer= p0 };

            value.AttachObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664DCCFC0 0x38 AttachObject                ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.Bone                                      = (HumanBodyBones)GetInt32(new IntPtr(p + 0x040)); // 024664DCCFE0 0x40 Bone                        ( 0001866E72D0 ModelEnumType HumanBodyBones HumanBodyBones HumanBodyBones Int32 )
            value.CustomBone                                = GetString(new IntPtr(p + 0x048)); // 024664DCD000 0x48 CustomBone                  ( 000186671E00 ModelPrimitiveType string string string String )
            value.OffsetPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 024664DCD020 0x50 OffsetPos                   ( 0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OffsetRot                                 = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 024664DCD040 0x5C OffsetRot                   ( 0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OnTriggerName                             = GetString(new IntPtr(p + 0x068)); // 024664DCD060 0x68 OnTriggerName               ( 000186671E00 ModelPrimitiveType string string string String )
            value.OffTriggerName                            = GetString(new IntPtr(p + 0x070)); // 024664DCD080 0x70 OffTriggerName              ( 000186671E00 ModelPrimitiveType string string string String )
            value.HandPose                                  = GetObject<TextAsset>(new IntPtr(p + 0x078), ReversePrism.DataModels.TextAsset.FromPointer); // 024664DCD0A0 0x78 HandPose                    ( 000186635140 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.HandPoseAsset                             = GetString(new IntPtr(p + 0x080)); // 024664DCD0C0 0x80 HandPoseAsset               ( 000186671E00 ModelPrimitiveType string string string String )
            value.CharacterScale                            = GetBool(new IntPtr(p + 0x088)); // 024664DCD0E0 0x88 CharacterScale              ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.LastParent                                = GetObject<Transform>(new IntPtr(p + 0x090), ReversePrism.DataModels.Transform.FromPointer); // 024664DCD100 0x90 LastParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.LastPosition                              = (Vector3)GetInt32(new IntPtr(p + 0x098)); // 024664DCD120 0x98 LastPosition                ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LastRotation                              = (Quaternion)GetInt32(new IntPtr(p + 0x0A4)); // 024664DCD140 0xA4 LastRotation                ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.HandValue                                 = GetObject<SaveHandValue>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SaveHandValue.FromPointer); // 024664DCD160 0xB8 HandValue                   ( 0001866D0AB0 ModelClassType SaveHandValue SaveHandValue SaveHandValue Pointer )
            value.AttachFlag                                = GetBool(new IntPtr(p + 0x0C0)); // 024664DCD180 0xC0 AttachFlag                  ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
