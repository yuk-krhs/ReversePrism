using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ButtonParent                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 030 ChoiceButtons                            ModelClassListType ChainTalkChoiceButton[] ChainTalkChoiceButton[] List<ChainTalkChoiceButton> Pointer
    // 038 IsWaiting                                ModelPrimitiveType bool bool bool Bool
    // 03C ChoiceIndex                              ModelPrimitiveType int int int Int32
    // 040 onShowSubject                            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 Button2                                  ModelPrimitiveType int int int Int32
    // 04C Button3                                  ModelPrimitiveType int int int Int32
    public partial class ChainTalkChoiceButtonGroup : DataModel
    {
        public GameObject?                              ButtonParent                            { get; set; }
        public Animator?                                Animator                                { get; set; }
        public List<ChainTalkChoiceButton>?             ChoiceButtons                           { get; set; }
        public bool                                     IsWaiting                               { get; set; }
        public int                                      ChoiceIndex                             { get; set; }
        public int                                      Button2                                 { get; set; }
        public int                                      Button3                                 { get; set; }

        public static ChainTalkChoiceButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkChoiceButtonGroup() { Pointer= p0 };

            value.ButtonParent                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ButtonParent                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.ChoiceButtons                             = GetObjectList<ChainTalkChoiceButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkChoiceButton.FromPointer); // 0x30 ChoiceButtons               ( ModelClassListType ChainTalkChoiceButton[] ChainTalkChoiceButton[] List<ChainTalkChoiceButton> Pointer )
            value.IsWaiting                                 = GetBool(new IntPtr(p + 0x038)); // 0x38 IsWaiting                   ( ModelPrimitiveType bool bool bool Bool )
            value.ChoiceIndex                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ChoiceIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Button2                                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 Button2                     ( ModelPrimitiveType int int int Int32 )
            value.Button3                                   = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Button3                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
