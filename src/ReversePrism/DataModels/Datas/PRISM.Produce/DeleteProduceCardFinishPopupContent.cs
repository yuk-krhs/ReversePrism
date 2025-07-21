using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 DeleteMesseageText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CacheGetDeleteAmount                     ModelPrimitiveType int int int Int32
    // 06C CacheMaxGetDeleteAmount                  ModelPrimitiveType int int int Int32
    // 070 IsLessThan                               ModelPrimitiveType bool bool bool Bool
    public partial class DeleteProduceCardFinishPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       DeleteMesseageText                      { get; set; }
        public int                                      CacheGetDeleteAmount                    { get; set; }
        public int                                      CacheMaxGetDeleteAmount                 { get; set; }
        public bool                                     IsLessThan                              { get; set; }

        public static DeleteProduceCardFinishPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardFinishPopupContent() { Pointer= p0 };

            value.DeleteMesseageText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 DeleteMesseageText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CacheGetDeleteAmount                      = GetInt32(new IntPtr(p + 0x068)); // 0x68 CacheGetDeleteAmount        ( ModelPrimitiveType int int int Int32 )
            value.CacheMaxGetDeleteAmount                   = GetInt32(new IntPtr(p + 0x06C)); // 0x6C CacheMaxGetDeleteAmount     ( ModelPrimitiveType int int int Int32 )
            value.IsLessThan                                = GetBool(new IntPtr(p + 0x070)); // 0x70 IsLessThan                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
