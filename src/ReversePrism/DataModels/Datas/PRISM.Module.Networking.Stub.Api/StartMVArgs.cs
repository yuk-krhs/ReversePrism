using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartMVArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 01C UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StartMVArgs
    {
        public int                                      MstSongId                               { get; set; }
        public int                                      UnitNumber                              { get; set; }

        public static StartMVArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartMVArgs();

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D21FD160 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D21FD1A0 0x1C UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
