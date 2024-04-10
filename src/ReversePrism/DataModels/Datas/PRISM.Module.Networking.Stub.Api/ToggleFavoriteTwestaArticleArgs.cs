using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ToggleFavoriteTwestaArticleArgs> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstTwestaArticleIdFieldNumber            int IL2CPP_TYPE_I4
    // 028 MstTwestaArticleId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FavoriteDateFieldNumber                  int IL2CPP_TYPE_I4
    // 030 _FavoriteDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class ToggleFavoriteTwestaArticleArgs : DataModel
    {
        public DateTime                                 FavoriteDate                            { get; set; }
        public int                                      MstTwestaArticleId                      { get; set; }
        public Timestamp?                               _FavoriteDate                           { get; set; }

        public static ToggleFavoriteTwestaArticleArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleFavoriteTwestaArticleArgs() { Pointer= p0 };

            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0246622792B0 0x10 FavoriteDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstTwestaArticleId                        = GetInt32(new IntPtr(p + 0x028)); // 024662279330 0x28 MstTwestaArticleId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._FavoriteDate                             = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 024662279370 0x30 _FavoriteDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.FavoriteDate                  = ToDateTime(value._FavoriteDate);

            return value;
        }
    }
}
