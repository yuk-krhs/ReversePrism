using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttachCheek                              00018670EBA0 ModelClassType AttachBoneObject AttachBoneObject AttachBoneObject Pointer
    // 028 CharacterId                              0001865F3220 ModelPrimitiveType int int int Int32
    // 02C CharacterEnabled                         000186595480 ModelPrimitiveType bool bool bool Bool
    // 030 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 038 AdditiveAnimation                        00018668C870 ModelClassType AdditiveAnimation AdditiveAnimation AdditiveAnimation Pointer
    // 040 CurrentAnimationName                     000186671E00 ModelPrimitiveType string string string String
    // 048 SwitchModels                             000185CA8A88 ModelClassListType SwitchModel[] SwitchModel[] List<SwitchModel> Pointer
    // 050 SwitchModelCheek                         0001865FD990 ModelClassType SwitchModel SwitchModel SwitchModel Pointer
    // 058 StreamingAvatarMotion                    0001865B87E0 ModelClassType StreamingAvatarMotion StreamingAvatarMotion StreamingAvatarMotion Pointer
    // 060 StreamingAvatarExpression                0001865B8090 ModelClassType StreamingAvatarExpression StreamingAvatarExpression StreamingAvatarExpression Pointer
    // 068 HasAvatar                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 IsLoadingIdol                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StreamingAvatar
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
        public bool                                     IsLoadingIdol                           { get; set; }

        public static StreamingAvatar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingAvatar();

            value.AttachCheek                               = GetObject<AttachBoneObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.AttachBoneObject.FromPointer); // 0270D4F2D9B8 0x20 AttachCheek                 ( 00018670EBA0 ModelClassType AttachBoneObject AttachBoneObject AttachBoneObject Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x028)); // 0270D4F2D9D8 0x28 CharacterId                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CharacterEnabled                          = GetBool(new IntPtr(p + 0x02C)); // 0270D4F2D9F8 0x2C CharacterEnabled            ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x030), ReversePrism.DataModels.Character.FromPointer); // 0270D4F2DA18 0x30 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.AdditiveAnimation                         = GetObject<AdditiveAnimation>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdditiveAnimation.FromPointer); // 0270D4F2DA38 0x38 AdditiveAnimation           ( 00018668C870 ModelClassType AdditiveAnimation AdditiveAnimation AdditiveAnimation Pointer )
            value.CurrentAnimationName                      = GetString(new IntPtr(p + 0x040)); // 0270D4F2DA58 0x40 CurrentAnimationName        ( 000186671E00 ModelPrimitiveType string string string String )
            value.SwitchModels                              = GetObjectList<SwitchModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SwitchModel.FromPointer); // 0270D4F2DA78 0x48 SwitchModels                ( 000185CA8A88 ModelClassListType SwitchModel[] SwitchModel[] List<SwitchModel> Pointer )
            value.SwitchModelCheek                          = GetObject<SwitchModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.SwitchModel.FromPointer); // 0270D4F2DA98 0x50 SwitchModelCheek            ( 0001865FD990 ModelClassType SwitchModel SwitchModel SwitchModel Pointer )
            value.StreamingAvatarMotion                     = GetObject<StreamingAvatarMotion>(new IntPtr(p + 0x058), ReversePrism.DataModels.StreamingAvatarMotion.FromPointer); // 0270D4F2DAB8 0x58 StreamingAvatarMotion       ( 0001865B87E0 ModelClassType StreamingAvatarMotion StreamingAvatarMotion StreamingAvatarMotion Pointer )
            value.StreamingAvatarExpression                 = GetObject<StreamingAvatarExpression>(new IntPtr(p + 0x060), ReversePrism.DataModels.StreamingAvatarExpression.FromPointer); // 0270D4F2DAD8 0x60 StreamingAvatarExpression   ( 0001865B8090 ModelClassType StreamingAvatarExpression StreamingAvatarExpression StreamingAvatarExpression Pointer )
            value.HasAvatar                                 = GetBool(new IntPtr(p + 0x068)); // 0270D4F2DAF8 0x68 HasAvatar                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoadingIdol                             = GetBool(new IntPtr(p + 0x069)); // 0270D4F2DB18 0x69 IsLoadingIdol               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
