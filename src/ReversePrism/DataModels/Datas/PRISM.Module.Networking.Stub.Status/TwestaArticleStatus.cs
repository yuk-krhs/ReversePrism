using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 FavoriteDate                             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<TwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstTwestaArticleIdFieldNumber            int IL2CPP_TYPE_I4
    // 038 MstTwestaArticleId                       ModelPrimitiveType int int int Int32
    // 000 MstTwestaUserIdFieldNumber               int IL2CPP_TYPE_I4
    // 03C MstTwestaUserId                          ModelPrimitiveType int int int Int32
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 040 _PostDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 048 IsFavorite                               ModelPrimitiveType bool bool bool Bool
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 049 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 000 CommentListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_commentList_codec              FieldCodec`1<TwestaArticleCommentStatus> IL2CPP_TYPE_GENERICINST
    // 050 CommentList                              ModelClassListType RepeatedField`1<TwestaArticleCommentStatus> RepeatedField`1<TwestaArticleCommentStatus> List<TwestaArticleCommentStatus> Pointer
    // 000 FavoriteDateFieldNumber                  int IL2CPP_TYPE_I4
    // 058 _FavoriteDate                            ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class TwestaArticleStatus : DataModel
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
            var value   = new TwestaArticleStatus() { Pointer= p0 };

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x020)); // 0x20 FavoriteDate                ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstTwestaArticleId                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstTwestaArticleId          ( ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x03C)); // 0x3C MstTwestaUserId             ( ModelPrimitiveType int int int Int32 )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _PostDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x048)); // 0x48 IsFavorite                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x049)); // 0x49 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.CommentList                               = GetObjectList<TwestaArticleCommentStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.TwestaArticleCommentStatus.FromPointer); // 0x50 CommentList                 ( ModelClassListType RepeatedField`1<TwestaArticleCommentStatus> RepeatedField`1<TwestaArticleCommentStatus> List<TwestaArticleCommentStatus> Pointer )
            value._FavoriteDate                             = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _FavoriteDate               ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);
            value.FavoriteDate                  = ToDateTime(value._FavoriteDate);

            return value;
        }
    }
}
