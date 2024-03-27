using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SourceCodeInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LocationFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_location_codec                 FieldCodec`1<Location> IL2CPP_TYPE_GENERICINST
    // 018 Location                                 000185CF9D98 ModelClassListType RepeatedField`1<Location> RepeatedField`1<Location> List<Location> Pointer
    public partial class SourceCodeInfo
    {
        public List<Location>?                          Location                                { get; set; }

        public static SourceCodeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SourceCodeInfo();

            value.Location                                  = GetObjectList<Location>(new IntPtr(p + 0x018), ReversePrism.DataModels.Location.FromPointer); // 0270D0CA78F0 0x18 Location                    ( 000185CF9D98 ModelClassListType RepeatedField`1<Location> RepeatedField`1<Location> List<Location> Pointer )

            return value;
        }
    }
}
