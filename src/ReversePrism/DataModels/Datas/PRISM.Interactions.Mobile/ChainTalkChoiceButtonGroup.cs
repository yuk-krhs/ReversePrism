using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ButtonParent                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 ChoiceButtons                            000185CB7258 ModelClassListType ChainTalkChoiceButton[] ChainTalkChoiceButton[] List<ChainTalkChoiceButton> Pointer
    // 038 IsWaiting                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C ChoiceIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 onShowSubject                            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 Button2                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 04C Button3                                  0001865F4260 ModelPrimitiveType int int int Int32
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

            value.ButtonParent                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B14D750 0x20 ButtonParent                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466B14D770 0x28 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ChoiceButtons                             = GetObjectList<ChainTalkChoiceButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkChoiceButton.FromPointer); // 02466B14D790 0x30 ChoiceButtons               ( 000185CB7258 ModelClassListType ChainTalkChoiceButton[] ChainTalkChoiceButton[] List<ChainTalkChoiceButton> Pointer )
            value.IsWaiting                                 = GetBool(new IntPtr(p + 0x038)); // 02466B14D7B0 0x38 IsWaiting                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ChoiceIndex                               = GetInt32(new IntPtr(p + 0x03C)); // 02466B14D7D0 0x3C ChoiceIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Button2                                   = GetInt32(new IntPtr(p + 0x048)); // 02466B14D810 0x48 Button2                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Button3                                   = GetInt32(new IntPtr(p + 0x04C)); // 02466B14D830 0x4C Button3                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
