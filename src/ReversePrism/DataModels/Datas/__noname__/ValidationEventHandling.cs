using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer
    // 018 EventHandler                             ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    public partial class ValidationEventHandling : DataModel
    {
        public XmlValidatingReaderImpl?                 Reader                                  { get; set; }
        public ValidationEventHandler?                  EventHandler                            { get; set; }

        public static ValidationEventHandling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationEventHandling() { Pointer= p0 };

            value.Reader                                    = GetObject<XmlValidatingReaderImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlValidatingReaderImpl.FromPointer); // 0x10 Reader                      ( ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x18 EventHandler                ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )

            return value;
        }
    }
}
