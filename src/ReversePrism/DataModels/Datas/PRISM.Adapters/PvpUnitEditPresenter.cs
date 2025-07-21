using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 ViewModel                                ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer
    // 028 View                                     ModelClassType IPvpUnitEditView IPvpUnitEditView IPvpUnitEditView Pointer
    // 030 EventId                                  ModelPrimitiveType int int int Int32
    // 038 EventStatus                              ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 040 InitialUnitType                          ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 048 PvpUnitList                              ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer
    // 050 DefencePvpUnitChangeableDate             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class PvpUnitEditPresenter : DataModel
    {
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public PvpUnitEditViewModel?                    ViewModel                               { get; set; }
        public IPvpUnitEditView?                        View                                    { get; set; }
        public int                                      EventId                                 { get; set; }
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public PvpUnitType                              InitialUnitType                         { get; set; }
        public List<IPvpUnitStatus>?                    PvpUnitList                             { get; set; }
        public DateTime                                 DefencePvpUnitChangeableDate            { get; set; }

        public static PvpUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditPresenter() { Pointer= p0 };

            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<PvpUnitEditViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpUnitEditViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer )
            value.View                                      = GetObject<IPvpUnitEditView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpUnitEditView.FromPointer); // 0x28 View                        ( ModelClassType IPvpUnitEditView IPvpUnitEditView IPvpUnitEditView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0x38 EventStatus                 ( ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.InitialUnitType                           = (PvpUnitType)GetInt32(new IntPtr(p + 0x040)); // 0x40 InitialUnitType             ( ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.PvpUnitList                               = GetObjectList<IPvpUnitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPvpUnitStatus.FromPointer); // 0x48 PvpUnitList                 ( ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x050)); // 0x50 DefencePvpUnitChangeableDate ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
