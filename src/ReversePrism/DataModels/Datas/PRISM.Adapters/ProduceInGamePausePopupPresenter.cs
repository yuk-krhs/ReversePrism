using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceInGamePausePopupView IProduceInGamePausePopupView IProduceInGamePausePopupView Pointer
    // 018 ViewModel                                ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 020 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 028 EnemySkillDetailPopupViewModels          ModelClassListType IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> List<ProduceEnemySkillDetailPopupViewModel> Pointer
    // 030 onApplyProduceOptionSubject              Subject`1<ProduceOptionSaveData> IL2CPP_TYPE_GENERICINST
    // 038 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ProduceInGamePausePopupPresenter : DataModel
    {
        public IProduceInGamePausePopupView?            View                                    { get; set; }
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public List<ProduceEnemySkillDetailPopupViewModel>? EnemySkillDetailPopupViewModels         { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ProduceInGamePausePopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceInGamePausePopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceInGamePausePopupView.FromPointer); // 0x10 View                        ( ModelClassType IProduceInGamePausePopupView IProduceInGamePausePopupView IProduceInGamePausePopupView Pointer )
            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x20 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.EnemySkillDetailPopupViewModels           = GetObjectList<ProduceEnemySkillDetailPopupViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewModel.FromPointer); // 0x28 EnemySkillDetailPopupViewModels ( ModelClassListType IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> List<ProduceEnemySkillDetailPopupViewModel> Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
