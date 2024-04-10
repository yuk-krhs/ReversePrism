using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onTrailBytesComplete                     AsyncCompletion IL2CPP_TYPE_CLASS
    // 008 onComplete                               AsyncCompletion IL2CPP_TYPE_CLASS
    // 070 TrailBytes                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 TrailByteCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 Writer                                   0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    public partial class WriteBase64TextAsyncResult : DataModel
    {
        public List<sbyte>?                             TrailBytes                              { get; set; }
        public int                                      TrailByteCount                          { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public XmlUTF8NodeWriter?                       Writer                                  { get; set; }

        public static WriteBase64TextAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteBase64TextAsyncResult() { Pointer= p0 };

            value.TrailBytes                                = GetSByteList(new IntPtr(p + 0x070)); // 024667D0CBB0 0x70 TrailBytes                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TrailByteCount                            = GetInt32(new IntPtr(p + 0x078)); // 024667D0CBD0 0x78 TrailByteCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x080)); // 024667D0CBF0 0x80 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x088)); // 024667D0CC10 0x88 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x08C)); // 024667D0CC30 0x8C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 024667D0CC50 0x90 Writer                      ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )

            return value;
        }
    }
}
