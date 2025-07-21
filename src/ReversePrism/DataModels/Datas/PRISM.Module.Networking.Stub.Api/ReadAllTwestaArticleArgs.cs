using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ReadAllTwestaArticleArgs> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 028 _PostDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class ReadAllTwestaArticleArgs : DataModel
    {
        public DateTime                                 PostDate                                { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }

        public static ReadAllTwestaArticleArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadAllTwestaArticleArgs() { Pointer= p0 };

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 0x28 _PostDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
