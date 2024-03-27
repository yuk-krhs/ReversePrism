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
    // 0A0 BasePopupClose                           000186679A00 ModelClassType Action Action Action Pointer
    public partial class ProduceCardConfirmPopupParam
    {
        public List<IProduceCardStatus>?                CacheProduceCardStatusDtoList           { get; set; }
        public int                                      CacheGetCardAmount                      { get; set; }
        public Action?                                  BasePopupClose                          { get; set; }

        public static ProduceCardConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardConfirmPopupParam();

            value.CacheProduceCardStatusDtoList             = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CDA248 0x90 CacheProduceCardStatusDtoList ( 000185CE71C8 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheGetCardAmount                        = GetInt32(new IntPtr(p + 0x098)); // 0270D5CDA268 0x98 CacheGetCardAmount          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BasePopupClose                            = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0270D5CDA288 0xA0 BasePopupClose              ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
