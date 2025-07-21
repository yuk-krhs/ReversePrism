using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<TwestaArticleCommentStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstTwestaArticleCommentIdFieldNumber     int IL2CPP_TYPE_I4
    // 028 MstTwestaArticleCommentId                ModelPrimitiveType int int int Int32
    // 000 MstTwestaUserIdFieldNumber               int IL2CPP_TYPE_I4
    // 02C MstTwestaUserId                          ModelPrimitiveType int int int Int32
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 030 _PostDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class TwestaArticleCommentStatus : DataModel
    {
        public DateTime                                 PostDate                                { get; set; }
        public int                                      MstTwestaArticleCommentId               { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }

        public static TwestaArticleCommentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaArticleCommentStatus() { Pointer= p0 };

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstTwestaArticleCommentId                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstTwestaArticleCommentId   ( ModelPrimitiveType int int int Int32 )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstTwestaUserId             ( ModelPrimitiveType int int int Int32 )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _PostDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
