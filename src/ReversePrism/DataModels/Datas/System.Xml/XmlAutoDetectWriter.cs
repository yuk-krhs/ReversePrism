using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Wrapped                                  0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    // 030 OnRemove                                 0001866DB1B0 ModelClassType OnRemoveWriter OnRemoveWriter OnRemoveWriter Pointer
    // 038 WriterSettings                           0001865D7EA0 ModelClassType XmlWriterSettings XmlWriterSettings XmlWriterSettings Pointer
    // 040 EventCache                               00018659A640 ModelClassType XmlEventCache XmlEventCache XmlEventCache Pointer
    // 048 TextWriter                               00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer
    // 050 Strm                                     000186670270 ModelClassType Stream Stream Stream Pointer
    public partial class XmlAutoDetectWriter : DataModel
    {
        public XmlRawWriter?                            Wrapped                                 { get; set; }
        public OnRemoveWriter?                          OnRemove                                { get; set; }
        public XmlWriterSettings?                       WriterSettings                          { get; set; }
        public XmlEventCache?                           EventCache                              { get; set; }
        public TextWriter?                              TextWriter                              { get; set; }
        public Stream?                                  Strm                                    { get; set; }

        public static XmlAutoDetectWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAutoDetectWriter() { Pointer= p0 };

            value.Wrapped                                   = GetObject<XmlRawWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 0246673ED610 0x28 Wrapped                     ( 0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )
            value.OnRemove                                  = GetObject<OnRemoveWriter>(new IntPtr(p + 0x030), ReversePrism.DataModels.OnRemoveWriter.FromPointer); // 0246673ED630 0x30 OnRemove                    ( 0001866DB1B0 ModelClassType OnRemoveWriter OnRemoveWriter OnRemoveWriter Pointer )
            value.WriterSettings                            = GetObject<XmlWriterSettings>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlWriterSettings.FromPointer); // 0246673ED650 0x38 WriterSettings              ( 0001865D7EA0 ModelClassType XmlWriterSettings XmlWriterSettings XmlWriterSettings Pointer )
            value.EventCache                                = GetObject<XmlEventCache>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlEventCache.FromPointer); // 0246673ED670 0x40 EventCache                  ( 00018659A640 ModelClassType XmlEventCache XmlEventCache XmlEventCache Pointer )
            value.TextWriter                                = GetObject<TextWriter>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextWriter.FromPointer); // 0246673ED690 0x48 TextWriter                  ( 00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer )
            value.Strm                                      = GetObject<Stream>(new IntPtr(p + 0x050), ReversePrism.DataModels.Stream.FromPointer); // 0246673ED6B0 0x50 Strm                        ( 000186670270 ModelClassType Stream Stream Stream Pointer )

            return value;
        }
    }
}
