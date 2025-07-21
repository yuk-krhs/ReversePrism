using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CmnTableTds                              ModelClassListType CmnTableTd[] CmnTableTd[] List<CmnTableTd> Pointer
    // 028 GoLastLine                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoWhite                                  ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoBlue                                   ModelClassType GameObject GameObject GameObject Pointer
    // 040 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 Index                                    ModelPrimitiveType int int int Int32
    // 050 Tds                                      ModelClassListType List`1<CmnTableTd> List`1<CmnTableTd> List<CmnTableTd> Pointer
    public partial class CmnTableTr : DataModel
    {
        public List<CmnTableTd>?                        CmnTableTds                             { get; set; }
        public GameObject?                              GoLastLine                              { get; set; }
        public GameObject?                              GoWhite                                 { get; set; }
        public GameObject?                              GoBlue                                  { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public int                                      Index                                   { get; set; }
        public List<CmnTableTd>?                        Tds                                     { get; set; }

        public static CmnTableTr? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CmnTableTr() { Pointer= p0 };

            value.CmnTableTds                               = GetObjectList<CmnTableTd>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnTableTd.FromPointer); // 0x20 CmnTableTds                 ( ModelClassListType CmnTableTd[] CmnTableTd[] List<CmnTableTd> Pointer )
            value.GoLastLine                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoLastLine                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoWhite                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoWhite                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBlue                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoBlue                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Tds                                       = GetObjectList<CmnTableTd>(new IntPtr(p + 0x050), ReversePrism.DataModels.CmnTableTd.FromPointer); // 0x50 Tds                         ( ModelClassListType List`1<CmnTableTd> List`1<CmnTableTd> List<CmnTableTd> Pointer )

            return value;
        }
    }
}
