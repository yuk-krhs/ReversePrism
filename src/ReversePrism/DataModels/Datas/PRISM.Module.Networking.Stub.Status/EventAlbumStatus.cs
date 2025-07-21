using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventAlbumStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventAlbumIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 MstEventAlbumId                          ModelPrimitiveType int int int Int32
    // 000 IsOpenFieldNumber                        int IL2CPP_TYPE_I4
    // 01C IsOpen                                   ModelPrimitiveType bool bool bool Bool
    public partial class EventAlbumStatus : DataModel
    {
        public int                                      MstEventAlbumId                         { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static EventAlbumStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventAlbumStatus() { Pointer= p0 };

            value.MstEventAlbumId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEventAlbumId             ( ModelPrimitiveType int int int Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsOpen                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
