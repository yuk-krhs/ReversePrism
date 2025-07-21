using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDocumentArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DocumentTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 DocumentType                             ModelEnumType ShopDocumentType ShopDocumentType ShopDocumentType Int32
    public partial class GetDocumentArgs : DataModel
    {
        public ShopDocumentType                         DocumentType                            { get; set; }

        public static GetDocumentArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDocumentArgs() { Pointer= p0 };

            value.DocumentType                              = (ShopDocumentType)GetInt32(new IntPtr(p + 0x018)); // 0x18 DocumentType                ( ModelEnumType ShopDocumentType ShopDocumentType ShopDocumentType Int32 )

            return value;
        }
    }
}
