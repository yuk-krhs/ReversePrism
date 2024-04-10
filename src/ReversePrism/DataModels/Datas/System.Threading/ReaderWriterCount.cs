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
    public partial class ReaderWriterCount : DataModel
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
            var value   = new ReaderWriterCount() { Pointer= p0 };

            value.LockID                                    = GetInt64(new IntPtr(p + 0x010)); // 02466A0F2F08 0x10 LockID                      ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Readercount                               = GetInt32(new IntPtr(p + 0x018)); // 02466A0F2F28 0x18 Readercount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Writercount                               = GetInt32(new IntPtr(p + 0x01C)); // 02466A0F2F48 0x1C Writercount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Upgradecount                              = GetInt32(new IntPtr(p + 0x020)); // 02466A0F2F68 0x20 Upgradecount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<ReaderWriterCount>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReaderWriterCount.FromPointer); // 02466A0F2F88 0x28 Next                        ( 00018661F3E0 ModelClassType ReaderWriterCount ReaderWriterCount ReaderWriterCount Pointer )

            return value;
        }
    }
}
