using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 FavoriteDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<TwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstTwestaArticleIdFieldNumber            int IL2CPP_TYPE_I4
    // 038 MstTwestaArticleId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstTwestaUserIdFieldNumber               int IL2CPP_TYPE_I4
    // 03C MstTwestaUserId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 040 _PostDate                                000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 048 IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 049 IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CommentListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_commentList_codec              FieldCodec`1<TwestaArticleCommentStatus> IL2CPP_TYPE_GENERICINST
    // 050 CommentList                              000185CF5BF8 ModelClassListType RepeatedField`1<TwestaArticleCommentStatus> RepeatedField`1<TwestaArticleCommentStatus> List<TwestaArticleCommentStatus> Pointer
    // 000 FavoriteDateFieldNumber                  int IL2CPP_TYPE_I4
    // 058 _FavoriteDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class TwestaArticleStatus
    {
        public DateTime                                 PostDate                                { get; set; }
        public DateTime                                 FavoriteDate                            { get; set; }
        public int                                      MstTwestaArticleId                      { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public List<TwestaArticleCommentStatus>?        CommentList                             { get; set; }
        public Timestamp?                               _FavoriteDate                           { get; set; }

        public static TwestaArticleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleStatus();

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0270D2314C30 0x10 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x020)); // 0270D2314C50 0x20 FavoriteDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstTwestaArticleId                        = GetInt32(new IntPtr(p + 0x038)); // 0270D2314CD0 0x38 MstTwestaArticleId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x03C)); // 0270D2314D10 0x3C MstTwestaUserId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2314D50 0x40 _PostDate                   ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x048)); // 0270D2314D90 0x48 IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x049)); // 0270D2314DD0 0x49 IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CommentList                               = GetObjectList<TwestaArticleCommentStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.TwestaArticleCommentStatus.FromPointer); // 0270D2314E30 0x50 CommentList                 ( 000185CF5BF8 ModelClassListType RepeatedField`1<TwestaArticleCommentStatus> RepeatedField`1<TwestaArticleCommentStatus> List<TwestaArticleCommentStatus> Pointer )
            value._FavoriteDate                             = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2314E70 0x58 _FavoriteDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);
            value.FavoriteDate                  = ToDateTime(value._FavoriteDate);

            return value;
        }
    }
}
