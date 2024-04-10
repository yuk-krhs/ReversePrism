using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PhoneCallTextStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPhoneCallTextIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstPhoneCallTextId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPhoneUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 01C MstPhoneUserId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TextOrderFieldNumber                     int IL2CPP_TYPE_I4
    // 020 TextOrder                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PhoneCallTextStatus : DataModel
    {
        public int                                      MstPhoneCallTextId                      { get; set; }
        public int                                      MstPhoneUserId                          { get; set; }
        public int                                      TextOrder                               { get; set; }

        public static PhoneCallTextStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneCallTextStatus() { Pointer= p0 };

            value.MstPhoneCallTextId                        = GetInt32(new IntPtr(p + 0x018)); // 02466228C248 0x18 MstPhoneCallTextId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPhoneUserId                            = GetInt32(new IntPtr(p + 0x01C)); // 02466228C288 0x1C MstPhoneUserId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TextOrder                                 = GetInt32(new IntPtr(p + 0x020)); // 02466228C2C8 0x20 TextOrder                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
