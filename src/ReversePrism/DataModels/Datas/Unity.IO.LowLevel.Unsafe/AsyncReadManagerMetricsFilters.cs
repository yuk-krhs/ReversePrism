using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeIDs                                  ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 018 States                                   ModelEnumListType ProcessingState[] ProcessingState[] List<ProcessingState> Pointer
    // 020 ReadTypes                                ModelEnumListType FileReadType[] FileReadType[] List<FileReadType> Pointer
    // 028 PriorityLevels                           ModelEnumListType Priority[] Priority[] List<Priority> Pointer
    // 030 Subsystems                               ModelEnumListType AssetLoadingSubsystem[] AssetLoadingSubsystem[] List<AssetLoadingSubsystem> Pointer
    public partial class AsyncReadManagerMetricsFilters : DataModel
    {
        public List<ulong>?                             TypeIDs                                 { get; set; }
        public List<ProcessingState>?                   States                                  { get; set; }
        public List<FileReadType>?                      ReadTypes                               { get; set; }
        public List<Priority>?                          PriorityLevels                          { get; set; }
        public List<AssetLoadingSubsystem>?             Subsystems                              { get; set; }

        public static AsyncReadManagerMetricsFilters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncReadManagerMetricsFilters() { Pointer= p0 };

            value.TypeIDs                                   = GetUInt64List(new IntPtr(p + 0x010)); // 0x10 TypeIDs                     ( ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.States                                    = GetEnumList<ProcessingState>(new IntPtr(p + 0x018)); // 0x18 States                      ( ModelEnumListType ProcessingState[] ProcessingState[] List<ProcessingState> Pointer )
            value.ReadTypes                                 = GetEnumList<FileReadType>(new IntPtr(p + 0x020)); // 0x20 ReadTypes                   ( ModelEnumListType FileReadType[] FileReadType[] List<FileReadType> Pointer )
            value.PriorityLevels                            = GetEnumList<Priority>(new IntPtr(p + 0x028)); // 0x28 PriorityLevels              ( ModelEnumListType Priority[] Priority[] List<Priority> Pointer )
            value.Subsystems                                = GetEnumList<AssetLoadingSubsystem>(new IntPtr(p + 0x030)); // 0x30 Subsystems                  ( ModelEnumListType AssetLoadingSubsystem[] AssetLoadingSubsystem[] List<AssetLoadingSubsystem> Pointer )

            return value;
        }
    }
}
