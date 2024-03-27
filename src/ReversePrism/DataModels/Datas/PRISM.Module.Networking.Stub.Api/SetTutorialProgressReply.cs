using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetTutorialProgressReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PhaseIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 PhaseId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsSkipFieldNumber                        int IL2CPP_TYPE_I4
    // 01C IsSkip                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SetTutorialProgressReply
    {
        public int                                      PhaseId                                 { get; set; }
        public bool                                     IsSkip                                  { get; set; }

        public static SetTutorialProgressReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTutorialProgressReply();

            value.PhaseId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D2C52BF8 0x18 PhaseId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x01C)); // 0270D2C52C38 0x1C IsSkip                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
