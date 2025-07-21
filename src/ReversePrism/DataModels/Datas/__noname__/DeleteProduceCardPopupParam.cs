using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheDeleteProduceCardAmount             ModelPrimitiveType int int int Int32
    // 098 DeletableCards                           ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class DeleteProduceCardPopupParam : DataModel
    {
        public int                                      CacheDeleteProduceCardAmount            { get; set; }
        public List<IProduceCardStatus>?                DeletableCards                          { get; set; }

        public static DeleteProduceCardPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardPopupParam() { Pointer= p0 };

            value.CacheDeleteProduceCardAmount              = GetInt32(new IntPtr(p + 0x090)); // 0x90 CacheDeleteProduceCardAmount ( ModelPrimitiveType int int int Int32 )
            value.DeletableCards                            = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x98 DeletableCards              ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
