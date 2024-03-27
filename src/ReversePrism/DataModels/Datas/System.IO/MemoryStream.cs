using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Origin                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Position                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C Capacity                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 Expandable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 Writable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 Exposable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 043 IsOpen                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 _lastReadTask                            Task`1<int> IL2CPP_TYPE_GENERICINST
    public partial class MemoryStream
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Origin                                  { get; set; }
        public int                                      Position                                { get; set; }
        public int                                      Length                                  { get; set; }
        public int                                      Capacity                                { get; set; }
        public bool                                     Expandable                              { get; set; }
        public bool                                     Writable                                { get; set; }
        public bool                                     Exposable                               { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static MemoryStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryStream();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0270D197D598 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Origin                                    = GetInt32(new IntPtr(p + 0x030)); // 0270D197D5B8 0x30 Origin                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x034)); // 0270D197D5D8 0x34 Position                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x038)); // 0270D197D5F8 0x38 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Capacity                                  = GetInt32(new IntPtr(p + 0x03C)); // 0270D197D618 0x3C Capacity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Expandable                                = GetBool(new IntPtr(p + 0x040)); // 0270D197D638 0x40 Expandable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Writable                                  = GetBool(new IntPtr(p + 0x041)); // 0270D197D658 0x41 Writable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Exposable                                 = GetBool(new IntPtr(p + 0x042)); // 0270D197D678 0x42 Exposable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x043)); // 0270D197D698 0x43 IsOpen                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
