using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TwestaComment                            000186683810 ModelClassType ITwestaArticleCommentStatus ITwestaArticleCommentStatus ITwestaArticleCommentStatus Pointer
    // 018 UserName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 CommentText                              000186672F10 ModelPrimitiveType string string string String
    // 028 IconAssetKey                             000186672F10 ModelPrimitiveType string string string String
    public partial class TwestaCommentCellData
    {
        public ITwestaArticleCommentStatus?             TwestaComment                           { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   CommentText                             { get; set; }
        public string                                   IconAssetKey                            { get; set; }

        public static TwestaCommentCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaCommentCellData();

            value.TwestaComment                             = GetObject<ITwestaArticleCommentStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITwestaArticleCommentStatus.FromPointer); // 0270D68C4368 0x10 TwestaComment               ( 000186683810 ModelClassType ITwestaArticleCommentStatus ITwestaArticleCommentStatus ITwestaArticleCommentStatus Pointer )
            value.UserName                                  = GetString(new IntPtr(p + 0x018)); // 0270D68C4388 0x18 UserName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.CommentText                               = GetString(new IntPtr(p + 0x020)); // 0270D68C43A8 0x20 CommentText                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x028)); // 0270D68C43C8 0x28 IconAssetKey                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
