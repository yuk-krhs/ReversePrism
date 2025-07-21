using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ThreadStaticBufferSize                   int IL2CPP_TYPE_I4
    // 000 DefaultBufferSize                        int IL2CPP_TYPE_I4
    // 000 UTF8NoBom                                Encoding IL2CPP_TYPE_CLASS
    // 008 newLine1                                 sbyte IL2CPP_TYPE_U1
    // 009 newLine2                                 sbyte IL2CPP_TYPE_U1
    // 00A crlf                                     bool IL2CPP_TYPE_BOOLEAN
    // FFFFFFFF scratchBuffer                            sbyte[] IL2CPP_TYPE_SZARRAY
    // FFFFFFFF scratchBufferUsed                        bool IL2CPP_TYPE_BOOLEAN
    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C DisposeImmediately                       ModelPrimitiveType bool bool bool Bool
    public partial class Utf8ValueStringBuilder : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public bool                                     DisposeImmediately                      { get; set; }

        public static Utf8ValueStringBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf8ValueStringBuilder() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.DisposeImmediately                        = GetBool(new IntPtr(p + 0x01C)); // 0x1C DisposeImmediately          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
