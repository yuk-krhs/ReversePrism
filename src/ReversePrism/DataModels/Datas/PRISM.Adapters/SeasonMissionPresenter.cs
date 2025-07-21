using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType SeasonMissionModel SeasonMissionModel SeasonMissionModel Pointer
    // 018 ViewModel                                ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer
    // 020 View                                     ModelClassType ISeasonMissionView ISeasonMissionView ISeasonMissionView Pointer
    // 028 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 OnCloseEvent                             ModelClassType Action Action Action Pointer
    // 038 onShopOpen                               Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 terminateTask                            UniTaskCompletionSource`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SeasonMissionPresenter : DataModel
    {
        public SeasonMissionModel?                      Model                                   { get; set; }
        public SeasonMissionViewModel?                  ViewModel                               { get; set; }
        public ISeasonMissionView?                      View                                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public Action?                                  OnCloseEvent                            { get; set; }

        public static SeasonMissionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<SeasonMissionModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SeasonMissionModel.FromPointer); // 0x10 Model                       ( ModelClassType SeasonMissionModel SeasonMissionModel SeasonMissionModel Pointer )
            value.ViewModel                                 = GetObject<SeasonMissionViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonMissionViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer )
            value.View                                      = GetObject<ISeasonMissionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISeasonMissionView.FromPointer); // 0x20 View                        ( ModelClassType ISeasonMissionView ISeasonMissionView ISeasonMissionView Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.OnCloseEvent                              = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 OnCloseEvent                ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
