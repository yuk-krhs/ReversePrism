using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LockID                                   ModelPrimitiveType long long long Int64
    // 018 Readercount                              ModelPrimitiveType int int int Int32
    // 01C Writercount                              ModelPrimitiveType int int int Int32
    // 020 Upgradecount                             ModelPrimitiveType int int int Int32
    // 028 Next                                     ModelClassType ReaderWriterCount ReaderWriterCount ReaderWriterCount Pointer
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

            value.LockID                                    = GetInt64(new IntPtr(p + 0x010)); // 0x10 LockID                      ( ModelPrimitiveType long long long Int64 )
            value.Readercount                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 Readercount                 ( ModelPrimitiveType int int int Int32 )
            value.Writercount                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Writercount                 ( ModelPrimitiveType int int int Int32 )
            value.Upgradecount                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 Upgradecount                ( ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<ReaderWriterCount>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReaderWriterCount.FromPointer); // 0x28 Next                        ( ModelClassType ReaderWriterCount ReaderWriterCount ReaderWriterCount Pointer )

            return value;
        }
    }
}
