using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTwestaListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProfileCommentFieldNumber                int IL2CPP_TYPE_I4
    // 018 ProfileComment                           000186671910 ModelPrimitiveType string string string String
    // 000 ArticleListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_articleList_codec              FieldCodec`1<TwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    // 020 ArticleList                              000185CF5E38 ModelClassListType RepeatedField`1<TwestaArticleStatus> RepeatedField`1<TwestaArticleStatus> List<TwestaArticleStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Cursor                                   000186671910 ModelPrimitiveType string string string String
    public partial class GetTwestaListReply
    {
        public string                                   ProfileComment                          { get; set; }
        public List<TwestaArticleStatus>?               ArticleList                             { get; set; }
        public string                                   Cursor                                  { get; set; }

        public static GetTwestaListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTwestaListReply();

            value.ProfileComment                            = GetString(new IntPtr(p + 0x018)); // 0270D22EFDC0 0x18 ProfileComment              ( 000186671910 ModelPrimitiveType string string string String )
            value.ArticleList                               = GetObjectList<TwestaArticleStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaArticleStatus.FromPointer); // 0270D22EFE20 0x20 ArticleList                 ( 000185CF5E38 ModelClassListType RepeatedField`1<TwestaArticleStatus> RepeatedField`1<TwestaArticleStatus> List<TwestaArticleStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x028)); // 0270D22EFE60 0x28 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
