using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheDeleteProduceCardList               ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CacheProduceBaseInfo                     ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 0A0 CacheDeleteCardAmount                    ModelPrimitiveType int int int Int32
    // 0A4 CacheMaxDeleteCardAmount                 ModelPrimitiveType int int int Int32
    // 0A8 BasePopupClose                           ModelClassType Action Action Action Pointer
    public partial class DeleteProduceCardConfirmPopupParam : DataModel
    {
        public List<IProduceCardStatus>?                CacheDeleteProduceCardList              { get; set; }
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }
        public int                                      CacheDeleteCardAmount                   { get; set; }
        public int                                      CacheMaxDeleteCardAmount                { get; set; }
        public Action?                                  BasePopupClose                          { get; set; }

        public static DeleteProduceCardConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardConfirmPopupParam() { Pointer= p0 };

            value.CacheDeleteProduceCardList                = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x90 CacheDeleteProduceCardList  ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x98 CacheProduceBaseInfo        ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheDeleteCardAmount                     = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 CacheDeleteCardAmount       ( ModelPrimitiveType int int int Int32 )
            value.CacheMaxDeleteCardAmount                  = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 CacheMaxDeleteCardAmount    ( ModelPrimitiveType int int int Int32 )
            value.BasePopupClose                            = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0xA8 BasePopupClose              ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
