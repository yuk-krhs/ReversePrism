using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectIdolSkillReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceIdol                              ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    public partial class SelectIdolSkillReply : DataModel
    {
        public ProduceIdolStatus?                       ProduceIdol                             { get; set; }

        public static SelectIdolSkillReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectIdolSkillReply() { Pointer= p0 };

            value.ProduceIdol                               = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x18 ProduceIdol                 ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )

            return value;
        }
    }
}
