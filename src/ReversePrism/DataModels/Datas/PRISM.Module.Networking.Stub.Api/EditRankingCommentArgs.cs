using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EditRankingCommentArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Comment                                  000186671910 ModelPrimitiveType string string string String
    public partial class EditRankingCommentArgs
    {
        public int                                      MstEventId                              { get; set; }
        public string                                   Comment                                 { get; set; }

        public static EditRankingCommentArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditRankingCommentArgs();

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0270041A8798 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Comment                                   = GetString(new IntPtr(p + 0x020)); // 0270041A87D8 0x20 Comment                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
