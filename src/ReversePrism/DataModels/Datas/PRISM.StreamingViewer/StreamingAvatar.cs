using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttachCheek                              ModelClassType AttachBoneObject AttachBoneObject AttachBoneObject Pointer
    // 028 CharacterId                              ModelPrimitiveType int int int Int32
    // 02C CharacterEnabled                         ModelPrimitiveType bool bool bool Bool
    // 030 Character                                ModelClassType Character Character Character Pointer
    // 038 AdditiveAnimation                        ModelClassType AdditiveAnimation AdditiveAnimation AdditiveAnimation Pointer
    // 040 CurrentAnimationName                     ModelPrimitiveType string string string String
    // 048 SwitchModels                             ModelClassListType SwitchModel[] SwitchModel[] List<SwitchModel> Pointer
    // 050 SwitchModelCheek                         ModelClassType SwitchModel SwitchModel SwitchModel Pointer
    // 058 StreamingAvatarMotion                    ModelClassType StreamingAvatarMotion StreamingAvatarMotion StreamingAvatarMotion Pointer
    // 060 StreamingAvatarExpression                ModelClassType StreamingAvatarExpression StreamingAvatarExpression StreamingAvatarExpression Pointer
    // 068 HasAvatar                                ModelPrimitiveType bool bool bool Bool
    public partial class StreamingAvatar : DataModel
    {
        public AttachBoneObject?                        AttachCheek                             { get; set; }
        public int                                      CharacterId                             { get; set; }
        public bool                                     CharacterEnabled                        { get; set; }
        public Character?                               Character                               { get; set; }
        public AdditiveAnimation?                       AdditiveAnimation                       { get; set; }
        public string                                   CurrentAnimationName                    { get; set; }
        public List<SwitchModel>?                       SwitchModels                            { get; set; }
        public SwitchModel?                             SwitchModelCheek                        { get; set; }
        public StreamingAvatarMotion?                   StreamingAvatarMotion                   { get; set; }
        public StreamingAvatarExpression?               StreamingAvatarExpression               { get; set; }
        public bool                                     HasAvatar                               { get; set; }

        public static StreamingAvatar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingAvatar() { Pointer= p0 };

            value.AttachCheek                               = GetObject<AttachBoneObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.AttachBoneObject.FromPointer); // 0x20 AttachCheek                 ( ModelClassType AttachBoneObject AttachBoneObject AttachBoneObject Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.CharacterEnabled                          = GetBool(new IntPtr(p + 0x02C)); // 0x2C CharacterEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x030), ReversePrism.DataModels.Character.FromPointer); // 0x30 Character                   ( ModelClassType Character Character Character Pointer )
            value.AdditiveAnimation                         = GetObject<AdditiveAnimation>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdditiveAnimation.FromPointer); // 0x38 AdditiveAnimation           ( ModelClassType AdditiveAnimation AdditiveAnimation AdditiveAnimation Pointer )
            value.CurrentAnimationName                      = GetString(new IntPtr(p + 0x040)); // 0x40 CurrentAnimationName        ( ModelPrimitiveType string string string String )
            value.SwitchModels                              = GetObjectList<SwitchModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SwitchModel.FromPointer); // 0x48 SwitchModels                ( ModelClassListType SwitchModel[] SwitchModel[] List<SwitchModel> Pointer )
            value.SwitchModelCheek                          = GetObject<SwitchModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.SwitchModel.FromPointer); // 0x50 SwitchModelCheek            ( ModelClassType SwitchModel SwitchModel SwitchModel Pointer )
            value.StreamingAvatarMotion                     = GetObject<StreamingAvatarMotion>(new IntPtr(p + 0x058), ReversePrism.DataModels.StreamingAvatarMotion.FromPointer); // 0x58 StreamingAvatarMotion       ( ModelClassType StreamingAvatarMotion StreamingAvatarMotion StreamingAvatarMotion Pointer )
            value.StreamingAvatarExpression                 = GetObject<StreamingAvatarExpression>(new IntPtr(p + 0x060), ReversePrism.DataModels.StreamingAvatarExpression.FromPointer); // 0x60 StreamingAvatarExpression   ( ModelClassType StreamingAvatarExpression StreamingAvatarExpression StreamingAvatarExpression Pointer )
            value.HasAvatar                                 = GetBool(new IntPtr(p + 0x068)); // 0x68 HasAvatar                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
