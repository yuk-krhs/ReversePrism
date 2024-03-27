using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheProduceCardStatusDtoList            000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CacheGetCardAmount                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A0 PopupCloseAction                         000186679A00 ModelClassType Action Action Action Pointer
    // 0A8 BasePopupClose                           000186679A00 ModelClassType Action Action Action Pointer
    public partial class ProduceCardFinishPopupParam
    {
        public List<IProduceCardStatus>?                CacheProduceCardStatusDtoList           { get; set; }
        public int                                      CacheGetCardAmount                      { get; set; }
        public Action?                                  PopupCloseAction                        { get; set; }
        public Action?                                  BasePopupClose                          { get; set; }

        public static ProduceCardFinishPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardFinishPopupParam();

            value.CacheProduceCardStatusDtoList             = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CDA720 0x90 CacheProduceCardStatusDtoList ( 000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheGetCardAmount                        = GetInt32(new IntPtr(p + 0x098)); // 0270D5CDA740 0x98 CacheGetCardAmount          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PopupCloseAction                          = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0270D5CDA760 0xA0 PopupCloseAction            ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.BasePopupClose                            = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0270D5CDA780 0xA8 BasePopupClose              ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
