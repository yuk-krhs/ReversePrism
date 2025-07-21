using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Origin                                   ModelPrimitiveType int int int Int32
    // 034 Position                                 ModelPrimitiveType int int int Int32
    // 038 Length                                   ModelPrimitiveType int int int Int32
    // 03C Capacity                                 ModelPrimitiveType int int int Int32
    // 040 Expandable                               ModelPrimitiveType bool bool bool Bool
    // 041 Writable                                 ModelPrimitiveType bool bool bool Bool
    // 042 Exposable                                ModelPrimitiveType bool bool bool Bool
    // 043 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    // 048 _lastReadTask                            Task`1<int> IL2CPP_TYPE_GENERICINST
    public partial class MemoryStream : DataModel
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
            var value   = new MemoryStream() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Origin                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Origin                      ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 Position                    ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Capacity                                  = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Capacity                    ( ModelPrimitiveType int int int Int32 )
            value.Expandable                                = GetBool(new IntPtr(p + 0x040)); // 0x40 Expandable                  ( ModelPrimitiveType bool bool bool Bool )
            value.Writable                                  = GetBool(new IntPtr(p + 0x041)); // 0x41 Writable                    ( ModelPrimitiveType bool bool bool Bool )
            value.Exposable                                 = GetBool(new IntPtr(p + 0x042)); // 0x42 Exposable                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x043)); // 0x43 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
