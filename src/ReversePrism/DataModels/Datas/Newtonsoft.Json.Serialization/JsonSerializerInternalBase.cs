using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentErrorContext                      000186744850 ModelClassType ErrorContext ErrorContext ErrorContext Pointer
    // 018 _mappings                                BidirectionalDictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 020 Serializer                               00018675EEB0 ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer
    // 028 TraceWriter                              00018667AB30 ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer
    // 030 InternalSerializer                       00018675FFC0 ModelClassType JsonSerializerProxy JsonSerializerProxy JsonSerializerProxy Pointer
    public partial class JsonSerializerInternalBase
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
            var value   = new JsonSerializerInternalBase();

            value.CurrentErrorContext                       = GetObject<ErrorContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ErrorContext.FromPointer); // 027005FE53C0 0x10 CurrentErrorContext         ( 000186744850 ModelClassType ErrorContext ErrorContext ErrorContext Pointer )
            value.Serializer                                = GetObject<JsonSerializer>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonSerializer.FromPointer); // 027005FE5400 0x20 Serializer                  ( 00018675EEB0 ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer )
            value.TraceWriter                               = GetObject<ITraceWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITraceWriter.FromPointer); // 027005FE5420 0x28 TraceWriter                 ( 00018667AB30 ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer )
            value.InternalSerializer                        = GetObject<JsonSerializerProxy>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonSerializerProxy.FromPointer); // 027005FE5440 0x30 InternalSerializer          ( 00018675FFC0 ModelClassType JsonSerializerProxy JsonSerializerProxy JsonSerializerProxy Pointer )

            return value;
        }
    }
}
