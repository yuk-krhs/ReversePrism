using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExceptionType                            ModelClassType Type Type Type Pointer
    // 018 LabelIndex                               ModelPrimitiveType int int int Int32
    // 01C HandlerStartIndex                        ModelPrimitiveType int int int Int32
    // 020 HandlerEndIndex                          ModelPrimitiveType int int int Int32
    // 028 Filter                                   ModelClassType ExceptionFilter ExceptionFilter ExceptionFilter Pointer
    public partial class ExceptionHandler : DataModel
    {
        public Type?                                    ExceptionType                           { get; set; }
        public int                                      LabelIndex                              { get; set; }
        public int                                      HandlerStartIndex                       { get; set; }
        public int                                      HandlerEndIndex                         { get; set; }
        public ExceptionFilter?                         Filter                                  { get; set; }

        public static ExceptionHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionHandler() { Pointer= p0 };

            value.ExceptionType                             = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ExceptionType               ( ModelClassType Type Type Type Pointer )
            value.LabelIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 LabelIndex                  ( ModelPrimitiveType int int int Int32 )
            value.HandlerStartIndex                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HandlerStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.HandlerEndIndex                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 HandlerEndIndex             ( ModelPrimitiveType int int int Int32 )
            value.Filter                                    = GetObject<ExceptionFilter>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionFilter.FromPointer); // 0x28 Filter                      ( ModelClassType ExceptionFilter ExceptionFilter ExceptionFilter Pointer )

            return value;
        }
    }
}
