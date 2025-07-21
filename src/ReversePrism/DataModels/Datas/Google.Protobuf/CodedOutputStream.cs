using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LittleEndian64Size                       int IL2CPP_TYPE_I4
    // 000 LittleEndian32Size                       int IL2CPP_TYPE_I4
    // 000 DoubleSize                               int IL2CPP_TYPE_I4
    // 000 FloatSize                                int IL2CPP_TYPE_I4
    // 000 BoolSize                                 int IL2CPP_TYPE_I4
    // 000 DefaultBufferSize                        int IL2CPP_TYPE_I4
    // 010 LeaveOpen                                ModelPrimitiveType bool bool bool Bool
    // 018 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 State                                    ModelEnumType WriterInternalState WriterInternalState WriterInternalState Int32
    // 038 Output                                   ModelClassType Stream Stream Stream Pointer
    // 040 Deterministic                            ModelPrimitiveType bool bool bool Bool
    public partial class CodedOutputStream : DataModel
    {
        public bool                                     LeaveOpen                               { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public WriterInternalState                      State                                   { get; set; }
        public Stream?                                  Output                                  { get; set; }
        public bool                                     Deterministic                           { get; set; }

        public static CodedOutputStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodedOutputStream() { Pointer= p0 };

            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 LeaveOpen                   ( ModelPrimitiveType bool bool bool Bool )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.State                                     = (WriterInternalState)GetInt32(new IntPtr(p + 0x020)); // 0x20 State                       ( ModelEnumType WriterInternalState WriterInternalState WriterInternalState Int32 )
            value.Output                                    = GetObject<Stream>(new IntPtr(p + 0x038), ReversePrism.DataModels.Stream.FromPointer); // 0x38 Output                      ( ModelClassType Stream Stream Stream Pointer )
            value.Deterministic                             = GetBool(new IntPtr(p + 0x040)); // 0x40 Deterministic               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
