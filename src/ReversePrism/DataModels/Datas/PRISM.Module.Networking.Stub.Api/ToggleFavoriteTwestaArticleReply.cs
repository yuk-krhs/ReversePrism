using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ToggleFavoriteTwestaArticleReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_article_codec                  FieldCodec`1<TwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    // 018 Article                                  000185CF5E38 ModelClassListType RepeatedField`1<TwestaArticleStatus> RepeatedField`1<TwestaArticleStatus> List<TwestaArticleStatus> Pointer
    public partial class ToggleFavoriteTwestaArticleReply : DataModel
    {
        public List<TwestaArticleStatus>?               Article                                 { get; set; }

        public static ToggleFavoriteTwestaArticleReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleFavoriteTwestaArticleReply() { Pointer= p0 };

            value.Article                                   = GetObjectList<TwestaArticleStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TwestaArticleStatus.FromPointer); // 02466227A648 0x18 Article                     ( 000185CF5E38 ModelClassListType RepeatedField`1<TwestaArticleStatus> RepeatedField`1<TwestaArticleStatus> List<TwestaArticleStatus> Pointer )

            return value;
        }
    }
}
