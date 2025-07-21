using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Catch_type                               ModelClassType Type Type Type Pointer
    // 018 Filter_offset                            ModelPrimitiveType int int int Int32
    // 01C Flags                                    ModelEnumType ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions Int32
    // 020 Try_offset                               ModelPrimitiveType int int int Int32
    // 024 Try_length                               ModelPrimitiveType int int int Int32
    // 028 Handler_offset                           ModelPrimitiveType int int int Int32
    // 02C Handler_length                           ModelPrimitiveType int int int Int32
    public partial class ExceptionHandlingClause : DataModel
    {
        public Type?                                    Catch_type                              { get; set; }
        public int                                      Filter_offset                           { get; set; }
        public ExceptionHandlingClauseOptions           Flags                                   { get; set; }
        public int                                      Try_offset                              { get; set; }
        public int                                      Try_length                              { get; set; }
        public int                                      Handler_offset                          { get; set; }
        public int                                      Handler_length                          { get; set; }

        public static ExceptionHandlingClause? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionHandlingClause() { Pointer= p0 };

            value.Catch_type                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Catch_type                  ( ModelClassType Type Type Type Pointer )
            value.Filter_offset                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 Filter_offset               ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (ExceptionHandlingClauseOptions)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Flags                       ( ModelEnumType ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions Int32 )
            value.Try_offset                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 Try_offset                  ( ModelPrimitiveType int int int Int32 )
            value.Try_length                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 Try_length                  ( ModelPrimitiveType int int int Int32 )
            value.Handler_offset                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 Handler_offset              ( ModelPrimitiveType int int int Int32 )
            value.Handler_length                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Handler_length              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
