using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Seq_num                                  ModelPrimitiveType int int int Int32
    // 014 State                                    ModelPrimitiveType int int int Int32
    // 018 Readers                                  ModelPrimitiveType int int int Int32
    // 01C Writer_lock_owner                        ModelPrimitiveType int int int Int32
    // 020 Writer_queue                             ModelClassType LockQueue LockQueue LockQueue Pointer
    // 028 Reader_locks                             ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ReaderWriterLock : DataModel
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
            var value   = new ReaderWriterLock() { Pointer= p0 };

            value.Seq_num                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Seq_num                     ( ModelPrimitiveType int int int Int32 )
            value.State                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 State                       ( ModelPrimitiveType int int int Int32 )
            value.Readers                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Readers                     ( ModelPrimitiveType int int int Int32 )
            value.Writer_lock_owner                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Writer_lock_owner           ( ModelPrimitiveType int int int Int32 )
            value.Writer_queue                              = GetObject<LockQueue>(new IntPtr(p + 0x020), ReversePrism.DataModels.LockQueue.FromPointer); // 0x20 Writer_queue                ( ModelClassType LockQueue LockQueue LockQueue Pointer )
            value.Reader_locks                              = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0x28 Reader_locks                ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
