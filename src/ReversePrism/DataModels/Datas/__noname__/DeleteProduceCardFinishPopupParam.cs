using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheDeleteProduceCardList               ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CacheDeleteCardAmount                    ModelPrimitiveType int int int Int32
    // 09C CacheMaxDeleteCardAmount                 ModelPrimitiveType int int int Int32
    // 0A0 BasePopupClose                           ModelClassType Action Action Action Pointer
    // 0A8 PopupCloseAction                         ModelClassType Action Action Action Pointer
    public partial class DeleteProduceCardFinishPopupParam : DataModel
    {
        public List<IProduceCardStatus>?                CacheDeleteProduceCardList              { get; set; }
        public int                                      CacheDeleteCardAmount                   { get; set; }
        public int                                      CacheMaxDeleteCardAmount                { get; set; }
        public Action?                                  BasePopupClose                          { get; set; }
        public Action?                                  PopupCloseAction                        { get; set; }

        public static DeleteProduceCardFinishPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardFinishPopupParam() { Pointer= p0 };

            value.CacheDeleteProduceCardList                = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x90 CacheDeleteProduceCardList  ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheDeleteCardAmount                     = GetInt32(new IntPtr(p + 0x098)); // 0x98 CacheDeleteCardAmount       ( ModelPrimitiveType int int int Int32 )
            value.CacheMaxDeleteCardAmount                  = GetInt32(new IntPtr(p + 0x09C)); // 0x9C CacheMaxDeleteCardAmount    ( ModelPrimitiveType int int int Int32 )
            value.BasePopupClose                            = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0xA0 BasePopupClose              ( ModelClassType Action Action Action Pointer )
            value.PopupCloseAction                          = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0xA8 PopupCloseAction            ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
