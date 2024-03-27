using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 ProduceCardObjectList                    000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 068 DeleteProduceCardContentList             000185CFB9B8 ModelClassListType List`1<ProduceCardContent> List`1<ProduceCardContent> List<ProduceCardContent> Pointer
    // 070 DeleteMesseageText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 DeleteAmount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C CacheDeleteAmount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 CacheDeleteProduceCardContentList        000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class DeleteProduceCardConfirmPopupContent
    {
        public List<GameObject>?                        ProduceCardObjectList                   { get; set; }
        public List<ProduceCardContent>?                DeleteProduceCardContentList            { get; set; }
        public UITextMeshProUGUI?                       DeleteMesseageText                      { get; set; }
        public int                                      DeleteAmount                            { get; set; }
        public int                                      CacheDeleteAmount                       { get; set; }
        public List<IProduceCardStatus>?                CacheDeleteProduceCardContentList       { get; set; }

        public static DeleteProduceCardConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardConfirmPopupContent();

            value.ProduceCardObjectList                     = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CBBBD0 0x60 ProduceCardObjectList       ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DeleteProduceCardContentList              = GetObjectList<ProduceCardContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0270D5CBBBF0 0x68 DeleteProduceCardContentList ( 000185CFB9B8 ModelClassListType List`1<ProduceCardContent> List`1<ProduceCardContent> List<ProduceCardContent> Pointer )
            value.DeleteMesseageText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CBBC10 0x70 DeleteMesseageText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeleteAmount                              = GetInt32(new IntPtr(p + 0x078)); // 0270D5CBBC30 0x78 DeleteAmount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheDeleteAmount                         = GetInt32(new IntPtr(p + 0x07C)); // 0270D5CBBC50 0x7C CacheDeleteAmount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheDeleteProduceCardContentList         = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CBBC70 0x80 CacheDeleteProduceCardContentList ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
