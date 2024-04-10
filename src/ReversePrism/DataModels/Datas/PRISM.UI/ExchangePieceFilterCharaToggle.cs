using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaIcon                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 CharaName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 selectSubject                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.CharaIcon                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0246654719F8 0x20 CharaIcon                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CharaName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665471A18 0x28 CharaName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x038)); // 024665471A58 0x38 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
