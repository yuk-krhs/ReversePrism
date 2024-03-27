using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheDeleteProduceCardList               000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CacheProduceBaseInfo                     0001865E3190 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 0A0 CacheDeleteCardAmount                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 CacheMaxDeleteCardAmount                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 BasePopupClose                           000186679A00 ModelClassType Action Action Action Pointer
    public partial class DeleteProduceCardConfirmPopupParam
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
            var value   = new DeleteProduceCardConfirmPopupParam();

            value.CacheDeleteProduceCardList                = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CBBAB0 0x90 CacheDeleteProduceCardList  ( 000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D5CBBAD0 0x98 CacheProduceBaseInfo        ( 0001865E3190 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheDeleteCardAmount                     = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5CBBAF0 0xA0 CacheDeleteCardAmount       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CacheMaxDeleteCardAmount                  = GetInt32(new IntPtr(p + 0x0A4)); // 0270D5CBBB10 0xA4 CacheMaxDeleteCardAmount    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BasePopupClose                            = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0270D5CBBB30 0xA8 BasePopupClose              ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
