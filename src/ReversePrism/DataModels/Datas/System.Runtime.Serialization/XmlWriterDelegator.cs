using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   0001865D7080 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 018 DictionaryWriter                         0001865954B0 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer
    // 020 Depth                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 Prefixes                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CharChunkSize                            int IL2CPP_TYPE_I4
    // 000 ByteChunkSize                            int IL2CPP_TYPE_I4
    public partial class XmlWriterDelegator
    {
        public XmlWriter?                               Writer                                  { get; set; }
        public XmlDictionaryWriter?                     DictionaryWriter                        { get; set; }
        public int                                      Depth                                   { get; set; }
        public int                                      Prefixes                                { get; set; }

        public static XmlWriterDelegator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWriterDelegator();

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWriter.FromPointer); // 027004D904E0 0x10 Writer                      ( 0001865D7080 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.DictionaryWriter                          = GetObject<XmlDictionaryWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryWriter.FromPointer); // 027004D90500 0x18 DictionaryWriter            ( 0001865954B0 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 027004D90520 0x20 Depth                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Prefixes                                  = GetInt32(new IntPtr(p + 0x024)); // 027004D90540 0x24 Prefixes                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
