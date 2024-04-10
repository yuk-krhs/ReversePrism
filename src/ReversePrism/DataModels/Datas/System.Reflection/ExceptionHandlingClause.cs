using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Catch_type                               000186692A80 ModelClassType Type Type Type Pointer
    // 018 Filter_offset                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Flags                                    000186771C00 ModelEnumType ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions Int32
    // 020 Try_offset                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Try_length                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Handler_offset                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 02C Handler_length                           0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.Catch_type                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024666D3E0D8 0x10 Catch_type                  ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.Filter_offset                             = GetInt32(new IntPtr(p + 0x018)); // 024666D3E0F8 0x18 Filter_offset               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (ExceptionHandlingClauseOptions)GetInt32(new IntPtr(p + 0x01C)); // 024666D3E118 0x1C Flags                       ( 000186771C00 ModelEnumType ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions ExceptionHandlingClauseOptions Int32 )
            value.Try_offset                                = GetInt32(new IntPtr(p + 0x020)); // 024666D3E138 0x20 Try_offset                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Try_length                                = GetInt32(new IntPtr(p + 0x024)); // 024666D3E158 0x24 Try_length                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Handler_offset                            = GetInt32(new IntPtr(p + 0x028)); // 024666D3E178 0x28 Handler_offset              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Handler_length                            = GetInt32(new IntPtr(p + 0x02C)); // 024666D3E198 0x2C Handler_length              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
