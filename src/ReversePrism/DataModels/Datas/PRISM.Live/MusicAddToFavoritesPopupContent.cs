using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FavoriteNameMaxLength                    int IL2CPP_TYPE_I4
    // 060 FavoriteToggleButtons                    ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 068 FavoriteNameInputs                       ModelClassListType CommonInputFieldTMP[] CommonInputFieldTMP[] List<CommonInputFieldTMP> Pointer
    // 070 FavoriteNameLengthCounters               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 078 InvalidInputAnnotation                   ModelClassType GameObject GameObject GameObject Pointer
    // 080 initialStatuses                          Dictionary`2<FavoriteSongSlot, ValueTuple`2<bool, string>> IL2CPP_TYPE_GENERICINST
    // 088 okSubject                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class MusicAddToFavoritesPopupContent : DataModel
    {
        public List<ToggleButton>?                      FavoriteToggleButtons                   { get; set; }
        public List<CommonInputFieldTMP>?               FavoriteNameInputs                      { get; set; }
        public List<UITextMeshProUGUI>?                 FavoriteNameLengthCounters              { get; set; }
        public GameObject?                              InvalidInputAnnotation                  { get; set; }

        public static MusicAddToFavoritesPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicAddToFavoritesPopupContent() { Pointer= p0 };

            value.FavoriteToggleButtons                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x60 FavoriteToggleButtons       ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FavoriteNameInputs                        = GetObjectList<CommonInputFieldTMP>(new IntPtr(p + 0x068), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x68 FavoriteNameInputs          ( ModelClassListType CommonInputFieldTMP[] CommonInputFieldTMP[] List<CommonInputFieldTMP> Pointer )
            value.FavoriteNameLengthCounters                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 FavoriteNameLengthCounters  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.InvalidInputAnnotation                    = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 InvalidInputAnnotation      ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
