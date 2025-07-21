using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LeaveOpen                                ModelPrimitiveType bool bool bool Bool
    // 018 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Input                                    ModelClassType Stream Stream Stream Pointer
    // 028 State                                    ModelEnumType ParserInternalState ParserInternalState ParserInternalState Int32
    // 000 DefaultRecursionLimit                    int IL2CPP_TYPE_I4
    // 000 DefaultSizeLimit                         int IL2CPP_TYPE_I4
    // 000 BufferSize                               int IL2CPP_TYPE_I4
    public partial class CodedInputStream : DataModel
    {
        public bool                                     LeaveOpen                               { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public Stream?                                  Input                                   { get; set; }
        public ParserInternalState                      State                                   { get; set; }

        public static CodedInputStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodedInputStream() { Pointer= p0 };

            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 LeaveOpen                   ( ModelPrimitiveType bool bool bool Bool )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Input                                     = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 0x20 Input                       ( ModelClassType Stream Stream Stream Pointer )
            value.State                                     = (ParserInternalState)GetInt32(new IntPtr(p + 0x028)); // 0x28 State                       ( ModelEnumType ParserInternalState ParserInternalState ParserInternalState Int32 )

            return value;
        }
    }
}
