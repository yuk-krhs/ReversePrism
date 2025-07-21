using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentErrorContext                      ModelClassType ErrorContext ErrorContext ErrorContext Pointer
    // 018 _mappings                                BidirectionalDictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 020 Serializer                               ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer
    // 028 TraceWriter                              ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer
    // 030 InternalSerializer                       ModelClassType JsonSerializerProxy JsonSerializerProxy JsonSerializerProxy Pointer
    public partial class JsonSerializerInternalBase : DataModel
    {
        public ErrorContext?                            CurrentErrorContext                     { get; set; }
        public JsonSerializer?                          Serializer                              { get; set; }
        public ITraceWriter?                            TraceWriter                             { get; set; }
        public JsonSerializerProxy?                     InternalSerializer                      { get; set; }

        public static JsonSerializerInternalBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSerializerInternalBase() { Pointer= p0 };

            value.CurrentErrorContext                       = GetObject<ErrorContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ErrorContext.FromPointer); // 0x10 CurrentErrorContext         ( ModelClassType ErrorContext ErrorContext ErrorContext Pointer )
            value.Serializer                                = GetObject<JsonSerializer>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonSerializer.FromPointer); // 0x20 Serializer                  ( ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer )
            value.TraceWriter                               = GetObject<ITraceWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITraceWriter.FromPointer); // 0x28 TraceWriter                 ( ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer )
            value.InternalSerializer                        = GetObject<JsonSerializerProxy>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonSerializerProxy.FromPointer); // 0x30 InternalSerializer          ( ModelClassType JsonSerializerProxy JsonSerializerProxy JsonSerializerProxy Pointer )

            return value;
        }
    }
}
