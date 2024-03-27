using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceResumeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsResumeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 IsResume                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    public partial class GetProduceResumeReply
    {
        public bool                                     IsResume                                { get; set; }
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }

        public static GetProduceResumeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceResumeReply();

            value.IsResume                                  = GetBool(new IntPtr(p + 0x018)); // 0270D2581C60 0x18 IsResume                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D2581CA0 0x20 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )

            return value;
        }
    }
}
