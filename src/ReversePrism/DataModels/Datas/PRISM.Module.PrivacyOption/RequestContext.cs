using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecoratorIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Decorators                               000185B85A60 ModelClassListType IAsyncDecorator[] IAsyncDecorator[] List<IAsyncDecorator> Pointer
    // 020 headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 028 BaseUrl                                  000186672F10 ModelPrimitiveType string string string String
    // 030 Url                                      000186672F10 ModelPrimitiveType string string string String
    // 038 <Value>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    // 040 Method                                   0001866132B0 ModelEnumType MethodType MethodType MethodType Int32
    // 048 Timestamp                                0001865BCF70 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32
    public partial class RequestContext : DataModel
    {
        public int                                      DecoratorIndex                          { get; set; }
        public List<IAsyncDecorator>?                   Decorators                              { get; set; }
        public string                                   BaseUrl                                 { get; set; }
        public string                                   Url                                     { get; set; }
        public MethodType                               Method                                  { get; set; }
        public DateTimeOffset                           Timestamp                               { get; set; }

        public static RequestContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestContext() { Pointer= p0 };

            value.DecoratorIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0245A4E55448 0x10 DecoratorIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Decorators                                = GetObjectList<IAsyncDecorator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAsyncDecorator.FromPointer); // 0245A4E55468 0x18 Decorators                  ( 000185B85A60 ModelClassListType IAsyncDecorator[] IAsyncDecorator[] List<IAsyncDecorator> Pointer )
            value.BaseUrl                                   = GetString(new IntPtr(p + 0x028)); // 0245A4E554A8 0x28 BaseUrl                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x030)); // 0245A4E554C8 0x30 Url                         ( 000186672F10 ModelPrimitiveType string string string String )
            value.Method                                    = (MethodType)GetInt32(new IntPtr(p + 0x040)); // 0245A4E55508 0x40 Method                      ( 0001866132B0 ModelEnumType MethodType MethodType MethodType Int32 )
            value.Timestamp                                 = (DateTimeOffset)GetInt32(new IntPtr(p + 0x048)); // 0245A4E55528 0x48 Timestamp                   ( 0001865BCF70 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32 )

            return value;
        }
    }
}
