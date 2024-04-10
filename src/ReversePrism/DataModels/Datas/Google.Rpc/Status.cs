using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Status> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CodeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Code                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MessageFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    // 000 DetailsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_details_codec                  FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 028 Details                                  000185CCE428 ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
    public partial class Status : DataModel
    {
        public int                                      Code                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public List<Any>?                               Details                                 { get; set; }

        public static Status? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Status() { Pointer= p0 };

            value.Code                                      = GetInt32(new IntPtr(p + 0x018)); // 02466A75A988 0x18 Code                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 02466A75A9C8 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Details                                   = GetObjectList<Any>(new IntPtr(p + 0x028), ReversePrism.DataModels.Any.FromPointer); // 02466A75AA28 0x28 Details                     ( 000185CCE428 ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
