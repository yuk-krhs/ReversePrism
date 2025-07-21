using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 030 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 BufferSize                               ModelPrimitiveType int int int Int32
    // 03C ReadPos                                  ModelPrimitiveType int int int Int32
    // 040 ReadLen                                  ModelPrimitiveType int int int Int32
    // 044 WritePos                                 ModelPrimitiveType int int int Int32
    // 048 _lastSyncCompletedReadTask               Task`1<int> IL2CPP_TYPE_GENERICINST
    // 050 AsyncActiveSemaphore                     ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    public partial class BufferedStream : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      BufferSize                              { get; set; }
        public int                                      ReadPos                                 { get; set; }
        public int                                      ReadLen                                 { get; set; }
        public int                                      WritePos                                { get; set; }
        public SemaphoreSlim?                           AsyncActiveSemaphore                    { get; set; }

        public static BufferedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedStream() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 BufferSize                  ( ModelPrimitiveType int int int Int32 )
            value.ReadPos                                   = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ReadPos                     ( ModelPrimitiveType int int int Int32 )
            value.ReadLen                                   = GetInt32(new IntPtr(p + 0x040)); // 0x40 ReadLen                     ( ModelPrimitiveType int int int Int32 )
            value.WritePos                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 WritePos                    ( ModelPrimitiveType int int int Int32 )
            value.AsyncActiveSemaphore                      = GetObject<SemaphoreSlim>(new IntPtr(p + 0x050), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0x50 AsyncActiveSemaphore        ( ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )

            return value;
        }
    }
}
