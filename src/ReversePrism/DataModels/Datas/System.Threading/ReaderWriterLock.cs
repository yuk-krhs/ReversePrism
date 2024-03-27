using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Seq_num                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 State                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Readers                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Writer_lock_owner                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Writer_queue                             0001865A9B80 ModelClassType LockQueue LockQueue LockQueue Pointer
    // 028 Reader_locks                             0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ReaderWriterLock
    {
        public int                                      Seq_num                                 { get; set; }
        public int                                      State                                   { get; set; }
        public int                                      Readers                                 { get; set; }
        public int                                      Writer_lock_owner                       { get; set; }
        public LockQueue?                               Writer_queue                            { get; set; }
        public Hashtable?                               Reader_locks                            { get; set; }

        public static ReaderWriterLock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderWriterLock();

            value.Seq_num                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D6AEE590 0x10 Seq_num                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D6AEE5B0 0x14 State                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Readers                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D6AEE5D0 0x18 Readers                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Writer_lock_owner                         = GetInt32(new IntPtr(p + 0x01C)); // 0270D6AEE5F0 0x1C Writer_lock_owner           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Writer_queue                              = GetObject<LockQueue>(new IntPtr(p + 0x020), ReversePrism.DataModels.LockQueue.FromPointer); // 0270D6AEE610 0x20 Writer_queue                ( 0001865A9B80 ModelClassType LockQueue LockQueue LockQueue Pointer )
            value.Reader_locks                              = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6AEE630 0x28 Reader_locks                ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
