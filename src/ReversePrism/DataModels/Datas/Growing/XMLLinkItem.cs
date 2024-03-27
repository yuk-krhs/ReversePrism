using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TextItemRootList                         000185D00AE8 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer
    // 068 LayoutElementList                        000185CEFB18 ModelClassListType List`1<LayoutElement> List`1<LayoutElement> List<LayoutElement> Pointer
    // 070 ArrowItemRootList                        000185D00AE8 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer
    // 000 TEXT_MARGIN                              float IL2CPP_TYPE_R4
    // 078 Sequence                                 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer
    public partial class XMLLinkItem
    {
        public List<RectTransform>?                     TextItemRootList                        { get; set; }
        public List<LayoutElement>?                     LayoutElementList                       { get; set; }
        public List<RectTransform>?                     ArrowItemRootList                       { get; set; }
        public Sequence?                                Sequence                                { get; set; }

        public static XMLLinkItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLLinkItem();

            value.TextItemRootList                          = GetObjectList<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4B3E478 0x60 TextItemRootList            ( 000185D00AE8 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer )
            value.LayoutElementList                         = GetObjectList<LayoutElement>(new IntPtr(p + 0x068), ReversePrism.DataModels.LayoutElement.FromPointer); // 0270D4B3E498 0x68 LayoutElementList           ( 000185CEFB18 ModelClassListType List`1<LayoutElement> List`1<LayoutElement> List<LayoutElement> Pointer )
            value.ArrowItemRootList                         = GetObjectList<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4B3E4B8 0x70 ArrowItemRootList           ( 000185D00AE8 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x078), ReversePrism.DataModels.Sequence.FromPointer); // 0270D4B3E4F8 0x78 Sequence                    ( 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
