using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EyeL                                     ModelClassType EyeController EyeController EyeController Pointer
    // 028 EyeR                                     ModelClassType EyeController EyeController EyeController Pointer
    // 030 FaceAnimator                             ModelClassType Animator Animator Animator Pointer
    // 038 BodyAnimator                             ModelClassType Animator Animator Animator Pointer
    // 040 Character                                ModelClassType Character Character Character Pointer
    // 048 RecordedAnimData                         ModelClassType Data Data Data Pointer
    // 050 TransBones                               ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 058 CurrentDataCount                         ModelPrimitiveType int int int Int32
    // 05C TotalDataCount                           ModelPrimitiveType int int int Int32
    // 060 TotalFrame                               ModelPrimitiveType float float float Single
    // 064 Frame                                    ModelPrimitiveType float float float Single
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

            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x020), ReversePrism.DataModels.EyeController.FromPointer); // 0x20 EyeL                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EyeController.FromPointer); // 0x28 EyeR                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.FaceAnimator                              = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 FaceAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.BodyAnimator                              = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 BodyAnimator                ( ModelClassType Animator Animator Animator Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x040), ReversePrism.DataModels.Character.FromPointer); // 0x40 Character                   ( ModelClassType Character Character Character Pointer )
            value.RecordedAnimData                          = GetObject<Data>(new IntPtr(p + 0x048), ReversePrism.DataModels.Data.FromPointer); // 0x48 RecordedAnimData            ( ModelClassType Data Data Data Pointer )
            value.TransBones                                = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 TransBones                  ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.CurrentDataCount                          = GetInt32(new IntPtr(p + 0x058)); // 0x58 CurrentDataCount            ( ModelPrimitiveType int int int Int32 )
            value.TotalDataCount                            = GetInt32(new IntPtr(p + 0x05C)); // 0x5C TotalDataCount              ( ModelPrimitiveType int int int Int32 )
            value.TotalFrame                                = GetSingle(new IntPtr(p + 0x060)); // 0x60 TotalFrame                  ( ModelPrimitiveType float float float Single )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x064)); // 0x64 Frame                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
