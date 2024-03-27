using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 IconViews                                000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 050 SpaceLine                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 060 Data                                     00018655A700 ModelClassType LiveMVIdolListCellData LiveMVIdolListCellData LiveMVIdolListCellData Pointer
    public partial class LiveMVIdolListCell
    {
        public UIRawImage?                              UnitIcon                                { get; set; }
        public List<PFIdolIconView>?                    IconViews                               { get; set; }
        public GameObject?                              SpaceLine                               { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public LiveMVIdolListCellData?                  Data                                    { get; set; }

        public static LiveMVIdolListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVIdolListCell();

            value.UnitIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D51B5CF8 0x40 UnitIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.IconViews                                 = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D51B5D18 0x48 IconViews                   ( 000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.SpaceLine                                 = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D51B5D38 0x50 SpaceLine                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x058)); // 0270D51B5D58 0x58 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.Data                                      = GetObject<LiveMVIdolListCellData>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveMVIdolListCellData.FromPointer); // 0270D51B5D78 0x60 Data                        ( 00018655A700 ModelClassType LiveMVIdolListCellData LiveMVIdolListCellData LiveMVIdolListCellData Pointer )

            return value;
        }
    }
}
