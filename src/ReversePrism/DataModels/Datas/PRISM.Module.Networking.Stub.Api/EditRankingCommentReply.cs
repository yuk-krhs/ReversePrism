using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EditRankingCommentReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Comment                                  000186671910 ModelPrimitiveType string string string String
    public partial class EditRankingCommentReply : DataModel
    {
        public string                                   Comment                                 { get; set; }

        public static EditRankingCommentReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditRankingCommentReply() { Pointer= p0 };

            value.Comment                                   = GetString(new IntPtr(p + 0x018)); // 024660FA5320 0x18 Comment                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
