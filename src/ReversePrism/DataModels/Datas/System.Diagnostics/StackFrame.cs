using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OFFSET_UNKNOWN                           int IL2CPP_TYPE_I4
    // 010 IlOffset                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 NativeOffset                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MethodAddress                            0001865F7700 ModelPrimitiveType long long long Int64
    // 020 MethodIndex                              000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 MethodBase                               000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer
    // 030 FileName                                 000186671910 ModelPrimitiveType string string string String
    // 038 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C ColumnNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 InternalMethodName                       000186671910 ModelPrimitiveType string string string String
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

            value.IlOffset                                  = GetInt32(new IntPtr(p + 0x010)); // 0245A32DF710 0x10 IlOffset                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NativeOffset                              = GetInt32(new IntPtr(p + 0x014)); // 0245A32DF730 0x14 NativeOffset                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MethodAddress                             = GetInt64(new IntPtr(p + 0x018)); // 0245A32DF750 0x18 MethodAddress               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.MethodIndex                               = GetUInt32(new IntPtr(p + 0x020)); // 0245A32DF770 0x20 MethodIndex                 ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.MethodBase                                = GetObject<MethodBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodBase.FromPointer); // 0245A32DF790 0x28 MethodBase                  ( 000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.FileName                                  = GetString(new IntPtr(p + 0x030)); // 0245A32DF7B0 0x30 FileName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x038)); // 0245A32DF7D0 0x38 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ColumnNumber                              = GetInt32(new IntPtr(p + 0x03C)); // 0245A32DF7F0 0x3C ColumnNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InternalMethodName                        = GetString(new IntPtr(p + 0x040)); // 0245A32DF810 0x40 InternalMethodName          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
