using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 maxSelectedCharacterCount                int IL2CPP_TYPE_I4
    // 010 CellDataArray                            000185CA7348 ModelClassListType StorySortFilterCharacterFilterCellData[] StorySortFilterCharacterFilterCellData[] List<StorySortFilterCharacterFilterCellData> Pointer
    // 018 selectedCharacterCount                   ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    // 020 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 <CellContainerDataList>k__BackingField   IEnumerable`1<StorySortFilterCharacterFilterCellContainerData> IL2CPP_TYPE_GENERICINST
    public partial class StorySortFilterCharacterFilterViewModel : DataModel
    {
        public List<StorySortFilterCharacterFilterCellData>? CellDataArray                           { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static StorySortFilterCharacterFilterViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterViewModel() { Pointer= p0 };

            value.CellDataArray                             = GetObjectList<StorySortFilterCharacterFilterCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorySortFilterCharacterFilterCellData.FromPointer); // 024666820978 0x10 CellDataArray               ( 000185CA7348 ModelClassListType StorySortFilterCharacterFilterCellData[] StorySortFilterCharacterFilterCellData[] List<StorySortFilterCharacterFilterCellData> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668209B8 0x20 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
