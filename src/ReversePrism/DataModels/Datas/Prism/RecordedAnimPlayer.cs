using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EyeL                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 028 EyeR                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 030 FaceAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 BodyAnimator                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 048 RecordedAnimData                         0001866B4FE0 ModelClassType Data Data Data Pointer
    // 050 TransBones                               000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 058 CurrentDataCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C TotalDataCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 TotalFrame                               0001866656B0 ModelPrimitiveType float float float Single
    // 064 Frame                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class RecordedAnimPlayer : DataModel
    {
        public EyeController?                           EyeL                                    { get; set; }
        public EyeController?                           EyeR                                    { get; set; }
        public Animator?                                FaceAnimator                            { get; set; }
        public Animator?                                BodyAnimator                            { get; set; }
        public Character?                               Character                               { get; set; }
        public Data?                                    RecordedAnimData                        { get; set; }
        public List<Transform>?                         TransBones                              { get; set; }
        public int                                      CurrentDataCount                        { get; set; }
        public int                                      TotalDataCount                          { get; set; }
        public float                                    TotalFrame                              { get; set; }
        public float                                    Frame                                   { get; set; }

        public static RecordedAnimPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordedAnimPlayer() { Pointer= p0 };

            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x020), ReversePrism.DataModels.EyeController.FromPointer); // 024664DF2B10 0x20 EyeL                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 024664DF2B30 0x28 EyeR                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 024664DF2B50 0x30 FaceAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.BodyAnimator                              = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 024664DF2B70 0x38 BodyAnimator                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x040), ReversePrism.DataModels.Character.FromPointer); // 024664DF2B90 0x40 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.RecordedAnimData                          = GetObject<Data>(new IntPtr(p + 0x048), ReversePrism.DataModels.Data.FromPointer); // 024664DF2BB0 0x48 RecordedAnimData            ( 0001866B4FE0 ModelClassType Data Data Data Pointer )
            value.TransBones                                = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 024664DF2BD0 0x50 TransBones                  ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.CurrentDataCount                          = GetInt32(new IntPtr(p + 0x058)); // 024664DF2BF0 0x58 CurrentDataCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalDataCount                            = GetInt32(new IntPtr(p + 0x05C)); // 024664DF2C10 0x5C TotalDataCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalFrame                                = GetSingle(new IntPtr(p + 0x060)); // 024664DF2C30 0x60 TotalFrame                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x064)); // 024664DF2C50 0x64 Frame                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
