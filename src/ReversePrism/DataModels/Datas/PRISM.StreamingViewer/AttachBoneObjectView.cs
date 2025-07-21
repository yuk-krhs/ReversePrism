using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 IsLoaded                                 ModelPrimitiveType bool bool bool Bool
    // 024 CharacterId                              ModelPrimitiveType int int int Int32
    // 028 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 030 ObjectPath                               ModelPrimitiveType string string string String
    // 038 Bone                                     ModelEnumType HumanBodyBones HumanBodyBones HumanBodyBones Int32
    // 03C Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 Rotation                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 OnTriggerName                            ModelPrimitiveType string string string String
    // 060 OffTriggerName                           ModelPrimitiveType string string string String
    // 068 HandPose                                 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 070 HandPoseName                             ModelPrimitiveType string string string String
    // 078 ReleaseHandItem                          ModelPrimitiveType bool bool bool Bool
    // 080 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 088 HandItem                                 ModelClassType GameObject GameObject GameObject Pointer
    // 090 AccessoryItem                            ModelClassType GameObject GameObject GameObject Pointer
    // 098 StreamingAvatarAttachBoneObject          ModelClassType StreamingAvatarAttachBoneObject StreamingAvatarAttachBoneObject StreamingAvatarAttachBoneObject Pointer
    // 0A0 Id                                       ModelPrimitiveType int int int Int32
    // 0A4 IsViewPaused                             ModelPrimitiveType bool bool bool Bool
    public partial class AttachBoneObjectView : DataModel
    {
        public bool                                     IsLoaded                                { get; set; }
        public int                                      CharacterId                             { get; set; }
        public bool                                     Enable                                  { get; set; }
        public string                                   ObjectPath                              { get; set; }
        public HumanBodyBones                           Bone                                    { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Vector3                                  Rotation                                { get; set; }
        public string                                   OnTriggerName                           { get; set; }
        public string                                   OffTriggerName                          { get; set; }
        public TextAsset?                               HandPose                                { get; set; }
        public string                                   HandPoseName                            { get; set; }
        public bool                                     ReleaseHandItem                         { get; set; }
        public GameObject?                              HandItem                                { get; set; }
        public GameObject?                              AccessoryItem                           { get; set; }
        public StreamingAvatarAttachBoneObject?         StreamingAvatarAttachBoneObject         { get; set; }
        public int                                      Id                                      { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static AttachBoneObjectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachBoneObjectView() { Pointer= p0 };

            value.IsLoaded                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsLoaded                    ( ModelPrimitiveType bool bool bool Bool )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.ObjectPath                                = GetString(new IntPtr(p + 0x030)); // 0x30 ObjectPath                  ( ModelPrimitiveType string string string String )
            value.Bone                                      = (HumanBodyBones)GetInt32(new IntPtr(p + 0x038)); // 0x38 Bone                        ( ModelEnumType HumanBodyBones HumanBodyBones HumanBodyBones Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 0x48 Rotation                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OnTriggerName                             = GetString(new IntPtr(p + 0x058)); // 0x58 OnTriggerName               ( ModelPrimitiveType string string string String )
            value.OffTriggerName                            = GetString(new IntPtr(p + 0x060)); // 0x60 OffTriggerName              ( ModelPrimitiveType string string string String )
            value.HandPose                                  = GetObject<TextAsset>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextAsset.FromPointer); // 0x68 HandPose                    ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.HandPoseName                              = GetString(new IntPtr(p + 0x070)); // 0x70 HandPoseName                ( ModelPrimitiveType string string string String )
            value.ReleaseHandItem                           = GetBool(new IntPtr(p + 0x078)); // 0x78 ReleaseHandItem             ( ModelPrimitiveType bool bool bool Bool )
            value.HandItem                                  = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 HandItem                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AccessoryItem                             = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 AccessoryItem               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StreamingAvatarAttachBoneObject           = GetObject<StreamingAvatarAttachBoneObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.StreamingAvatarAttachBoneObject.FromPointer); // 0x98 StreamingAvatarAttachBoneObject ( ModelClassType StreamingAvatarAttachBoneObject StreamingAvatarAttachBoneObject StreamingAvatarAttachBoneObject Pointer )
            value.Id                                        = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Id                          ( ModelPrimitiveType int int int Int32 )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 IsViewPaused                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
