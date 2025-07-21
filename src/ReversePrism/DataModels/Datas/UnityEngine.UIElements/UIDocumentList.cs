using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AttachedUIDocuments                    ModelClassListType List`1<UIDocument> List`1<UIDocument> List<UIDocument> Pointer
    public partial class UIDocumentList : DataModel
    {
        public List<UIDocument>?                        M_AttachedUIDocuments                   { get; set; }

        public static UIDocumentList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIDocumentList() { Pointer= p0 };

            value.M_AttachedUIDocuments                     = GetObjectList<UIDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.UIDocument.FromPointer); // 0x10 M_AttachedUIDocuments       ( ModelClassListType List`1<UIDocument> List`1<UIDocument> List<UIDocument> Pointer )

            return value;
        }
    }
}
