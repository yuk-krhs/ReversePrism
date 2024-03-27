using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BucketOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LinearBucketsFieldNumber                 int IL2CPP_TYPE_I4
    // 000 ExponentialBucketsFieldNumber            int IL2CPP_TYPE_I4
    // 000 ExplicitBucketsFieldNumber               int IL2CPP_TYPE_I4
    // 018 options_                                 <object> IL2CPP_TYPE_OBJECT
    // 020 OptionsCase                              0001865ABED0 ModelEnumType OptionsOneofCase OptionsOneofCase OptionsOneofCase Int32
    public partial class BucketOptions
    {
        public OptionsOneofCase                         OptionsCase                             { get; set; }

        public static BucketOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BucketOptions();

            value.OptionsCase                               = (OptionsOneofCase)GetInt32(new IntPtr(p + 0x020)); // 0270DA794488 0x20 OptionsCase                 ( 0001865ABED0 ModelEnumType OptionsOneofCase OptionsOneofCase OptionsOneofCase Int32 )

            return value;
        }
    }
}
