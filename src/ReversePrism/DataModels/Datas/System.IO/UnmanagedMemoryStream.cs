using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   0001866B7DD0 ModelClassType SafeBuffer SafeBuffer SafeBuffer Pointer
    // 030 _mem                                     IntPtr IL2CPP_TYPE_PTR
    // 038 Length                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 040 Capacity                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 048 Position                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 050 Offset                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 058 Access                                   000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32
    // 05C IsOpen                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 060 _lastReadTask                            Task`1<int> IL2CPP_TYPE_GENERICINST
    public partial class UnmanagedMemoryStream
    {
        public SafeBuffer?                              Buffer                                  { get; set; }
        public long                                     Length                                  { get; set; }
        public long                                     Capacity                                { get; set; }
        public long                                     Position                                { get; set; }
        public long                                     Offset                                  { get; set; }
        public FileAccess                               Access                                  { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static UnmanagedMemoryStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmanagedMemoryStream();

            value.Buffer                                    = GetObject<SafeBuffer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SafeBuffer.FromPointer); // 0270D0E92028 0x28 Buffer                      ( 0001866B7DD0 ModelClassType SafeBuffer SafeBuffer SafeBuffer Pointer )
            value.Length                                    = GetInt64(new IntPtr(p + 0x038)); // 0270D0E92068 0x38 Length                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Capacity                                  = GetInt64(new IntPtr(p + 0x040)); // 0270D0E92088 0x40 Capacity                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Position                                  = GetInt64(new IntPtr(p + 0x048)); // 0270D0E920A8 0x48 Position                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Offset                                    = GetInt64(new IntPtr(p + 0x050)); // 0270D0E920C8 0x50 Offset                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Access                                    = (FileAccess)GetInt32(new IntPtr(p + 0x058)); // 0270D0E920E8 0x58 Access                      ( 000186577D30 ModelEnumType FileAccess FileAccess FileAccess Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x05C)); // 0270D0E92108 0x5C IsOpen                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
