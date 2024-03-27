using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LockID                                   0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 Readercount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Writercount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Upgradecount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Next                                     00018661F3E0 ModelClassType ReaderWriterCount ReaderWriterCount ReaderWriterCount Pointer
    public partial class ReaderWriterCount
    {
        public long                                     LockID                                  { get; set; }
        public int                                      Readercount                             { get; set; }
        public int                                      Writercount                             { get; set; }
        public int                                      Upgradecount                            { get; set; }
        public ReaderWriterCount?                       Next                                    { get; set; }

        public static ReaderWriterCount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderWriterCount();

            value.LockID                                    = GetInt64(new IntPtr(p + 0x010)); // 0270DA09F160 0x10 LockID                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Readercount                               = GetInt32(new IntPtr(p + 0x018)); // 0270DA09F180 0x18 Readercount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Writercount                               = GetInt32(new IntPtr(p + 0x01C)); // 0270DA09F1A0 0x1C Writercount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Upgradecount                              = GetInt32(new IntPtr(p + 0x020)); // 0270DA09F1C0 0x20 Upgradecount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<ReaderWriterCount>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReaderWriterCount.FromPointer); // 0270DA09F1E0 0x28 Next                        ( 00018661F3E0 ModelClassType ReaderWriterCount ReaderWriterCount ReaderWriterCount Pointer )

            return value;
        }
    }
}
