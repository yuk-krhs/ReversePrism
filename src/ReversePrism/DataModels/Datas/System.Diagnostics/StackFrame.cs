using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OFFSET_UNKNOWN                           int IL2CPP_TYPE_I4
    // 010 IlOffset                                 ModelPrimitiveType int int int Int32
    // 014 NativeOffset                             ModelPrimitiveType int int int Int32
    // 018 MethodAddress                            ModelPrimitiveType long long long Int64
    // 020 MethodIndex                              ModelPrimitiveType uint uint uint UInt32
    // 028 MethodBase                               ModelClassType MethodBase MethodBase MethodBase Pointer
    // 030 FileName                                 ModelPrimitiveType string string string String
    // 038 LineNumber                               ModelPrimitiveType int int int Int32
    // 03C ColumnNumber                             ModelPrimitiveType int int int Int32
    // 040 InternalMethodName                       ModelPrimitiveType string string string String
    public partial class StackFrame : DataModel
    {
        public int                                      IlOffset                                { get; set; }
        public int                                      NativeOffset                            { get; set; }
        public long                                     MethodAddress                           { get; set; }
        public uint                                     MethodIndex                             { get; set; }
        public MethodBase?                              MethodBase                              { get; set; }
        public string                                   FileName                                { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      ColumnNumber                            { get; set; }
        public string                                   InternalMethodName                      { get; set; }

        public static StackFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackFrame() { Pointer= p0 };

            value.IlOffset                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 IlOffset                    ( ModelPrimitiveType int int int Int32 )
            value.NativeOffset                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 NativeOffset                ( ModelPrimitiveType int int int Int32 )
            value.MethodAddress                             = GetInt64(new IntPtr(p + 0x018)); // 0x18 MethodAddress               ( ModelPrimitiveType long long long Int64 )
            value.MethodIndex                               = GetUInt32(new IntPtr(p + 0x020)); // 0x20 MethodIndex                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.MethodBase                                = GetObject<MethodBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodBase.FromPointer); // 0x28 MethodBase                  ( ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.FileName                                  = GetString(new IntPtr(p + 0x030)); // 0x30 FileName                    ( ModelPrimitiveType string string string String )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.ColumnNumber                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ColumnNumber                ( ModelPrimitiveType int int int Int32 )
            value.InternalMethodName                        = GetString(new IntPtr(p + 0x040)); // 0x40 InternalMethodName          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
