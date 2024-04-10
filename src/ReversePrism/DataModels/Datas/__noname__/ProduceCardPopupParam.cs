using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CacheProduceCardStatusDtoList            000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CacheGettableProduceCardAmount           0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A0 DeckProduceCards                         000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class ProduceCardPopupParam : DataModel
    {
        public List<IProduceCardStatus>?                CacheProduceCardStatusDtoList           { get; set; }
        public int                                      CacheGettableProduceCardAmount          { get; set; }
        public List<IProduceCardStatus>?                DeckProduceCards                        { get; set; }

        public static ProduceCardPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardPopupParam() { Pointer= p0 };

            value.CacheProduceCardStatusDtoList             = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024665D2ABC8 0x90 CacheProduceCardStatusDtoList ( 000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CacheGettableProduceCardAmount            = GetInt32(new IntPtr(p + 0x098)); // 024665D2ABE8 0x98 CacheGettableProduceCardAmount ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DeckProduceCards                          = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024665D2AC08 0xA0 DeckProduceCards            ( 000185D06078 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
