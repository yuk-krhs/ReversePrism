using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ResumePvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MatchFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Match                                    0001865EA7A0 ModelClassType PvpMatchStatus PvpMatchStatus PvpMatchStatus Pointer
    public partial class ResumePvpMatchReply
    {
        public PvpMatchStatus?                          Match                                   { get; set; }

        public static ResumePvpMatchReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResumePvpMatchReply();

            value.Match                                     = GetObject<PvpMatchStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpMatchStatus.FromPointer); // 0270D274A2F8 0x18 Match                       ( 0001865EA7A0 ModelClassType PvpMatchStatus PvpMatchStatus PvpMatchStatus Pointer )

            return value;
        }
    }
}
