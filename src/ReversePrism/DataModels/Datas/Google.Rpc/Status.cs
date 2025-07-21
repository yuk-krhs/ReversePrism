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
    // 018 Code                                     ModelPrimitiveType int int int Int32
    // 000 MessageFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Message                                  ModelPrimitiveType string string string String
    // 000 DetailsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_details_codec                  FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 028 Details                                  ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
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

            value.Code                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Code                        ( ModelPrimitiveType int int int Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )
            value.Details                                   = GetObjectList<Any>(new IntPtr(p + 0x028), ReversePrism.DataModels.Any.FromPointer); // 0x28 Details                     ( ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
