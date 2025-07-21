using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaIcon                                ModelClassType UIImage UIImage UIImage Pointer
    // 028 CharaName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 selectSubject                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 CharaId                                  ModelPrimitiveType int int int Int32
    public partial class ExchangePieceFilterCharaToggle : DataModel
    {
        public UIImage?                                 CharaIcon                               { get; set; }
        public UITextMeshProUGUI?                       CharaName                               { get; set; }
        public int                                      CharaId                                 { get; set; }

        public static ExchangePieceFilterCharaToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePieceFilterCharaToggle() { Pointer= p0 };

            value.CharaIcon                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 CharaIcon                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CharaName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CharaName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 CharaId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
