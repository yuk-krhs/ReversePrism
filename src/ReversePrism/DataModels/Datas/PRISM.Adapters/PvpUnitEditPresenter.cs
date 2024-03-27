using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 ViewModel                                0001865F7270 ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer
    // 028 View                                     00018660B230 ModelClassType IPvpUnitEditView IPvpUnitEditView IPvpUnitEditView Pointer
    // 030 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 EventStatus                              00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 040 InitialUnitType                          000186613660 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 048 PvpUnitList                              000185D08918 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer
    // 050 DefencePvpUnitChangeableDate             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 060 FuFavoriteDisposable                     0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PvpUnitEditPresenter
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
        public IDisposable?                             FuFavoriteDisposable                    { get; set; }

        public static PvpUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditPresenter();

            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D661E258 0x10 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D661E278 0x18 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<PvpUnitEditViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpUnitEditViewModel.FromPointer); // 0270D661E298 0x20 ViewModel                   ( 0001865F7270 ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer )
            value.View                                      = GetObject<IPvpUnitEditView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpUnitEditView.FromPointer); // 0270D661E2B8 0x28 View                        ( 00018660B230 ModelClassType IPvpUnitEditView IPvpUnitEditView IPvpUnitEditView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x030)); // 0270D661E2D8 0x30 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0270D661E2F8 0x38 EventStatus                 ( 00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.InitialUnitType                           = (PvpUnitType)GetInt32(new IntPtr(p + 0x040)); // 0270D661E318 0x40 InitialUnitType             ( 000186613660 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.PvpUnitList                               = GetObjectList<IPvpUnitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPvpUnitStatus.FromPointer); // 0270D661E338 0x48 PvpUnitList                 ( 000185D08918 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x050)); // 0270D661E358 0x50 DefencePvpUnitChangeableDate ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FuFavoriteDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D661E378 0x60 FuFavoriteDisposable        ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
