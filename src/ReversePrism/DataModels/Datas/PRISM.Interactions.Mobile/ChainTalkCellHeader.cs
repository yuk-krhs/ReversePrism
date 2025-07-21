using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconBody                                 ModelClassType GameObject GameObject GameObject Pointer
    // 028 IconImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 030 IconButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 TalkerNameText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ChainTextColor                           ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer
    // 048 Data                                     ModelClassType ChainTalkCellHeaderData ChainTalkCellHeaderData ChainTalkCellHeaderData Pointer
    public partial class ChainTalkCellHeader : DataModel
    {
        public GameObject?                              IconBody                                { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UIButton?                                IconButton                              { get; set; }
        public UITextMeshProUGUI?                       TalkerNameText                          { get; set; }
        public ChainTextColor?                          ChainTextColor                          { get; set; }
        public ChainTalkCellHeaderData?                 Data                                    { get; set; }

        public static ChainTalkCellHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellHeader() { Pointer= p0 };

            value.IconBody                                  = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 IconBody                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 IconImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 IconButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TalkerNameText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TalkerNameText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChainTextColor                            = GetObject<ChainTextColor>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChainTextColor.FromPointer); // 0x40 ChainTextColor              ( ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer )
            value.Data                                      = GetObject<ChainTalkCellHeaderData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkCellHeaderData.FromPointer); // 0x48 Data                        ( ModelClassType ChainTalkCellHeaderData ChainTalkCellHeaderData ChainTalkCellHeaderData Pointer )

            return value;
        }
    }
}
