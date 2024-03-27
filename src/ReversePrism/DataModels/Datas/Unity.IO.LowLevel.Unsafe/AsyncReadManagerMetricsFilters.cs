using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeIDs                                  000185B84580 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 018 States                                   000185B9C5B0 ModelEnumListType ProcessingState[] ProcessingState[] List<ProcessingState> Pointer
    // 020 ReadTypes                                000185B7F350 ModelEnumListType FileReadType[] FileReadType[] List<FileReadType> Pointer
    // 028 PriorityLevels                           000185B9C2E0 ModelEnumListType Priority[] Priority[] List<Priority> Pointer
    // 030 Subsystems                               000185B709F0 ModelEnumListType AssetLoadingSubsystem[] AssetLoadingSubsystem[] List<AssetLoadingSubsystem> Pointer
    public partial class AsyncReadManagerMetricsFilters
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
            var value   = new AsyncReadManagerMetricsFilters();

            value.TypeIDs                                   = GetUInt64List(new IntPtr(p + 0x010)); // 0270022F98E8 0x10 TypeIDs                     ( 000185B84580 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.States                                    = GetEnumList<ProcessingState>(new IntPtr(p + 0x018)); // 0270022F9908 0x18 States                      ( 000185B9C5B0 ModelEnumListType ProcessingState[] ProcessingState[] List<ProcessingState> Pointer )
            value.ReadTypes                                 = GetEnumList<FileReadType>(new IntPtr(p + 0x020)); // 0270022F9928 0x20 ReadTypes                   ( 000185B7F350 ModelEnumListType FileReadType[] FileReadType[] List<FileReadType> Pointer )
            value.PriorityLevels                            = GetEnumList<Priority>(new IntPtr(p + 0x028)); // 0270022F9948 0x28 PriorityLevels              ( 000185B9C2E0 ModelEnumListType Priority[] Priority[] List<Priority> Pointer )
            value.Subsystems                                = GetEnumList<AssetLoadingSubsystem>(new IntPtr(p + 0x030)); // 0270022F9968 0x30 Subsystems                  ( 000185B709F0 ModelEnumListType AssetLoadingSubsystem[] AssetLoadingSubsystem[] List<AssetLoadingSubsystem> Pointer )

            return value;
        }
    }
}
