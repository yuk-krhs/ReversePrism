using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Container> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChunkFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_chunk_codec                    FieldCodec`1<ByteString> IL2CPP_TYPE_GENERICINST
    // 018 Chunk                                    000185CD0198 ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer
    // 000 StreamingIdFieldNumber                   int IL2CPP_TYPE_I4
    // 020 StreamingId                              000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 SequenceNumberFieldNumber                int IL2CPP_TYPE_I4
    // 030 SequenceNumber                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StartAtFieldNumber                       int IL2CPP_TYPE_I4
    // 038 _StartAt                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndAtFieldNumber                         int IL2CPP_TYPE_I4
    // 040 _EndAt                                   000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ServerReceivedAtFieldNumber              int IL2CPP_TYPE_I4
    // 048 _ServerReceivedAt                        000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class Container : DataModel
    {
        public List<ByteString>?                        Chunk                                   { get; set; }
        public string                                   StreamingId                             { get; set; }
        public string                                   Title                                   { get; set; }
        public int                                      SequenceNumber                          { get; set; }
        public Timestamp?                               _StartAt                                { get; set; }
        public Timestamp?                               _EndAt                                  { get; set; }
        public Timestamp?                               _ServerReceivedAt                       { get; set; }

        public static Container? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Container() { Pointer= p0 };

            value.Chunk                                     = GetObjectList<ByteString>(new IntPtr(p + 0x018), ReversePrism.DataModels.ByteString.FromPointer); // 024664BDA198 0x18 Chunk                       ( 000185CD0198 ModelClassListType RepeatedField`1<ByteString> RepeatedField`1<ByteString> List<ByteString> Pointer )
            value.StreamingId                               = GetString(new IntPtr(p + 0x020)); // 024664BDA1D8 0x20 StreamingId                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x028)); // 024664BDA218 0x28 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.SequenceNumber                            = GetInt32(new IntPtr(p + 0x030)); // 024664BDA258 0x30 SequenceNumber              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._StartAt                                  = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 024664BDA298 0x38 _StartAt                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndAt                                    = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024664BDA2D8 0x40 _EndAt                      ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._ServerReceivedAt                         = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024664BDA318 0x48 _ServerReceivedAt           ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )

            return value;
        }
    }
}
