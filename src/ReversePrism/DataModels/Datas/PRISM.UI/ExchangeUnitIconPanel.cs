using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 IconPrefab                               00018650FFB0 ModelClassType ExchangePieceFilterCharaToggle ExchangePieceFilterCharaToggle ExchangePieceFilterCharaToggle Pointer
    // 030 Content                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 IconList                                 000185CDAC48 ModelClassListType List`1<ExchangePieceFilterCharaToggle> List`1<ExchangePieceFilterCharaToggle> List<ExchangePieceFilterCharaToggle> Pointer
    public partial class ExchangeUnitIconPanel : DataModel
    {
        public UIRawImage?                              UnitIcon                                { get; set; }
        public ExchangePieceFilterCharaToggle?          IconPrefab                              { get; set; }
        public Transform?                               Content                                 { get; set; }
        public List<ExchangePieceFilterCharaToggle>?    IconList                                { get; set; }

        public static ExchangeUnitIconPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeUnitIconPanel() { Pointer= p0 };

            value.UnitIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665471B98 0x20 UnitIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.IconPrefab                                = GetObject<ExchangePieceFilterCharaToggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangePieceFilterCharaToggle.FromPointer); // 024665471BB8 0x28 IconPrefab                  ( 00018650FFB0 ModelClassType ExchangePieceFilterCharaToggle ExchangePieceFilterCharaToggle ExchangePieceFilterCharaToggle Pointer )
            value.Content                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 024665471BD8 0x30 Content                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.IconList                                  = GetObjectList<ExchangePieceFilterCharaToggle>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExchangePieceFilterCharaToggle.FromPointer); // 024665471BF8 0x38 IconList                    ( 000185CDAC48 ModelClassListType List`1<ExchangePieceFilterCharaToggle> List`1<ExchangePieceFilterCharaToggle> List<ExchangePieceFilterCharaToggle> Pointer )

            return value;
        }
    }
}
