using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 018 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 OwnsStream                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 bufferLength                             int IL2CPP_TYPE_I4
    // 000 maxEntityLength                          int IL2CPP_TYPE_I4
    // 000 maxBytesPerChar                          int IL2CPP_TYPE_I4
    // 028 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 030 HasPendingWrite                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 flushBufferState                         AsyncEventArgs`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 UTF8Encoding                             UTF8Encoding IL2CPP_TYPE_CLASS
    // 008 onFlushBufferComplete                    AsyncCallback IL2CPP_TYPE_CLASS
    // 010 OnGetFlushComplete                       0001866F40D0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer
    public partial class XmlStreamNodeWriter : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public bool                                     OwnsStream                              { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public int                                      HasPendingWrite                         { get; set; }
        public AsyncEventArgsCallback?                  OnGetFlushComplete                      { get; set; }

        public static XmlStreamNodeWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlStreamNodeWriter() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0245A4DC0000 0x10 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 0245A4DC0020 0x18 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x020)); // 0245A4DC0040 0x20 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OwnsStream                                = GetBool(new IntPtr(p + 0x024)); // 0245A4DC0060 0x24 OwnsStream                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0245A4DC00E0 0x28 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.HasPendingWrite                           = GetInt32(new IntPtr(p + 0x030)); // 0245A4DC0100 0x30 HasPendingWrite             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnGetFlushComplete                        = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 0245A4DC0180 0x10 OnGetFlushComplete          ( 0001866F40D0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )

            return value;
        }
    }
}
