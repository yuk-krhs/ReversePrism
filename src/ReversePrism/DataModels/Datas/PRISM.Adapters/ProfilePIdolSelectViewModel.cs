using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecideReactiveProperty                   0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 PIdolIcons                               000185B99EC0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 020 PIdolIconViewModels                      000185B9E7C0 ModelClassListType ProfilePIdolIconViewModel[] ProfilePIdolIconViewModel[] List<ProfilePIdolIconViewModel> Pointer
    // 028 SelectFavoritePIdolId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 sortFilterSaveData                       SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 038 sortFilterModel                          ProduceIdolSelectModel`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 040 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 CursorSelectedPIdol                      00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    public partial class ProfilePIdolSelectViewModel : DataModel
    {
        public BoolReactiveProperty?                    DecideReactiveProperty                  { get; set; }
        public List<PIdolIcon>?                         PIdolIcons                              { get; set; }
        public List<ProfilePIdolIconViewModel>?         PIdolIconViewModels                     { get; set; }
        public int                                      SelectFavoritePIdolId                   { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public PIdolIcon?                               CursorSelectedPIdol                     { get; set; }

        public static ProfilePIdolSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectViewModel() { Pointer= p0 };

            value.DecideReactiveProperty                    = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0246666E7AE0 0x10 DecideReactiveProperty      ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.PIdolIcons                                = GetObjectList<PIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0246666E7B00 0x18 PIdolIcons                  ( 000185B99EC0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.PIdolIconViewModels                       = GetObjectList<ProfilePIdolIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilePIdolIconViewModel.FromPointer); // 0246666E7B20 0x20 PIdolIconViewModels         ( 000185B9E7C0 ModelClassListType ProfilePIdolIconViewModel[] ProfilePIdolIconViewModel[] List<ProfilePIdolIconViewModel> Pointer )
            value.SelectFavoritePIdolId                     = GetInt32(new IntPtr(p + 0x028)); // 0246666E7B40 0x28 SelectFavoritePIdolId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246666E7BA0 0x40 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CursorSelectedPIdol                       = GetObject<PIdolIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0246666E7BC0 0x48 CursorSelectedPIdol         ( 00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )

            return value;
        }
    }
}
