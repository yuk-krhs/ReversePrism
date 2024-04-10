using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetUserForDmmGamesArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ViewerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 018 ViewerId                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ViewerIdSignatureFieldNumber             int IL2CPP_TYPE_I4
    // 020 ViewerIdSignature                        000186671910 ModelPrimitiveType string string string String
    public partial class GetUserForDmmGamesArgs : DataModel
    {
        public long                                     ViewerId                                { get; set; }
        public string                                   ViewerIdSignature                       { get; set; }

        public static GetUserForDmmGamesArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetUserForDmmGamesArgs() { Pointer= p0 };

            value.ViewerId                                  = GetInt64(new IntPtr(p + 0x018)); // 024660B5B8C8 0x18 ViewerId                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x020)); // 024660B5B908 0x20 ViewerIdSignature           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
